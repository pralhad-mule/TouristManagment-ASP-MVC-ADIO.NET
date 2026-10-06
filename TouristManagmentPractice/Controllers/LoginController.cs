using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TouristManagmentPractice.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Userlogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Userlogin(string email,string password)
        {
            string path = "Data Source=pralhad\\SQLEXPRESS;Integrated Security=True;Initial Catalog=TravelGoDB";
            SqlConnection sc = new SqlConnection(path);
            sc.Open();
            string querry= "select * from UserRegistration where email='"+email+"' and password='"+password+"'";
            SqlCommand cmd = new SqlCommand(querry, sc);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Message = "Invalid Email or Password";
            }

            sc.Close();
            ViewData["x"] = "Registration successfully..🫡🫡🫡";

            return View();

            
        }
    }
}