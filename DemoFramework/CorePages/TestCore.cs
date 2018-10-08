using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFramework.CorePages
{
    
    class TestCore
    {
        public static IWebDriver driver;
        public static ExtentReports extent;
        public static ExtentHtmlReporter htmlReporter;
        public static ExtentTest test;

        [SetUp]
        public void setUp()
        {

            String path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            Debug.WriteLine(path);
            string mySavePath = Path.Combine(path, "Results\\" + "Tests" + "_" + DateTime.Now.ToString("(dd_MMMM_hh_mm_ss_tt)") + ".html");
            htmlReporter = new ExtentHtmlReporter(mySavePath);

            htmlReporter.Configuration().Theme = Theme.Dark;

            htmlReporter.Configuration().DocumentTitle = "ResultDocument";

            htmlReporter.Configuration().ReportName = "ResultReport";

            htmlReporter.Configuration().JS = "$('.brand-logo').text('').append('<img src=D:\\Users\\jloyzaga\\Documents\\FrameworkForJoe\\FrameworkForJoe\\Capgemini_logo_high_res-smaller-2.jpg>')";
            extent = new ExtentReports();

            extent.AttachReporter(htmlReporter);

            driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com/";
        }


        [TearDown]
        public void tearDown()
        {
            driver.Close();
            extent.Flush();
        }

    }
}
