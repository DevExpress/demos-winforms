using System;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using DevExpress.Internal;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.AI.Demos.Modules.SemanticSearch {
    public class Movie {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Plot { get; set; }
        public string Genre { get; set; }
        public Image Photo { get; set; }
        public DateTime Release { get; set; }
        public string Directors { get; set; }
    }

    public class SemanticSearchDataHelper {
        [Flags]
        public enum MovieGenre {
            None = 0, Action = 0x1, Adventure = 0x2, Animation = 0x4, Biography = 0x8, Comedy = 0x10, Crime = 0x20,
            Documentary = 0x40, Drama = 0x80, Family = 0x100, Fantasy = 0x200, History = 0x400, Horror = 0x800,
            Music = 0x1000, Musical = 0x2000, Mystery = 0x4000, Romance = 0x8000, SciFi = 0x10000, Sport = 0x20000,
            Thriller = 0x40000, War = 0x80000, Western = 0x100000
        }

        public static IList<Movie> Movies { get; private set; }

        public static void Load() {
            if(Movies != null)
                return;

            var dataSet = new DataSet();
            dataSet.ReadXml(DataDirectoryHelper.GetDataFile("VideoRent.xml"));
            var directorLineId = dataSet.Tables["MovieArtistLine"].Rows.OfType<DataRow>()
                .FirstOrDefault(r => r.Field<string>("Name") == "Director")?.Field<Guid>("Oid");
            if(directorLineId == null)
                return;
            var directors =
                from movieArtistRow in dataSet.Tables["MovieArtist"].AsEnumerable()
                where movieArtistRow.Field<Guid>("Line") == directorLineId
                from personRow in dataSet.Tables["Person"].AsEnumerable()
                where personRow.Field<Guid>("Oid") == movieArtistRow.Field<Guid>("Artist")
                select new {
                    MovieId = movieArtistRow.Field<Guid>("Movie"),
                    Name = string.Join(" ", personRow.Field<string>("FirstName"), personRow.Field<string>("LastName"))
                };

            Movies = dataSet.Tables["Movie"].AsEnumerable()
                .Select(row => {
                    var movieId = row.Field<Guid>("Oid");
                    return new Movie {
                        Id = movieId,
                        Title = row.Field<string>("Title"),
                        Release = row.Field<DateTime>("ReleaseDate"),
                        Genre = GetGenre(row),
                        Plot = row.Field<string>("Plot"),
                        Photo = GetPhoto(row),
                        Directors = string.Join(", ", directors.Where(d => d.MovieId == movieId).Select(d => d.Name))
                    };
                })
                .ToList();
        }

        static string GetGenre(DataRow row) {
            var genres = (MovieGenre)row.Field<int>("Genre");
            return genres.ToString("G");
        }

        static Image GetPhoto(DataRow row) {
            var photoBytes = row.Field<byte[]>("Photo");
            if(photoBytes != null && photoBytes.Length > 0)
                return ByteImageConverter.FromByteArray(photoBytes);
            return null;
        }
    }
}
