﻿using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace SIPTests
{
    [TestClass]
    public class TC04_NewUserSuccessfullyAdded : TestBase
    {
        [TestMethod]
        public void RunTest_TC04()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "admin");
            Assert.IsTrue(Pages.MapDashboard.IsAt(), "The user can't access map dahsboard page.");

            Pages.MapDashboard.UserManagement();
            Assert.IsTrue(Pages.UserManagement.IsAt(), "The user can't access user management page.");

            Pages.UserManagement.AddNewUser();
            Assert.IsTrue(Pages.AddNewUser.IsAt(), "The user can't access add user page");

            Pages.AddNewUser.AddUser(
                "AutomationTest",
                "Test Engineer",
                "kamarulhilmi@recogine.com",
                "Damansara",
                "AutomationTesting", //username
                "Operation", //usergroupName
                "auto", //password
                "Female", 
                "0135906715",
                "1991/01/05",
                "auto"
                );

            Pages.UserManagement.AddNewUserConfirm();
        }
    }
}
