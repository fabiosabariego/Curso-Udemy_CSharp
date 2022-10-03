using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePost
{
    internal class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost()
        {

        }

        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            // Todos parametros abaixo sao da Classe Post
            this.ID = GetNextID();      // Pega direto da Classe Mae, tando o ID quandto GetNextID()
            this.Title = title;
            this.SendByUserName = sendByUsername;
            this.IsPublic = isPublic;
            // O Parametro abaixo esta somente na classe ImagePost, nao herda da Classe Post
            this.ImageURL = imageURL;
        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.ImageURL} by {this.SendByUserName}");
        }
    }
}
