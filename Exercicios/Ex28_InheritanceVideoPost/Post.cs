using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex28_InheritanceVideoPost
{
    internal class Post
    {
        private static int PostID;
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string UserName { get; set; }
        protected bool IsPublic { get; set; }

        // Criando o Construtor caso nao seja informado nenhum parametro na sua chamada
        public Post()
        {
            ID = 0;
            Title = "Primeiro Post";
            UserName = "Desconhecido";
            IsPublic = true;
        }

        public Post(string title, string username, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.UserName = username;
            this.IsPublic = isPublic;
        }

        public int GetNextID()
        {
            return ++PostID;
        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} by  {this.UserName}");
        }
    }
}
