using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using DevExpress.Data.Utils;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using DevExpress.DXperience.Demos;

namespace DevExpress.HTML.Demos.Helpers.Data {
    public class Comment : INotifyPropertyChanged {
        BindingList<Comment> replies;

        public string Author { get; private set; }
        public string AuthorInitials { get; private set; }
        public Image Photo { get; private set; }
        public string Text { get; private set; }
        public DateTime Date { get; private set; }
        public bool Edited { get; private set; }
        public int Likes { get; private set; }
        public bool LikedByMe { get; private set; }
        public bool HasPhoto => Photo != null;
        public int RepliesCount => Replies?.Count ?? 0;

        public BindingList<Comment> Replies {
            get { return replies; }
            private set {
                replies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Replies)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Comment(string author, Image photo, string text, DateTime date, int likes = 0, bool likedByMe = false) {
            Author = author;
            Photo = photo;
            Text = text;
            Date = date;
            Likes = likes;
            LikedByMe = likedByMe;

            CreateInitials();
        }

        public void CreateInitials() {
            AuthorInitials = GetInitials(Author);
        }

        public void UpdateText(string text) {
            Text = text;
            Edited = true;
        }

        public void ToggleLike() {
            if(LikedByMe)
                --Likes;
            else
                ++Likes;
            LikedByMe = !LikedByMe;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Likes)));
        }

        public void AddReply(Comment comment) {
            if(Replies == null)
                Replies = new BindingList<Comment>();
            Replies.Add(comment);
        }

        static char[] initialsSplitter = { ' ' };
        static string GetInitials(string author) {
            return string.Join("",
                author.Split(initialsSplitter, 2, StringSplitOptions.RemoveEmptyEntries).Select(n => n.FirstOrDefault())
            );
        }
    }

    public static class TreeListData {
        public static class CurrentUser {
            public static string Name => DataHelper.Employees[0].FullName;
            public static Image Photo => DataHelper.Employees[0].Photo;

            public static Comment CreateComment(string text) {
                return new Comment(Name, Photo, text, TutorialConstants.Now);
            }
        }

        const int RootCommentsCount = 30;
        const int PeopleCount = 20;
        const int MaxRepliesLevel = 3;

        static NonCryptographicRandom random = NonCryptographicRandom.Default;

        public static BindingList<Comment> GenerateCommentsData() {
            BindingList<Comment> data = new BindingList<Comment> {
                new Comment(CurrentUser.Name, CurrentUser.Photo, LoremIpsum.GenerateString(100), TutorialConstants.Now.AddDays(-7))
            };
            for(int i = 1; i < RootCommentsCount; i++) {
                var comment = CreateComment();
                data.Add(comment);

                GenerateReplies(comment);
            }
            return data;
        }

        public static void MakeCommentNodeVisible(Comment comment, TreeListNodes nodesCollection) {
            var treeList = nodesCollection.TreeList;
            foreach(TreeListNode node in nodesCollection) {
                if(treeList.GetRow(node.Id) == comment) {
                    treeList.FocusedNode = node;
                    return;
                }
            }
        }

        static Comment CreateComment() {
            var person = DataHelper.Employees[random.Next(PeopleCount)];
            var minTextLength = random.Next(200) + 70;
            var text = LoremIpsum.GenerateString(minTextLength);
            var date = TutorialConstants.Now.AddDays(-(random.Next(5) + 1)).AddHours(random.Next(10) - 5).AddMinutes(random.Next(60) - 30);
            var likes = Chance(25) ? random.Next(5) : 0;
            var likedByMe = likes > 0 ? Chance(30) : false;

            return new Comment(person.FullName, person.Photo, text, date, likes, likedByMe);
        }

        static void GenerateReplies(Comment comment, int level = 0) {
            if(level <= MaxRepliesLevel && Chance(50)) {
                int repliesCount = random.Next(6);
                for(int i = 0; i < repliesCount; i++) {
                    var reply = CreateComment();
                    comment.AddReply(reply);
                    GenerateReplies(reply, ++level);
                }
            }
        }

        static bool Chance(int percents) {
            percents = Math.Max(0, Math.Min(100, percents));
            return random.Next(100) < percents;
        }
    }
}
