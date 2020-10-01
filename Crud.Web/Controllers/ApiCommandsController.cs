using Crud.Web.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Web.Http;
//using System.Web.Mvc;

namespace Crud.Web.Controllers
{
    public class ApiCommandsController : ApiController
    {

        private static readonly IList<CommentModel> _comments;

        static ApiCommandsController()
        {
            _comments = new List<CommentModel>
            {
                new CommentModel
                {
                    Id = 1,
                    Author = "C# MVC",
                    Text = "Hello From C# MVC5 WEB API"
                },
                new CommentModel
                {
                    Id = 2,
                    Author = "Daniel Lo Nigro",
                    Text = "Hello ReactJS.NET World!"
                },
                new CommentModel
                {
                    Id = 3,
                    Author = "Pete Hunt",
                    Text = "This is one comment"
                },
                new CommentModel
                {
                    Id = 4,
                    Author = "Jordan Walke",
                    Text = "This is *another* comment"
                },
            };
        }



        //[OutputCache(Location = OutputCacheLocation.None)]
        [HttpGet]
        public HttpResponseMessage GetServerSideData()
        {
            

            return new HttpResponseMessage()
            {
                Content = new StringContent(
                    JsonConvert.SerializeObject(_comments),
                    Encoding.UTF8,
                    "application/json"
                )
            };

        }

        [HttpPost]
        public HttpResponseMessage AddServerSideData([FromBody] CommentModel param)
        {


            param.Id = _comments.Count + 1;
            _comments.Add(param);

            return new HttpResponseMessage()
            {
                Content = new StringContent(
                "Success",
                Encoding.UTF8,
                "text/html"
            )
            };

            //if (ModelState.IsValid)
            //{
            //    param.Id = _comments.Count() + 1;
            //    _comments.Add(param);
            //    return new HttpResponseMessage()
            //    {
            //        Content = new StringContent(
            //        "Success",
            //        Encoding.UTF8,
            //        "text/html"
            //    )
            //    };
            //}
            //else
            //{
            //    return new HttpResponseMessage()
            //    {
            //        Content = new StringContent(
            //        "Fail",
            //        Encoding.UTF8,
            //        "text/html"
            //    )
            //    };
            //}

            //id.Id = _comments.Count() + 1;
            //_comments.Add(id);

            //_comments.Add(new CommentModel() { Id = _comments.Count() + 1, Author = id.Author, Text = id.Text });
            //_comments.Add(new CommentModel() { Id = _comments.Count() + 1, Author = "xx", Text = "yy" });



        }




    }
}
