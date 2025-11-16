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
            // CRUD & navigation tests
            TestKindergartenCreateValid();
            TestKindergartenUpdateValid();
            TestKindergartenDetails();
            TestKindergartenDelete();

            // Back to Index navigation tests
            TestKindergartenBackToIndexCreate();
            TestKindergartenBackToIndexUpdate();
            TestKindergartenBackToIndexDelete();

            // Invalid input tests
            TestKindergartenCreateInvalid();
            TestKindergartenUpdateInvalid();
        }

        public static IWebDriver TestBase()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://localhost:7053/";
            return driver;
        }

 
        public static void TestNavigateToIndex(IWebDriver driver) {
            // Navigate to Index
            IWebElement idOfLinkElement = driver.FindElement(By.Id("kindergartenIndex"));
            idOfLinkElement.Click();
        }

        public static void TestNavigateToCreate(IWebDriver driver)
        {
            // Create btn Index view
            IWebElement idOfCreateButton = driver.FindElement(By.Id("kindergartenCreate"));
            idOfCreateButton.Click();
        }

        public static void TestNavigateToUpdate(IWebDriver driver)
        {
            // Update btn Index view
            IWebElement idOfUpdateButton = driver.FindElement(By.Id("kindergartenUpdate"));
            idOfUpdateButton.Click();
        }

        public static void TestNavigateToDetails(IWebDriver driver)
        {
            // Details btn Index view
            IWebElement idOfDetailsButton = driver.FindElement(By.Id("kindergartenDetails"));
            idOfDetailsButton.Click();
        }

        public static void TestNavigateToDelete(IWebDriver driver)
        {
            // Delete btn Index view
            IWebElement idOfDeleteButton = driver.FindElement(By.Id("kindergartenDelete"));
            idOfDeleteButton.Click();
        }

        [Test]
        public static void TestKindergartenCreateValid()
        {
            var driver = TestBase();

            // Valid Test Data
            string TD_GroupName = "Group Name Test";
            string TD_ChildrenCount = "25";
            string TD_KindergartenName = "Kindergarten Name Test";
            string TD_TeacherName = "Teacher Name Test";

            // Navigate to Index
            TestNavigateToIndex(driver);

            // Create btn Index view
            TestNavigateToCreate(driver);

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
        public static void TestKindergartenCreateInvalid()
        {
            var driver = TestBase();

            // Invalid Test Data
            string TD_GroupName = "";
            string TD_ChildrenCount = "";
            string TD_KindergartenName = "";
            string TD_TeacherName = "";

            // Navigate to Index
            TestNavigateToIndex(driver);

            // Create btn Index view
            TestNavigateToCreate(driver);

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

            try
            {
                //Create btn
                Thread.Sleep(500);
                IWebElement idOfCreateActionButton = driver.FindElement(By.Id("createCrtUpd"));
                idOfCreateActionButton.Click();

                Assert.Fail("The program did not crash, but it should have...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Yey! Programm crashed due to invalid input! ;)");
            }
        }

        [Test]
        public static void TestKindergartenUpdateValid()
        {
            var driver = TestBase();

            // Valid Test Data
            string TD_GroupName = "Group Name Update Test";
            string TD_ChildrenCount = "33";
            string TD_KindergartenName = "Kindergarten Name Update Test";
            string TD_TeacherName = "Teacher Name Update Test";

            // Navigate to Index
            TestNavigateToIndex(driver);

            // Update btn Index view
            TestNavigateToUpdate(driver);

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
        public static void TestKindergartenUpdateInvalid()
        {
            var driver = TestBase();

            // Invalid Test Data
            string TD_GroupName = "";
            string TD_ChildrenCount = "";
            string TD_KindergartenName = "";
            string TD_TeacherName = "";

            // Navigate to Index
            TestNavigateToIndex(driver);

            // Update btn Index view
            TestNavigateToUpdate(driver);

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

            try
            {
                // Update btn
                Thread.Sleep(500);
                IWebElement idOfUpdateActionButton = driver.FindElement(By.Id("updateCrtUpd"));
                idOfUpdateActionButton.Click();

                Assert.Fail("The program did not crash, but it should have...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Yey! Programm crashed due to invalid input! ;)");
            }


        }

        [Test]
        public static void TestKindergartenDetails()
        {
            var driver = TestBase();

            // Navigate to Index
            TestNavigateToIndex(driver);

            // Details btn Index view
            TestNavigateToDetails(driver);

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
            TestNavigateToIndex(driver);

            // Delete btn Index view
            TestNavigateToDelete(driver);

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
            TestNavigateToIndex(driver);

            // Cretae btn Index view
            TestNavigateToCreate(driver);

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
            TestNavigateToIndex(driver);

            // Update btn Index view
            TestNavigateToUpdate(driver);

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
            TestNavigateToIndex(driver);

            // Delete btn Index view
            TestNavigateToDelete(driver);

            // Back btn Delete view
            Thread.Sleep(5000);
            IWebElement idOfBackButton = driver.FindElement(By.Id("backToIndexDlt"));
            idOfBackButton.Click();

        }



    }



}

