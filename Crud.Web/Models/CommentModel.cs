using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crud.Web.Models
{
    public class CommentModel
    {
        public CommentModel() {
            this.Id = 0;
        }

        public int? Id { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
    }
}