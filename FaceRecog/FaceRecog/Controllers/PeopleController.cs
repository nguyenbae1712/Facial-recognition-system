using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;
using FaceRecog.Models;
using System.Text;
using System.Data.Entity.Validation;

namespace FaceRecog.Controllers
{
    public class PeopleController : Controller
    {
        private DiemdanhEntities db = new DiemdanhEntities();

        // GET: People
        public ActionResult Index()
        {
            return View(db.People.ToList());
        }
        public ActionResult ManageStudent(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                //return RedirectToAction("Login", "People");
            }
            Person person = db.People.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ManageStudent([Bind(Include = "ID,Name,Code,Password,Email,DateOfBirth,Phone,Address,IdRole")] Person person)
        {
            if (ModelState.IsValid)
            {
                db.Entry(person).State = EntityState.Modified;
                Response.Cookies["PersonId"].Value = person.ID.ToString();
                db.SaveChanges();
                return RedirectToAction("Index", "People");
            }
            return View(person);
        }
        //GET: People/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                return View("Login");
            }
            Person person = db.People.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // POST: People/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Code,Password,Email,DateOfBirth,Phone,Address,IdRole")] Person person)
        {
            if (ModelState.IsValid)
            {
                db.Entry(person).State = EntityState.Modified;
                db.SaveChanges();
                Response.Cookies["PersonId"].Value = person.ID.ToString();
                return RedirectToAction("Index");
            }
            return View(person);
        }
        public ActionResult Login(string alert = "")
        {
            if (!String.IsNullOrEmpty(alert))
            {
                ViewBag.login = alert;
            }
            return View();
        }

        [HttpPost]
        public ActionResult Login(int Code, string txtPassWord, int? mode = 0)
        {
            txtPassWord = MD5Hash(txtPassWord);
            Person person = db.People.SingleOrDefault(x => x.Code == Code && x.Password == txtPassWord);

            if (person == null)
            {
                ViewBag.login = "Tài khoản không tồn tại.Bạn đã nhập sai tên đăng nhập hoặc mật khẩu !";
                return View();
            }
            if (person.IdRole == 2)
            {
                Response.Cookies["PersonId"].Value = person.ID.ToString();
                Session["Name"] = person.Name;
                Session["PersonId"] = person.ID;
                return RedirectToAction("TeacherIndex", "diemdanhs");
            }
            Response.Cookies["PersonId"].Value = person.ID.ToString();
            Session["Name"] = person.Name;
            Session["PersonId"] = person.ID;

            return RedirectToAction("index", "diemdanhs");

        }
        public string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
        public ActionResult Logout()
        {
            Session["Name"] = null;
            Session["PersonId"] = null;

            return RedirectToAction("index", "home");
        }
        //[HttpPost]
        //public ActionResult Create(string txtRole,int Code, string txtName, string txtAddress, string txtPassword, string txtEmail, string txtBirthday, string txtPhone)
        //{
        //    Person p = new Person();
        //    p.IdRole = 1/*db.roles.FirstOrDefault(x => x.RoleName == txtRole).Id*/;
        //    p.Name = txtName;
        //    p.Code = Code;
        //    p.Password = MD5Hash(txtPassword);
        //    p.Address = txtAddress;
        //    p.Email = txtEmail;
        //    p.Phone = txtPhone;
        //    p.DateOfBirth = DateTime.Parse(txtBirthday);
        //    db.People.Add(p);
        //    db.SaveChanges();

        //    return RedirectToAction("ManageStudent","People");
        //}
        //[HttpPost]
        //public ActionResult Delete(string txtCodeDelete, string txtIdDelete, string btnDelete)
        //{
        //    int id = int.Parse(txtIdDelete);
        //    int code = int.Parse(txtCodeDelete);
        //    if (db.People.Find(code) != null)
        //    {
        //        var e = db.People.Where(x => x.Code == code && x.IdRole == 1).FirstOrDefault();
        //        if (btnDelete == "delete")
        //        {
        //            db.People.Remove(e);
        //        }
        //        db.SaveChanges();
        //        TempData["notiDelete"] = "true";
        //    }
        //    else
        //    {
        //        TempData["notiDelete"] = "false";
        //    }
        //    return RedirectToAction("ManageStudent","People");
        //}
        [HttpPost]
        public ActionResult Update(int Id, int Code, string Name, string txtBirthday, string Address, string Phone, string Email, string btnUpdate, string txtOldPass, string txtNewPass)
        {
            Person c = db.People.Find(Id);
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (btnUpdate == "ChangePassword")
            {

                if (c.Code == Code && c.Password == MD5Hash(txtOldPass))
                {
                    c.Password = MD5Hash(txtNewPass);
                    ViewBag.Message = "Doi mat khau thanh cong!";
                    db.SaveChanges();

                }
                else
                {
                    return RedirectToAction("Edit", "people", new { id = c.ID });
                }
            }
            else
            {
                c.Name = Name;
                c.Code = Code;
                c.Address = Address;
                if (txtBirthday != null)
                {
                    c.DateOfBirth = DateTime.Parse(txtBirthday);
                }
                c.Email = Email;
                c.Phone = Phone;
                db.SaveChanges();
            }
            return RedirectToAction("edit", "people", new { id = c.ID });
        }
        public ActionResult UpdateTeacher(int Id, int Code, string btnUpdate, string txtOldPass, string txtNewPass)
        {
            Person c = db.People.Find(Id);
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (btnUpdate == "ChangePassword")
            {

                if (c.Code == Code && c.Password == MD5Hash(txtOldPass))
                {
                    c.Password = MD5Hash(txtNewPass);
                    ViewBag.Message = "Doi mat khau thanh cong!";
                    db.SaveChanges();

                }
                else
                {
                    return RedirectToAction("ManageStudent", "people", new { id = c.ID });
                }
            }
            return RedirectToAction("ManageStudent", "people", new { id = c.ID });
        }
        public JsonResult LoadStudent(string PersonId)
        {
            var c = db.People.Find(int.Parse(PersonId));
            //if (c.IdRole == 2)
            //{
            //    return Json("", JsonRequestBehavior.DenyGet);
            //}
            return Json(new
            {
                success = true,
                name = c.Name,
                birthday = c.DateOfBirth,
                address = c.Address,
                email = c.Email,
                phone = c.Phone,
                code = c.Code
            }, JsonRequestBehavior.AllowGet);
        }

    }
}
