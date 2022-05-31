using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TryOnlineShop.Areas.admin.Model;

namespace TryOnlineShop.Areas.admin.Controllers
{
    public class CategoryController : Controller
    {
        // GET: admin/Category
        public ActionResult Index()
        {
            var iplCate = new CategoryModel();
            var model = iplCate.ListAll();
            return View(model);
        }

        // GET: admin/Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: admin/Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: admin/Category/Create
        [HttpPost]
        public ActionResult Create(Category collection)
        {
            //try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    var model = new CategoryModel();
                    int res = model.Create(collection.Name, collection.Alias, collection.ParentID, collection.Order, collection.Status);
                    if(res>0)
                        return RedirectToAction("Index");
                    else
                    {
                        ModelState.AddModelError("", "Thêm mới không thành công!");
                    }
                }
                return View(collection);
            }
            //catch
            //{
            //    return View();
            //}
        }

        // GET: admin/Category/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: admin/Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: admin/Category/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: admin/Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
