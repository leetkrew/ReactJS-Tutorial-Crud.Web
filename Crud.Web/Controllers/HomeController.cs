using Crud.Web.Helpers;
using Crud.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace Crud.Web.Controllers
{
    public class HomeController : Controller
    {

        CrudContext _db = new CrudContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult YourFirstComponent()
        {
            DisplayViewModel param = new DisplayViewModel(this.ControllerContext.RouteData.Values["action"].ToString());
            return View(param);
        }

        public ActionResult JSXSyntax()
        {
            DisplayViewModel param = new DisplayViewModel(this.ControllerContext.RouteData.Values["action"].ToString());
            return View(param);
        }

        public ActionResult ComposingComponents()
        {
            DisplayViewModel param = new DisplayViewModel(this.ControllerContext.RouteData.Values["action"].ToString());
            return View(param);
        }

        public ActionResult UsingProps()
        {
            DisplayViewModel param = new DisplayViewModel(this.ControllerContext.RouteData.Values["action"].ToString());
            return View(param);
        }

        public ActionResult AddingMarkdown()
        {
            DisplayViewModel param = new DisplayViewModel(this.ControllerContext.RouteData.Values["action"].ToString());
            return View(param);
        }

        public ActionResult HookUpTheDataModel()
        {
            DisplayViewModel param = new DisplayViewModel(this.ControllerContext.RouteData.Values["action"].ToString());
            return View(param);
        }

        public ActionResult ServerSideData()
        {
            DisplayViewModel param = new DisplayViewModel(this.ControllerContext.RouteData.Values["action"].ToString());
            return View(param);
        }

        public ActionResult FetchingFromTheServer()
        {
            DisplayViewModel param = new DisplayViewModel(this.ControllerContext.RouteData.Values["action"].ToString());
            return View(param);
        }

        public ActionResult ReactiveState()
        {
            DisplayViewModel param = new DisplayViewModel(this.ControllerContext.RouteData.Values["action"].ToString());
            return View(param);
        }

        public ActionResult UpdatingState()
        {
            DisplayViewModel param = new DisplayViewModel(this.ControllerContext.RouteData.Values["action"].ToString());
            return View(param);
        }

        public ActionResult UpdatingState2()
        {
            DisplayViewModel param = new DisplayViewModel(this.ControllerContext.RouteData.Values["action"].ToString());
            return View(param);
        }

        public ActionResult AddingNewComments()
        {
            DisplayViewModel param = new DisplayViewModel(this.ControllerContext.RouteData.Values["action"].ToString());
            return View(param);
        }

        public ActionResult TheForm()
        {
            DisplayViewModel param = new DisplayViewModel(this.ControllerContext.RouteData.Values["action"].ToString());
            return View(param);
        }

        public ActionResult ControlledComponents()
        {
            DisplayViewModel param = new DisplayViewModel(this.ControllerContext.RouteData.Values["action"].ToString());
            return View(param);
        }

        public ActionResult Events()
        {
            DisplayViewModel param = new DisplayViewModel(this.ControllerContext.RouteData.Values["action"].ToString());
            return View(param);
        }

        public ActionResult SubmittingTheForm()
        {
            DisplayViewModel param = new DisplayViewModel(this.ControllerContext.RouteData.Values["action"].ToString());
            return View(param);
        }


        public ActionResult CallbacksAsProps()
        {
            DisplayViewModel param = new DisplayViewModel(this.ControllerContext.RouteData.Values["action"].ToString());
            return View(param);
        }

        public ActionResult CallbacksAsProps2()
        {
            DisplayViewModel param = new DisplayViewModel(this.ControllerContext.RouteData.Values["action"].ToString());
            return View(param);
        }

        public ActionResult CallbacksAsProps3()
        {
            DisplayViewModel param = new DisplayViewModel(this.ControllerContext.RouteData.Values["action"].ToString());
            return View(param);
        }
    }
}