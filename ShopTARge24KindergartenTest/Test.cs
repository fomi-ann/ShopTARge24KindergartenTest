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
            TestKindergartenUpdate();
            TestKindergartenDetails();
            TestKindergartenDelete();

            TestKindergartenBackToIndexCreate();
            TestKindergartenBackToIndexUpdate();
            TestKindergartenBackToIndexDelete();

        }

        public static IWebDriver TestBase()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://localhost:7053/";
            return driver;
        }

        [Test]
        public static void TestKindergartenCreate()
        {
            var driver = TestBase();

            //GroupName
            //ChildrenCount
            //KindergartenName
            //TeacherName

            string TD_GroupName = "Group Name Test";
            string TD_ChildrenCount = "25";
            string TD_KindergartenName = "Kindergarten Name Test";
            string TD_TeacherName = "Teacher Name Test";

            // Navigate to Index
            IWebElement idOfLinkElement = driver.FindElement(By.Id("kindergartenIndex"));
            idOfLinkElement.Click();

            // Create btn Index view
            IWebElement idOfCreateButton = driver.FindElement(By.Id("kindergartenCreate"));
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
            IWebElement idOfCreateActionButton = driver.FindElement(By.Id("createCrtUpd"));
            idOfCreateActionButton.Click();

        }

        [Test]
        public static void TestKindergartenUpdate()
        {
            var driver = TestBase();

            //GroupName
            //ChildrenCount
            //KindergartenName
            //TeacherName

            string TD_GroupName = "Group Name Update Test";
            string TD_ChildrenCount = "33";
            string TD_KindergartenName = "Kindergarten Name Update Test";
            string TD_TeacherName = "Teacher Name Update Test";

            // Navigate to Index
            IWebElement idOfLinkElement = driver.FindElement(By.Id("kindergartenIndex"));
            idOfLinkElement.Click();

            // Update btn Index view
            IWebElement idOfUpdateButton = driver.FindElement(By.Id("kindergartenUpdate"));
            idOfUpdateButton.Click();

            // Update Group Name
            Thread.Sleep(500);
            IWebElement idOfGroupNameInput = driver.FindElement(By.Id("groupName"));
            idOfGroupNameInput.Clear();
            idOfGroupNameInput.Click();
            idOfGroupNameInput.SendKeys(TD_GroupName);

            // Update Children Count
            Thread.Sleep(500);
            IWebElement idOfChildrenCountInput = driver.FindElement(By.Id("childrenCount"));
            idOfChildrenCountInput.Clear();
            idOfChildrenCountInput.Click();
            idOfChildrenCountInput.SendKeys(TD_ChildrenCount);

            // Update Kindergarten Name
            Thread.Sleep(500);
            IWebElement idOfKindergartenNameInput = driver.FindElement(By.Id("kindergartenName"));
            idOfKindergartenNameInput.Clear();
            idOfKindergartenNameInput.Click();
            idOfKindergartenNameInput.SendKeys(TD_KindergartenName);

            // Update Teacher Name
            Thread.Sleep(500);
            IWebElement idOfTeacherNameInput = driver.FindElement(By.Id("teacherName"));
            idOfTeacherNameInput.Clear();
            idOfTeacherNameInput.Click();
            idOfTeacherNameInput.SendKeys(TD_TeacherName);

            // Update btn
            Thread.Sleep(500);
            IWebElement idOfUpdateActionButton = driver.FindElement(By.Id("updateCrtUpd"));
            idOfUpdateActionButton.Click();

        }

        [Test]
        public static void TestKindergartenDetails()
        {
            var driver = TestBase();

            // Navigate to Index
            IWebElement idOfLinkElement = driver.FindElement(By.Id("kindergartenIndex"));
            idOfLinkElement.Click();

            // Details btn Index view
            IWebElement idOfDetailsButton = driver.FindElement(By.Id("kindergartenDetails"));
            idOfDetailsButton.Click();

            // Back to Index btn
            Thread.Sleep(5000);
            IWebElement idOfBackButton = driver.FindElement(By.Id("backToIndexDtls"));
            idOfBackButton.Click();

        }

        [Test]
        public static void TestKindergartenDelete()
        {
            var driver = TestBase();

            // Navigate to Index
            IWebElement idOfLinkElement = driver.FindElement(By.Id("kindergartenIndex"));
            idOfLinkElement.Click();

            // Delete btn Index view
            IWebElement idOfDeleteButton = driver.FindElement(By.Id("kindergartenDelete"));
            idOfDeleteButton.Click();

            // Delete btn Delete view
            Thread.Sleep(5000);
            IWebElement idOfDeleteActionButton = driver.FindElement(By.Id("deleteDlt"));
            idOfDeleteActionButton.Click();

        }

        [Test]
        public static void TestKindergartenBackToIndexCreate()
        {
            var driver = TestBase();

            // Navigate to Index
            IWebElement idOfLinkElement = driver.FindElement(By.Id("kindergartenIndex"));
            idOfLinkElement.Click();

            // Cretae btn Index view
            IWebElement idOfCreateButton = driver.FindElement(By.Id("kindergartenCreate"));
            idOfCreateButton.Click();

            // Back btn CreateUpdate view
            Thread.Sleep(5000);
            IWebElement idOfBackButton = driver.FindElement(By.Id("backToIndexCrtUpd"));
            idOfBackButton.Click();

        }

        [Test]
        public static void TestKindergartenBackToIndexUpdate()
        {
            var driver = TestBase();

            // Navigate to Index
            IWebElement idOfLinkElement = driver.FindElement(By.Id("kindergartenIndex"));
            idOfLinkElement.Click();

            // Update btn Index view
            IWebElement idOfDeleteButton = driver.FindElement(By.Id("kindergartenUpdate"));
            idOfDeleteButton.Click();

            // Back btn CreateUpdate view
            Thread.Sleep(5000);
            IWebElement idOfBackButton = driver.FindElement(By.Id("backToIndexCrtUpd"));
            idOfBackButton.Click();

        }

        [Test]
        public static void TestKindergartenBackToIndexDelete()
        {
            var driver = TestBase();

            // Navigate to Index
            IWebElement idOfLinkElement = driver.FindElement(By.Id("kindergartenIndex"));
            idOfLinkElement.Click();

            // Delete btn Index view
            IWebElement idOfDeleteButton = driver.FindElement(By.Id("kindergartenDelete"));
            idOfDeleteButton.Click();

            // Back btn Delete view
            Thread.Sleep(5000);
            IWebElement idOfBackButton = driver.FindElement(By.Id("backToIndexDlt"));
            idOfBackButton.Click();

        }



    }



}

