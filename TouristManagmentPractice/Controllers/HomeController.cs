using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using TouristManagmentPractice.Models;

namespace TouristManagmentPractice.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult contack()
        {
            return View();
        }
        [HttpPost]

        public ActionResult contack( contackmessage m)
        {
            
            string path = "Data Source=pralhad\\SQLEXPRESS;Integrated Security=True;Initial Catalog=TravelGoDB";

            SqlConnection con = new SqlConnection(path);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into  contackmessage values('" + m.fullname + "','" + m.emailaddress + "','" + m.mobilenumber + "','" + m.subject + "','" + m.yourmessage + "')", con);
            cmd.ExecuteNonQuery();

            ViewData["x"] = "Your  message is Successfully send😉😉";


            return View();
        }
    }
}