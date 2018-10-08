using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFramework.CorePages
{
    class BaseClass
    {
        protected IWebDriver driver;
        public BaseClass(IWebDriver driver)
            {
            this.driver = driver;
            }
        public void sendKeys(By _by, string _key)
        {
            driver.FindElement(_by).SendKeys(_key);
        }

        public void click(By _by)
        {
            driver.FindElement(_by).Click();
        }

        public string getText(By _by)
        {
            return driver.FindElement(_by).Text;
        }

        public void TestScreenShot()
        {
            String path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string mySavePath = Path.Combine(path, "Results\\" + "Screenshot" + "_" + DateTime.Now.ToString("(dd_MMMM_hh_mm_ss_tt)") + ".png");
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(mySavePath);
        }
    }
}
