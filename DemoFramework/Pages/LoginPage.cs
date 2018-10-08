using DemoFramework.CorePages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFramework.PageObjects
{
    class LoginPage : BaseClass
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public string getTitle()
        {
            return driver.Title;
        }

        public void enterEmail()
        {
            sendKeys(By.Id(LoginPageObjects.email_id), LoginPageObjects.email);
        }

        public void enterPassword()
        {
            sendKeys(By.Id(LoginPageObjects.pass_id), LoginPageObjects.password);
        }

        public void clickLogin()
        {
            click(By.XPath(LoginPageObjects.login_xpath));
        }

        public string verifyText()
        {
            return getText(By.CssSelector(LoginPageObjects.username_css));
        }
    }
}
