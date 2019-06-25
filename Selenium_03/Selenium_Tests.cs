using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;

namespace Selenium_03
{
   
    class Selenium_Tests
    {
        IWebDriver driver;
        IWebElement element;

        [SetUp]
        public void Initialise()
        {
            driver = new ChromeDriver();
            
        }



        [Test]
        public void Selenium_Test_BBC_Website()
        {

            driver.Url = "https://www.bbc.co.uk";
            //  Console.WriteLine($"Page Source is {driver.PageSource}");
            Console.WriteLine($"Page Source is {driver.PageSource.Length}");

            Console.WriteLine($"Driver is {driver.Url}");
            Console.WriteLine($"Page Title is {driver.Title}");
            driver.Navigate().GoToUrl("https://www.intel.com");
            Thread.Sleep(1500);
            driver.Navigate().Back();
            Thread.Sleep(1500);
            driver.Navigate().Forward();
            Thread.Sleep(1500);
            driver.Navigate().Back();
            Thread.Sleep(1500);
            driver.Navigate().Refresh();
            Thread.Sleep(1500);

            driver.Url = "http://34.244.111.198/";
            // IWebElement element = driver.FindElement(By.Id(""));
            element = driver.FindElement(By.Name("email"));
            element.Clear();
            element.SendKeys("admin@spartaglobal.com");
            Thread.Sleep(1500);


            element = driver.FindElement(By.Name("password"));
            element.Clear();
            element.SendKeys("Password1");
            Thread.Sleep(1500);

            element = driver.FindElement(By.ClassName("btn-primary"));
            element.Click();
            Thread.Sleep(1500);
        }

        [TearDown]
        public void EndTest()
        {
            System.Threading.Thread.Sleep(3000);
            driver.Close();
            driver.Quit(); // closes all windows regardless
        }
    }
}



namespace JibbySiteTests
{
    // Run inside Selenium_03 in 2019-04-Labs
    using System;
    using System.Collections.Generic;
    using System.Text;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using NUnit.Framework;
    using System.Threading;
    using System.IO;
    using System.Diagnostics;

    public enum siteStatus
    {
        DoesNotLoad,
        Empty,
        BlankAvadaTheme,
        PartiallyBuilt,
        BuiltButNeedsWork,
        FullyFunctional,
        NeedsWork
    }
    /// <summary>
    /// Contains test output status
    /// </summary>
    public class TestStatus
    {
        public string SiteName { get; set; }
        public bool TestPassingStatus { get; set; }
        public siteStatus SiteStatus { get; set; }
        public string SiteUrl { get; set; }

        public string LoginUrl { get; set; }
        public string EmailId { get; set; }
        public string EmailAddress { get; set; }
        public string PasswordId { get; set; }
        public string PasswordString { get; set; }
        public string ButtonId { get; set; }
        public string AfterLoginUrl { get; set; }
        public string FindText { get; set; }



    }

    class Selenium_Revival_Sites_Tests
    {
        IWebDriver driver;
        IWebElement element;
        static StringBuilder output;
        List<String> outputLines;
        List<TestStatus> TestResults = new List<TestStatus>();

        [SetUp]
        public void Initialise()
        {
            driver = new ChromeDriver();
            output = new StringBuilder();
            outputLines = new List<string>();
            outputLines.Add("");
            outputLines.Add("");
            outputLines.Add("Testing Of All Of Jibby Sites");
            outputLines.Add($"Date Of Test {DateTime.Now}");
            outputLines.Add($"RevivalDirectCoaches is top priority");
            outputLines.Add($"Coaches4Lawyers is complete");
        }

        [Test]
        public void Selenium_Test_Revival_Sites()
        {

            string description = "";
            string mainPageStatus = "";


            driver.Url = "https://revivaldirectcoaches.co.uk";
            mainPageStatus = siteStatus.Empty.ToString();
            description = "Provide Coach Hire For Churches";
        //    LogStatus(driver.Url, mainPageStatus, description);
            Thread.Sleep(1500);





            driver.Url = "https://coaches4lawyers.co.uk";
            mainPageStatus = siteStatus.FullyFunctional.ToString();
            description = "Provide Coach Hire For Lawyers";
          //  LogStatus(driver.Url, mainPageStatus, description);
            Thread.Sleep(1500);



            Console.WriteLine("\n\nBlank Sites Not Yet Started");

            driver.Url = "https://coaches4staff.co.uk\n";
            mainPageStatus = siteStatus.BlankAvadaTheme.ToString();
            description = "Provide Coach Hire For Companies";

            Console.WriteLine("\n\nLeave For Now\n");

            driver.Url = "https://revivaldirect.co.uk";
            mainPageStatus = siteStatus.BlankAvadaTheme.ToString();
            description = "Personal Evangelism Site";
        //    LogStatus(driver.Url, mainPageStatus, description);
            Thread.Sleep(1500);



            driver.Url = "https://revivaldirectweddings.co.uk";
            mainPageStatus = siteStatus.BlankAvadaTheme.ToString();
            description = "Help People Plan Their Weddings";
         //   LogStatus(driver.Url, mainPageStatus, description);
            Thread.Sleep(500);

            WriteToFile();

        }



        // passing
    
        [TestCase("YourLegalHelp.co.uk", "https://yourlegalhelp.co.uk/", "wp-login.php",
            siteStatus.FullyFunctional, "user_login", "jibbylt@gmail.com", "user_pass", 
            "18*WellinGtondrive$%", "wp-submit", "wp-admin", "Jibby Jackson")]

        // failing

        [TestCase("RevivalDirectCoaches.co.uk", "https://revivaldirectcoaches.co.uk", "wp-login.php",
            siteStatus.Empty, "user_login", "jibbylt@hotmail.com", "user_pass",
            "18*WellinGtondrive$%", "wp-submit", "wp-admin", "Jibby Jackson")]

        [TestCase("RevivalDirectCoaches.co.uk", "https://revivaldirectcoaches.co.uk", "wp-login.php",
            siteStatus.Empty, "user_login", "jibbylt@hotmail.com", "user_pass",
            "7*WellinGtondrive$%", "wp-submit", "wp-admin", "Jibby Jackson")]

        [TestCase("RevivalDirectCoaches.co.uk", "https://revivaldirectcoaches.co.uk", "wp-login.php",
            siteStatus.Empty, "user_login", "jibbylt@hotmail.com", "user_pass",
            "Harmony4*", "wp-submit", "wp-admin", "Jibby Jackson")]

        [TestCase("RevivalDirectCoaches.co.uk", "https://revivaldirectcoaches.co.uk", "wp-login.php",
            siteStatus.Empty, "user_login", "jibbylt@gmail.com", "user_pass",
            "18*WellinGtondrive$%", "wp-submit", "wp-admin", "Jibby Jackson")]

        [TestCase("RevivalDirectCoaches.co.uk", "https://revivaldirectcoaches.co.uk", "wp-login.php",
            siteStatus.Empty, "user_login", "jibbylt@gmail.com", "user_pass",
            "7*WellinGtondrive$%", "wp-submit", "wp-admin", "Jibby Jackson")]

        [TestCase("RevivalDirectCoaches.co.uk", "https://revivaldirectcoaches.co.uk", "wp-login.php",
            siteStatus.Empty, "user_login", "jibbylt@gmail.com", "user_pass",
            "Harmony4*", "wp-submit", "wp-admin", "Jibby Jackson")]


        
        [TestCase("Coaches4Lawyers.co.uk", "https://revivaldirectcoaches.co.uk", "wp-login.php",
            siteStatus.Empty, "user_login", "jibbylt@gmail.com", "user_pass",
            "Harmony4*", "wp-submit", "wp-admin", "Jibby Jackson")]






        public void Jibby_Site_Login_Check(string SiteName, 
            string SiteUrl, string LoginUrl, siteStatus SiteStatus, string EmailId, string EmailAddress, 
            string PasswordId, string PasswordString, string ButtonId, string AfterLoginUrl,
            string FindText)
        {
            TestStatus testStatus = new TestStatus()
            {
                SiteName = SiteName,
                SiteUrl = SiteUrl,
                LoginUrl = LoginUrl,
                SiteStatus = SiteStatus,
                EmailId = EmailId,
                TestPassingStatus = false,
                EmailAddress = EmailAddress,
                PasswordId = PasswordId,
                PasswordString = PasswordString,
                ButtonId = ButtonId,
                AfterLoginUrl = AfterLoginUrl,
                FindText = FindText
            };

            output = new StringBuilder();

            // PASS
            driver.Url = SiteUrl + LoginUrl;
            element = driver.FindElement(By.Id(EmailId));
            element.Clear();
            element.SendKeys(EmailAddress);
            element = driver.FindElement(By.Id(PasswordId));
            element.Clear();
            element.SendKeys(PasswordString);
            element = driver.FindElement(By.Id(ButtonId));
            element.Click();
            driver.Url = SiteUrl + AfterLoginUrl;
            testStatus.TestPassingStatus = driver.PageSource.Contains(FindText);
            LogStatus(testStatus);
            Assert.AreEqual(true, testStatus.TestPassingStatus);
        }






        [Test]
        public void Jibby_Site_03_Theme_Forest_Login_Check()
        {

            //    // PASS - Theme forest

            //driver.Url = "https://themeforest.net/item/avada-responsive-multipurpose-theme/2833226";
            //    element = driver.FindElement(By.Id("spec-user-username"));
            //    element.Click();
            //    element = driver.FindElement(By.Name(" sso_sign_in_form[username]"));
            //    element.Clear();
            //    element.SendKeys("jibbylt");

            //    element = driver.FindElement(By.Id("sso_sign_in_form_username"));
            //    element.Clear();
            //    element.SendKeys("jibbylt");
            //    element = driver.FindElement(By.Id("sso_sign_in_form_password"));
            //    element.Clear();
            //    element.SendKeys("Harmony4*");
            //    element = driver.FindElement(By.ClassName("js-sign-in__submit"));
            //    element.Click();
            //    Thread.Sleep(1500);
            //    output.Append("ThemeForest Passing passing\n\n");


        }



        [Test]
        public void Jibby_Site_04_Revival_Direct_Weddings_co_uk_Login_Check()
        {



            // FAIL
            driver.Url = "https://revivaldirectweddings.co.uk/wp-login.php";
            Thread.Sleep(1500);
            element = driver.FindElement(By.Id("user_login"));
            element.Clear();
            element.SendKeys("jibbylt@gmail.com");
            element = driver.FindElement(By.Id("user_pass"));
            element.Clear();
            element.SendKeys("7*WellinGtondrive$%");
            element = driver.FindElement(By.Id("wp-submit"));
            element.Click();
            Thread.Sleep(1500);
            output.Append("RevivalDirectWeddings failing 5 June\n\n");


            // fail
            driver.Url = "https://revivaldirectweddings.co.uk/wp-admin.php";
            Thread.Sleep(1500);
            element = driver.FindElement(By.Id("user_login"));
            element.Clear();
            element.SendKeys("jibbylt@gmail.com");
            element = driver.FindElement(By.Id("user_pass"));
            element.Clear();
            element.SendKeys("7*WellinGtondrive$%");
            element = driver.FindElement(By.Id("wp-submit"));
            element.Click();
            Thread.Sleep(1500);
            output.Append("RevivalDirectWeddings failing 5 June\n\n");



        }



        [Test]
        public void Jibby_Site_05_Revival_Direct_co_uk_Login_Check()
        {


            //FAIL

            driver.Url = "https://revivaldirect.co.uk/wp-login.php";
            Thread.Sleep(1500);
            element = driver.FindElement(By.Id("user_login"));
            element.Clear();
            element.SendKeys("jibbylt@hotmail.com");
            element = driver.FindElement(By.Id("user_pass"));
            element.Clear();
            element.SendKeys("7*WellinGtondrive$%");
            element = driver.FindElement(By.Id("wp-submit"));
            element.Click();
            Thread.Sleep(1500);
            output.Append("RevivalDirect failing 5 June\n\n");




            //FAIL

            driver.Url = "https://revivaldirect.co.uk/wp-login.php";
            Thread.Sleep(1500);
            element = driver.FindElement(By.Id("user_login"));
            element.Clear();
            element.SendKeys("jibbylt@gmail.com");
            element = driver.FindElement(By.Id("user_pass"));
            element.Clear();
            element.SendKeys("7*WellinGtondrive$%");
            element = driver.FindElement(By.Id("wp-submit"));
            element.Click();
            Thread.Sleep(1500);
            output.Append("RevivalDirect failing 5 June\n\n");






        }



        [Test]
        public void Jibby_Site_06_Coaches4Lawyers_co_uk_Login_Check()
        {



            // FAIL
            driver.Url = "https://coaches4lawyers.co.uk/wp-login.php";
            Thread.Sleep(1500);
            element = driver.FindElement(By.Id("user_login"));
            element.Clear();
            element.SendKeys("cjibbwsr");
            element = driver.FindElement(By.Id("user_pass"));
            element.Clear();
            element.SendKeys("7*WellinGtondrive$%");
            element = driver.FindElement(By.Id("wp-submit"));
            element.Click();
            Thread.Sleep(1500);
            output.Append("Coaches4Lawyers failing 5 June\n\n");


            // FAIL
            driver.Url = "https://coaches4lawyers.co.uk/wp-login.php";
            Thread.Sleep(1500);
            element = driver.FindElement(By.Id("user_login"));
            element.Clear();
            element.SendKeys("cjibbwsr");
            element = driver.FindElement(By.Id("user_pass"));
            element.Clear();
            element.SendKeys("sophiejoy2*");
            element = driver.FindElement(By.Id("wp-submit"));
            element.Click();
            Thread.Sleep(1500);
            output.Append("Coaches4Lawyers failing 5 June\n\n");

            // FAIL
            driver.Url = "https://coaches4lawyers.co.uk/wp-login.php";
            Thread.Sleep(1500);
            element = driver.FindElement(By.Id("user_login"));
            element.Clear();
            element.SendKeys("cjibbwsr");
            element = driver.FindElement(By.Id("user_pass"));
            element.Clear();
            element.SendKeys("##harmony7***");
            element = driver.FindElement(By.Id("wp-submit"));
            element.Click();
            Thread.Sleep(1500);
            output.Append("Coaches4Lawyers failing 5 June\n\n");



            // FAIL
            driver.Url = "https://coaches4lawyers.co.uk/wp-login.php";
            Thread.Sleep(1500);
            element = driver.FindElement(By.Id("user_login"));
            element.Clear();
            element.SendKeys("jibbylt@gmail.com");
            element = driver.FindElement(By.Id("user_pass"));
            element.Clear();
            element.SendKeys("7*WellinGtondrive$%");
            element = driver.FindElement(By.Id("wp-submit"));
            element.Click();
            Thread.Sleep(1500);
            output.Append("Coaches4Lawyers failing 5 June\n\n");


            //FAIL


            driver.Url = "https://coaches4lawyers.co.uk/wp-login.php";
            Thread.Sleep(1500);
            element = driver.FindElement(By.Id("user_login"));
            element.Clear();
            element.SendKeys("jibbylt@hotmail.com");
            element = driver.FindElement(By.Id("user_pass"));
            element.Clear();
            element.SendKeys("7*WellinGtondrive$%");
            element = driver.FindElement(By.Id("wp-submit"));
            element.Click();
            Thread.Sleep(1500);
            output.Append("Coaches4Lawyers failing 5 June\n\n");






        }



        [Test]
        public void Jibby_Site_07_Coaches4Staff_co_uk_Login_Check()
        {







            //FAIL


            driver.Url = "https://coaches4staff.co.uk/wp-login.php";
            Thread.Sleep(1500);
            element = driver.FindElement(By.Id("user_login"));
            element.Clear();
            element.SendKeys("jibbylt@hotmail.com");
            element = driver.FindElement(By.Id("user_pass"));
            element.Clear();
            element.SendKeys("Olushadeomomi7*");
            element = driver.FindElement(By.Id("wp-submit"));
            element.Click();
            Thread.Sleep(1500);
            output.Append("Coaches4Staff failing 5 June\n\n");





            //FAIL


            driver.Url = "https://coaches4staff.co.uk/wp-login.php";
            Thread.Sleep(1500);
            element = driver.FindElement(By.Id("user_login"));
            element.Clear();
            element.SendKeys("jibbylt@gmail.com");
            element = driver.FindElement(By.Id("user_pass"));
            element.Clear();
            element.SendKeys("7*WellinGtondrive$%");
            element = driver.FindElement(By.Id("wp-submit"));
            element.Click();
            Thread.Sleep(1500);
            output.Append("Coaches4Staff failing 5 June\n\n");


            //FAIL


            driver.Url = "https://coaches4staff.co.uk/wp-login.php";
            Thread.Sleep(1500);
            element = driver.FindElement(By.Id("user_login"));
            element.Clear();
            element.SendKeys("jibbylt@hotmail.com");
            element = driver.FindElement(By.Id("user_pass"));
            element.Clear();
            element.SendKeys("7*WellinGtondrive$%");
            element = driver.FindElement(By.Id("wp-submit"));
            element.Click();
            Thread.Sleep(1500);
            output.Append("Coaches4Staff failing 5 June\n\n");




            Console.WriteLine(output);
        }

        void LogStatus(TestStatus testStatus)
        {
            var logEntry = $"{testStatus.SiteUrl,-50},{testStatus.TestPassingStatus,-20},{testStatus.EmailAddress,-40},{testStatus.PasswordString,-40},{testStatus.SiteStatus}";
            Console.WriteLine(logEntry);
            outputLines.Add(logEntry);
        }

        void WriteToFile()
        {
            File.AppendAllLines(@"c:\data\output.csv", outputLines);
            Process.Start("subl", @"c:\data\output.csv");
            //  Process.Start(@"C:\Program Files (x86)\Microsoft Office\root\Office16\excel.exe", @"c:\data\output.csv");
        }

        [TearDown]
        public void EndTest()
        {
            WriteToFile();
            driver.Close();
          //  driver.Quit(); // closes all windows regardless

        }

    }
}

