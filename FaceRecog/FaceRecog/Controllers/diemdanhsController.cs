using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FaceRecog.Models;

namespace FaceRecog.Controllers
{
    public class diemdanhsController : Controller
    {
        private DiemdanhEntities db = new DiemdanhEntities();
        //GET: TecherIndex
        //[Authorize(Roles = "Teacher")]
        public ActionResult TeacherIndex()
        {
            return View();
        }
        //GET: diemdanh 
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult LoadDiemdanh(string IdDiemdanh, string txtName, string txtMonhoc, int Code)
        {
            var c = db.diemdanhs.Find(int.Parse(IdDiemdanh));
            return Json(new { success = true, name = c.ID = db.People.FirstOrDefault(x => x.Name == txtName).ID,
                mon = db.monhocs.FirstOrDefault(x =>x.nameMonHoc == txtMonhoc).IdMonHoc, ngay = c.Date, 
                gio = c.time, code = c.ID = db.People.FirstOrDefault(x => x.Code == Code).ID}, JsonRequestBehavior.AllowGet);
        }
    }
}
