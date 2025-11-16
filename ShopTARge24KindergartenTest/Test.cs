using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using System.Security.Cryptography.X509Certificates;

namespace ShopTARge24KindergartenTesting
{
    public class Test
    {
        private static void Main(string[] args)
        {
            TestKindergartenCreate();
        }

        [Test]
        public static void TestKindergartenCreate()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://localhost:7053/";

            //GroupName
            //ChildrenCount
            //KindergartenName
            //TeacherName

            string TD_GroupName = "Group Name Test";
            string TD_ChildrenCount = "25";
            string TD_KindergartenName = "Kindergarten Name Test";
            string TD_TeacherName = "Teacher Name Test";

            IWebElement idOfLinkElement = driver.FindElement(By.Id("kindergartenIndex"));
            idOfLinkElement.Click();

            IWebElement idOfCreateButton = driver.FindElement(By.Id("createIndex"));
            idOfCreateButton.Click();

            // Group Name
            Thread.Sleep(500);
            IWebElement idOfGroupNameInput = driver.FindElement(By.Id("groupName"));
            idOfGroupNameInput.Click();
            idOfGroupNameInput.SendKeys(TD_GroupName);

            // Children Count
            Thread.Sleep(500);
            IWebElement idOfChildrenCountInput = driver.FindElement(By.Id("childrenCount"));
            idOfChildrenCountInput.Clear();
            idOfChildrenCountInput.Click();
            idOfChildrenCountInput.SendKeys(TD_ChildrenCount);

            // Kindergarten Name
            Thread.Sleep(500);
            IWebElement idOfKindergartenNameInput = driver.FindElement(By.Id("kindergartenName"));
            idOfKindergartenNameInput.Click();
            idOfKindergartenNameInput.SendKeys(TD_KindergartenName);

            // Teacher Name
            Thread.Sleep(500);
            IWebElement idOfTeacherNameInput = driver.FindElement(By.Id("teacherName"));
            idOfTeacherNameInput.Click();
            idOfTeacherNameInput.SendKeys(TD_TeacherName);

            //Create btn
            Thread.Sleep(500);
            IWebElement idOfCreateButtonCU = driver.FindElement(By.Id("createCrtUpd"));
            idOfCreateButtonCU.Click();

        }


    }



}

