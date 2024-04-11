using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeSocial.Entities {
    internal class Post {

        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        public List<string> Text = new List<string>();

        public Post(DateTime moment, string title, string content, int likes) {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(string text) {
            Text.Add(text);
        }

        public void RemoveComment(string text) {
            Text.Remove(text);
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine();
            sb.AppendLine("Comments:");            
            foreach (var comment in Text) {
                sb.AppendLine(comment);
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
