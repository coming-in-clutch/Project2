using Project2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Project2.Models;
using System.ComponentModel;

namespace Project2.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        private MissionProjectContext db = new MissionProjectContext();

        public Users myUser = new Users();

        //public ActionResult GetUsers()
        //{
        //    if (User.Identity.IsAuthenticated)
        //    {
        //        String myEmail = User.Identity.Name;
        //        myUser = db.Users.SqlQuery("Select" +
        //            "FROM" +
        //            "WHERE Users.UserEmail = '" + myEmail + "'");
        //    }
        //}

        public ActionResult Index(int? userNow)
        {
            return View(userNow);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Coming in Clutch Co.";

            return View();
        }

        public ActionResult Missions()
        {
            ViewBag.Mission = db.Mission.ToList();

            return View();

        }

        public ActionResult MissionQuestions()
        {
            return View();
        }

        [Authorize]
        public ActionResult MissionFAQs(int missionID)
        {


            //switch (sMission)
            //{
            //    case "Pennsylvania Pittsburgh":
            //        ViewBag.Title = sMission;
            //        ViewBag.Image = sImage;
            //        ViewBag.Pres = "Steven C. Bednar"; //mission president
            //        ViewBag.Address1 = "Pennsylvania Pittsburgh Mission";
            //        ViewBag.Address2 = "2600 Boyce Plaza Suite 101";
            //        ViewBag.Address3 = "Upper St. Clair, PA 15241";
            //        ViewBag.Lang = "English"; //language
            //        ViewBag.Climate = "Humid Continental"; //mission climate
            //        ViewBag.Rel = "Catholic, Protestant"; //dominant religion
            //        break;
            //    case "Taiwan Taichung":
            //        ViewBag.Title = sMission;
            //        ViewBag.Image = sImage;
            //        ViewBag.Pres = "Michael John U. Teh"; //mission president
            //        ViewBag.Address1 = "Taiwan Taichung Mission";
            //        ViewBag.Address2 = "498 - 11, Wu Chuan Road";
            //        ViewBag.Address3 = "North District, Taichung City Taiwan 404";
            //        ViewBag.Lang = "Mandarin Chinese"; //language
            //        ViewBag.Climate = "Sub-tropical, Tropical"; //mission climate
            //        ViewBag.Rel = "Buddhism, Daoism"; //dominant religion
            //        break;
            //    case "Tennessee Knoxville":
            //        ViewBag.Title = sMission;
            //        ViewBag.Image = sImage;
            //        ViewBag.Pres = "David J. Pickett"; //mission president
            //        ViewBag.Address1 = "Tennessee Knoxville Mission";
            //        ViewBag.Address2 = "11320 Station West Drive Suite 101";
            //        ViewBag.Address3 = "Farragut, TN 37934";
            //        ViewBag.Lang = "English"; //language
            //        ViewBag.Climate = "Humid continental, Humid sub-tropical"; //mission climate
            //        ViewBag.Rel = "Baptist"; //dominant religion
            //        break;
            //}

            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            String email = form["Email address"].ToString();
            String password = form["Password"].ToString();

            if (string.Equals(email, "mission@test.com") && (string.Equals(password, "greg")))
            {
                FormsAuthentication.SetAuthCookie(email, rememberMe);

                return RedirectToAction("Index", "Home");

            }
            else
            {
                return View();
            }
        }

        public ActionResult NewAccount()
        {
            return View();
        }

        [Authorize]
        public ActionResult SelectedMission(int? missionID)
        {

            Missions mission = db.Mission.Find(missionID);

            ViewBag.Mission = mission;

            IEnumerable<MissionQuestions> missions = db.Database.SqlQuery<MissionQuestions>("SELECT missionQuestionID, missionID, userID, question, answer " +
            "FROM MissionQuestions " +

            "WHERE missionID = '" + missionID + "'");
            return View(missions);
        }
    }
}
