using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoList04.Models;

namespace ToDoList04.Controllers
{
    public class ItemController : Controller
    {
        ToDoContext db = new ToDoContext();
        // GET: Item
        public ActionResult Index()
        {
            return View(db.Items.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Item item)
        {
            db.Items.Add(item);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}