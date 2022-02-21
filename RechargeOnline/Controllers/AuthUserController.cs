using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RechargeOnline.Models;
using System.Security.Cryptography;
using System.Text;
using System.Web.Security;

namespace RechargeOnline.Controllers
{
    public class AuthUserController : Controller
    {
        
        private DataContext db = new DataContext();
        // GET: AuthUser
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                var check = db.Users.FirstOrDefault(s => s.Email == user.Email);
                if (check == null)
                {
                    user.Password = GetMD5(user.Password);
                    db.Users.Add(user);
                    db.SaveChanges();
                    FormsAuthentication.SetAuthCookie(user.Email, true);
                    return Redirect("~/Home/Index");
                }
                else
                {
                    ViewBag.Error = "Email này đã tồn tại";
                }
            }
            return View();
        }

        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] frData = Encoding.UTF8.GetBytes(str);
            byte[] toData = md5.ComputeHash(frData);
            string hashString = "";
            for (int i = 0; i < toData.Length; i++)
            {
                hashString += toData[i].ToString("x2");
            }
            return hashString;
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login login)
        {
            if (ModelState.IsValid)
            {
                login.Password = GetMD5(login.Password);
                var data = db.Users.Where(s => s.Email.Equals(login.Email) && s.Password.Equals(login.Password)).FirstOrDefault();
                if (data != null)
                {
                    FormsAuthentication.SetAuthCookie(data.Email, true);
                    return Redirect("~/Home/Index");
                }
            }
            return View();
        }


    }
}