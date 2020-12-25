using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FaceRecognition.Models;

namespace FaceRecognition.Controllers
{
    public class UsersController : Controller
    {
        private DataEntities db = new DataEntities();

        // GET: Users
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        // GET: Users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserName,Password,Id,MasoSV")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user);
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserName,Password,Id,MasoSV")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
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
        public ActionResult Login(string txtUserName, string txtPassWord, int? mode = 0)
        {
            User user = db.Users.SingleOrDefault(x => x.UserName == txtUserName && x.Password == txtPassWord);

            if (user == null)
            {
                ViewBag.login = "Tài khoản không tồn tại.Bạn đã nhập sai tên đăng nhập hoặc mật khẩu !";
                return View();
            }

            Response.Cookies["UserId"].Value = user.Id.ToString();
            Session["Name"] = user.UserName;
            Session["UserId"] = user.Id;

            return RedirectToAction("index", "home");

        }

        public ActionResult Logout()
        {
            Session["Name"] = null;
            Session["UserId"] = null;

            return RedirectToAction("index", "home");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(string txtUserName, string txtPassWord)
        {
            var kt = db.Users.Where(x => x.UserName.ToLower() == txtUserName.ToLower());
            if (kt.Count() != 0)
            {
                ViewBag.register = "Tài khoản này đã có người sử dụng. Hãy thử đặt tài khoản khác";
                return View(); // trùng ten tai khoan, dat ten khac
            }
            User user = new User();
            user.UserName = txtUserName;
            user.Password = txtPassWord;
            

            try
            {
                db.Users.Add(user);
                db.SaveChanges();
                ViewBag.register = "Đăng ký thành công";
                return View();
            }
            catch (Exception e)
            {
                ViewBag.register = "Đăng ký thất bại . Hãy điển đây đủ thông tin";
                return View();
            }

        }
    }
}
