using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TouristManagmentPractice.Models;

namespace TouristManagmentPractice.Controllers
{
    public class UserRegisterController : Controller
    {
        // GET: UserRegister
        public ActionResult user()
        {
            return View();
        }
        [HttpPost]
        public ActionResult user(Users u1)
        {
            // validation
            if(string.IsNullOrWhiteSpace(u1.Name)||
                string.IsNullOrWhiteSpace(u1.Email)||
                string.IsNullOrWhiteSpace(u1.Password)||
                string.IsNullOrWhiteSpace(u1.ConfirmPassword)||
                string.IsNullOrWhiteSpace(u1.Phone)||
                string.IsNullOrWhiteSpace(u1.Address)
                )
            {
                ViewData["x"] = "Plz fill the all details😉😉";
            }

            if (u1.Password != u1.ConfirmPassword)
              
                 {
                    ViewData["x"] = "Password and Confirm Password do not match";    
                    return View(u1); 
            }
            string path = "Data Source=pralhad\\SQLEXPRESS;Integrated Security=True;Initial Catalog=TravelGoDB";

            SqlConnection sc = new SqlConnection(path);
            sc.Open();
            SqlCommand cmd = new SqlCommand("insert into UserRegistration values('"+u1.Name+"','"+u1.Email+"','"+u1.Password+"'" +
                ",'"+u1.ConfirmPassword+"','"+u1.Phone+"','"+u1.Address+"')", sc);

            cmd.ExecuteNonQuery();

            ViewData["x"] = "Registration Successfuly";

            return RedirectToAction("Index");
        }
    }
}