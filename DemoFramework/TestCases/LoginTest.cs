using AventStack.ExtentReports;
using DemoFramework.CorePages;
using DemoFramework.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFramework.TestCases
{
    [TestFixture]
    class LoginTest : TestCore
    {
        [NUnit.Framework.Test]
        public void Test()
        {
            test = extent.CreateTest("Test Result");
            var loginPage = new LoginPage(driver);
            var basePage = new BaseClass(driver);

            Assert.AreEqual(loginPage.getTitle(), "Facebook – log in or sign up");
            test.Log(Status.Info, "Verify the Title");
            loginPage.enterEmail();
            test.Log(Status.Info, "Email entered");
            basePage.TestScreenShot();
            loginPage.enterPassword();
            test.Log(Status.Info, "Password entered");
            basePage.TestScreenShot();
            loginPage.clickLogin();
            test.Log(Status.Info, "Login button cliked");
            basePage.TestScreenShot();
            Assert.AreEqual(loginPage.verifyText(), "Sachin QA");
            test.Log(Status.Info, "Verify user name");
            basePage.TestScreenShot();
        }
    }
}
