/*
 * Yiwen Zhao 
 *  5/6/2019
 *  UserLoginController.cs
 *  
 */
using DAL.JooleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JooleProj.Controllers
{
    public class UserLoginController : Controller
    {
        // create the jooleEntities instance so that getting the table classes
        private jooleEntities1 jooleEntitiesInstance = new jooleEntities1();
        // UserLogin
        public ActionResult LoginPage(string userIDInfo, string passwordInfo)
        {
            // create tblUser instance so that getting the elements
            tblUser userLoginInfo = new tblUser();
            userLoginInfo.User_Name = userIDInfo;
            userLoginInfo.User_Email = userIDInfo;
            userLoginInfo.User_Password = passwordInfo;
            // get the element that satisfies the condition
            tblUser userLoginInfoAll = jooleEntitiesInstance.tblUser.SingleOrDefault(n => (n.User_Name == userLoginInfo.User_Name) || (n.User_Email == userLoginInfo.User_Email));

            // if null keep the login page
            if (userLoginInfoAll == null)
            {
                //return RedirectToAction("LoginPageTest", "UserLogin");
                //return Content("Please Login !");
                return View();
            }
            // if nuot null step into 
            else
            {
                if (userLoginInfo.User_Password == userLoginInfoAll.User_Password)
                {
                    //return RedirectToAction("DisplayLogin", "Home");
                    //return Content("Sccuess !");
                    return Content("Success !");
                }
                // password is wrong
                else
                {
                    //return RedirectToAction("Index", "Home");
                    return Content("Password is not correct !");
                }
            }
        }
    }
}
