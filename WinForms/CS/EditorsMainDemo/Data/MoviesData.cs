using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Internal;

namespace DevExpress.XtraEditors.Demos.Data {
    public static class MoviesData {
        [Flags]
        public enum MovieGenre {
            None = 0, Action = 0x1, Adventure = 0x2, Animation = 0x4, Biography = 0x8, Comedy = 0x10, Crime = 0x20,
            Documentary = 0x40, Drama = 0x80, Family = 0x100, Fantasy = 0x200, History = 0x400, Horror = 0x800,
            Music = 0x1000, Musical = 0x2000, Mystery = 0x4000, Romance = 0x8000, SciFi = 0x10000, Sport = 0x20000,
            Thriller = 0x40000, War = 0x80000, Western = 0x100000
        }
        static DataSet XmlDataSet;
        public static IList<Producer> Producers;
        public static IList<Movie> Movies;
        public static void Load() {
            InitDataSet();
            if(Producers == null)
                Producers = LoadProducers().ToList();
            if(Movies == null)
                Movies = LoadMovies().ToList();
        }
        static void InitDataSet() {
            if(XmlDataSet == null) {
                XmlDataSet = new DataSet();
                XmlDataSet.ReadXml(DataDirectoryHelper.GetDataFile("VideoRent.xml"));
            }
        }
        static IEnumerable<Movie> LoadMovies() {
            var tableMovie = XmlDataSet.Tables["Movie"] as DataTable;
            var tableMovieArtist = XmlDataSet.Tables["MovieArtist"] as DataTable;
            var tableMovieArtistLine = XmlDataSet.Tables["MovieArtistLine"] as DataTable;
            var tablePerson = XmlDataSet.Tables["Person"] as DataTable;
            var tableMovieCountry = XmlDataSet.Tables["MovieMovies_CountryCountries"] as DataTable;
            var tableCountry = XmlDataSet.Tables["Country"] as DataTable;

            var movie = from m in tableMovie.AsEnumerable()
                        join ma in tableMovieArtist.AsEnumerable()
                        on m.Field<Guid>("Oid") equals ma.Field<Guid>("Movie")
                        join mal in tableMovieArtistLine.AsEnumerable()
                        on ma.Field<Guid>("Line") equals mal.Field<Guid>("Oid")
                        join p in tablePerson.AsEnumerable()
                        on ma.Field<Guid>("Artist") equals p.Field<Guid>("Oid")
                        join mc in tableMovieCountry.AsEnumerable()
                        on m.Field<Guid>("Oid") equals mc.Field<Guid>("Movies")
                        join c in tableCountry.AsEnumerable()
                        on mc.Field<Guid>("Countries") equals c.Field<Guid>("Oid")

                        where mal.Field<string>("Name").Equals("Director")
                        select new Movie() {
                            MovieTitle = m.Field<string>("Title"),
                            Release = m.Field<DateTime>("ReleaseDate").Year,
                            Genres = GetGenres(m.Field<int>("Genre")),
                            Producers = p.Field<string>("FirstName") + " " + p.Field<string>("LastName"),
                            Countries = c.Field<string>("Name")
                        };

            return from m in movie.AsEnumerable()
                   group m by new {
                       MovieTitle = m.MovieTitle,
                       MovieRelease = m.Release,
                       MovieGenre = m.Genres,
                   }
                      into groupWithProducers
                   select new Movie() {
                       MovieTitle = groupWithProducers.Key.MovieTitle,
                       Release = groupWithProducers.Key.MovieRelease,
                       Genres = groupWithProducers.Key.MovieGenre,
                       Producers = string.Join(", ", groupWithProducers.Select(x => x.Producers).Distinct()),
                       Countries = string.Join(", ", groupWithProducers.Select(x => x.Countries).Distinct()),
                   };
        }
        static IEnumerable<Producer> LoadProducers() {
            var tableMovieArtist = XmlDataSet.Tables["MovieArtist"] as DataTable;
            var tableMovieArtistLine = XmlDataSet.Tables["MovieArtistLine"] as DataTable;
            var tablePerson = XmlDataSet.Tables["Person"] as DataTable;
            return from ma in tableMovieArtist.AsEnumerable()
                   join mal in tableMovieArtistLine.AsEnumerable()
                   on ma.Field<Guid>("Line") equals mal.Field<Guid>("Oid")
                   join p in tablePerson.AsEnumerable()
                   on ma.Field<Guid>("Artist") equals p.Field<Guid>("Oid")
                   where mal.Field<string>("Name").Equals("Director")
                   orderby p.Field<string>("FirstName") + p.Field<string>("LastName")
                   select new Producer(p.Field<Guid>("Oid"), p.Field<string>("FirstName") + " " + p.Field<string>("LastName"));
        }
        static string GetGenres(int value) {
            var genres = (MovieGenre)value;
            return genres.ToString("G");
        }

        public class Movie {
            public string MovieTitle { get; set; }
            public int Release { get; set; }
            public string Genres { get; set; }
            public string Producers { get; set; }
            public string Countries { get; set; }
        }
        public class Producer {
            public Producer(Guid id, string name) {
                Id = id;
                Name = name;
            }
            public Guid Id { get; set; }
            public string Name { get; set; }
        }
    }
}
