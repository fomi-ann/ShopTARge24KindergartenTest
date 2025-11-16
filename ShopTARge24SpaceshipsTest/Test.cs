using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using System.Security.Cryptography.X509Certificates;

namespace ShopTARge24SpaceshipTest
{
    public class Test
    {
        private static void Main(string[] args)
        {
            // CRUD & navigation tests
            TestSpaceshipCreateValid();
            TestSpaceshipUpdateValid();
            TestSpaceshipDetails();
            TestSpaceshipDelete();

            // Back to Index navigation tests
            TestSpaceshipBackToIndexCreate();
            TestSpaceshipBackToIndexUpdate();
            TestSpaceshipBackToIndexDelete();

            // Invalid input tests
            TestSpaceshipCreateInvalid();
            TestSpaceshipUpdateInvalid();
        }

        public static IWebDriver TestBase()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://localhost:7053/";
            return driver;
        }


        public static void TestNavigateToIndex(IWebDriver driver)
        {
            // Navigate to Index
            IWebElement idOfLinkElement = driver.FindElement(By.Id("spaceshipIndex"));
            idOfLinkElement.Click();
        }

        public static void TestNavigateToCreate(IWebDriver driver)
        {
            // Create btn Index view
            IWebElement idOfCreateButton = driver.FindElement(By.Id("spaceshipCreate"));
            idOfCreateButton.Click();
        }

        public static void TestNavigateToUpdate(IWebDriver driver)
        {
            // Update btn Index view
            IWebElement idOfUpdateButton = driver.FindElement(By.Id("spaceshipUpdate"));
            idOfUpdateButton.Click();
        }

        public static void TestNavigateToDetails(IWebDriver driver)
        {
            // Details btn Index view
            IWebElement idOfDetailsButton = driver.FindElement(By.Id("spaceshipDetails"));
            idOfDetailsButton.Click();
        }

        public static void TestNavigateToDelete(IWebDriver driver)
        {
            // Delete btn Index view
            IWebElement idOfDeleteButton = driver.FindElement(By.Id("spaceshipDelete"));
            idOfDeleteButton.Click();
        }

        [Test]
        public static void TestSpaceshipCreateValid()
        {
            var driver = TestBase();

            // Valid Test Data
            string TD_spaceshipName = "Test Spaceship Name";
            string TD_spaceshipClass = "Test Spaceship Classification";
            string TD_spaceshipBuiltDate = "02-09-2026, 00:00";
            string TD_spaceshipCrew = "111";
            string TD_spaceshipEngine = "555";

            // Navigate to Index
            TestNavigateToIndex(driver);

            // Create btn Index view
            TestNavigateToCreate(driver);

            // Spaceship Name
            Thread.Sleep(500);
            IWebElement idOfSpaceshipNameInput = driver.FindElement(By.Id("spaceshipName"));
            idOfSpaceshipNameInput.Click();
            idOfSpaceshipNameInput.SendKeys(TD_spaceshipName);

            // Spaceship Classification
            Thread.Sleep(500);
            IWebElement idOfSpaceshipClassInput = driver.FindElement(By.Id("spaceshipClass"));
            idOfSpaceshipClassInput.Click();
            idOfSpaceshipClassInput.SendKeys(TD_spaceshipClass);

            // Spaceship Built Date
            Thread.Sleep(500);
            IWebElement idOfSpaceshipBuiltDateInput = driver.FindElement(By.Id("spaceshipBuiltDate"));
            idOfSpaceshipBuiltDateInput.Click();
            idOfSpaceshipBuiltDateInput.SendKeys(TD_spaceshipBuiltDate);

            // Spaceship Crew
            Thread.Sleep(500);
            IWebElement idOfSpaceshipCrewInput = driver.FindElement(By.Id("spaceshipCrew"));
            idOfSpaceshipCrewInput.Click();
            idOfSpaceshipCrewInput.SendKeys(TD_spaceshipCrew);

            // Spaceship Built Date
            Thread.Sleep(500);
            IWebElement idOfSpaceshipEngineInput = driver.FindElement(By.Id("spaceshipEngine"));
            idOfSpaceshipEngineInput.Click();
            idOfSpaceshipEngineInput.SendKeys(TD_spaceshipEngine);

            //Create btn
            Thread.Sleep(500);
            IWebElement idOfCreateActionButton = driver.FindElement(By.Id("createCrtUpd"));
            idOfCreateActionButton.Click();

        }
        [Test]
        public static void TestSpaceshipCreateInvalid()
        {
            var driver = TestBase();

            // Invalid Test Data
            string TD_spaceshipName = "";
            string TD_spaceshipClass = "";
            string TD_spaceshipBuiltDate = "";
            string TD_spaceshipCrew = "";
            string TD_spaceshipEngine = "";

            // Navigate to Index
            TestNavigateToIndex(driver);

            // Create btn Index view
            TestNavigateToCreate(driver);

            // Spaceship Name
            Thread.Sleep(500);
            IWebElement idOfSpaceshipNameInput = driver.FindElement(By.Id("spaceshipName"));
            idOfSpaceshipNameInput.Click();
            idOfSpaceshipNameInput.SendKeys(TD_spaceshipName);

            // Spaceship Classification
            Thread.Sleep(500);
            IWebElement idOfSpaceshipClassInput = driver.FindElement(By.Id("spaceshipClass"));
            idOfSpaceshipClassInput.Click();
            idOfSpaceshipClassInput.SendKeys(TD_spaceshipClass);

            // Spaceship Built Date
            Thread.Sleep(500);
            IWebElement idOfSpaceshipBuiltDateInput = driver.FindElement(By.Id("spaceshipBuiltDate"));
            idOfSpaceshipBuiltDateInput.Click();
            idOfSpaceshipBuiltDateInput.SendKeys(TD_spaceshipBuiltDate);

            // Spaceship Crew
            Thread.Sleep(500);
            IWebElement idOfSpaceshipCrewInput = driver.FindElement(By.Id("spaceshipCrew"));
            idOfSpaceshipCrewInput.Click();
            idOfSpaceshipCrewInput.SendKeys(TD_spaceshipCrew);

            // Spaceship Built Date
            Thread.Sleep(500);
            IWebElement idOfSpaceshipEngineInput = driver.FindElement(By.Id("spaceshipEngine"));
            idOfSpaceshipEngineInput.Click();
            idOfSpaceshipEngineInput.SendKeys(TD_spaceshipEngine);


            //Create btn
            Thread.Sleep(500);
            IWebElement idOfCreateActionButton = driver.FindElement(By.Id("createCrtUpd"));
            idOfCreateActionButton.Click();

            Console.WriteLine("Success on invalid input ;(");

            Assert.Fail("The program did not crash, but it should have...");

        }

        [Test]
        public static void TestSpaceshipUpdateValid()
        {
            var driver = TestBase();

            // Valid Test Data
            string TD_spaceshipName = "Update Test Spaceship Name";
            string TD_spaceshipClass = "Update Test Spaceship Classification";
            string TD_spaceshipBuiltDate = "20-02-2026, 00:00";
            string TD_spaceshipCrew = "333";
            string TD_spaceshipEngine = "888";

            // Navigate to Index
            TestNavigateToIndex(driver);

            // Create btn Index view
            TestNavigateToUpdate(driver);

            // Update Spaceship Name
            Thread.Sleep(500);
            IWebElement idOfSpaceshipNameInput = driver.FindElement(By.Id("spaceshipName"));
            idOfSpaceshipNameInput.Clear();
            idOfSpaceshipNameInput.Click();
            idOfSpaceshipNameInput.SendKeys(TD_spaceshipName);

            // Update Spaceship Classification
            Thread.Sleep(500);
            IWebElement idOfSpaceshipClassInput = driver.FindElement(By.Id("spaceshipClass"));
            idOfSpaceshipClassInput.Clear();
            idOfSpaceshipClassInput.Click();
            idOfSpaceshipClassInput.SendKeys(TD_spaceshipClass);

            // Update Spaceship Built Date
            Thread.Sleep(500);
            IWebElement idOfSpaceshipBuiltDateInput = driver.FindElement(By.Id("spaceshipBuiltDate"));
            idOfSpaceshipBuiltDateInput.Clear();
            idOfSpaceshipBuiltDateInput.Click();
            idOfSpaceshipBuiltDateInput.SendKeys(TD_spaceshipBuiltDate);

            // Update Spaceship Crew
            Thread.Sleep(500);
            IWebElement idOfSpaceshipCrewInput = driver.FindElement(By.Id("spaceshipCrew"));
            idOfSpaceshipCrewInput.Clear();
            idOfSpaceshipCrewInput.Click();
            idOfSpaceshipCrewInput.SendKeys(TD_spaceshipCrew);

            // Update Spaceship Built Date
            Thread.Sleep(500);
            IWebElement idOfSpaceshipEngineInput = driver.FindElement(By.Id("spaceshipEngine"));
            idOfSpaceshipEngineInput.Clear();
            idOfSpaceshipEngineInput.Click();
            idOfSpaceshipEngineInput.SendKeys(TD_spaceshipEngine);

            // Update btn
            Thread.Sleep(500);
            IWebElement idOfUpdateActionButton = driver.FindElement(By.Id("updateCrtUpd"));
            idOfUpdateActionButton.Click();

        }
        [Test]
        public static void TestSpaceshipUpdateInvalid()
        {
            var driver = TestBase();

            // Invalid Test Data
            string TD_spaceshipName = "";
            string TD_spaceshipClass = "";
            string TD_spaceshipBuiltDate = "";
            string TD_spaceshipCrew = "";
            string TD_spaceshipEngine = "";

            // Navigate to Index
            TestNavigateToIndex(driver);

            // Update btn Index view
            TestNavigateToUpdate(driver);

            // Spaceship Name
            Thread.Sleep(500);
            IWebElement idOfSpaceshipNameInput = driver.FindElement(By.Id("spaceshipName"));
            idOfSpaceshipNameInput.Click();
            idOfSpaceshipNameInput.SendKeys(TD_spaceshipName);

            // Spaceship Classification
            Thread.Sleep(500);
            IWebElement idOfSpaceshipClassInput = driver.FindElement(By.Id("spaceshipClass"));
            idOfSpaceshipClassInput.Click();
            idOfSpaceshipClassInput.SendKeys(TD_spaceshipClass);

            // Spaceship Built Date
            Thread.Sleep(500);
            IWebElement idOfSpaceshipBuiltDateInput = driver.FindElement(By.Id("spaceshipBuiltDate"));
            idOfSpaceshipBuiltDateInput.Click();
            idOfSpaceshipBuiltDateInput.SendKeys(TD_spaceshipBuiltDate);

            // Spaceship Crew
            Thread.Sleep(500);
            IWebElement idOfSpaceshipCrewInput = driver.FindElement(By.Id("spaceshipCrew"));
            idOfSpaceshipCrewInput.Click();
            idOfSpaceshipCrewInput.SendKeys(TD_spaceshipCrew);

            // Spaceship Built Date
            Thread.Sleep(500);
            IWebElement idOfSpaceshipEngineInput = driver.FindElement(By.Id("spaceshipEngine"));
            idOfSpaceshipEngineInput.Click();
            idOfSpaceshipEngineInput.SendKeys(TD_spaceshipEngine);


            // Update btn
            Thread.Sleep(500);
            IWebElement idOfUpdateActionButton = driver.FindElement(By.Id("updateCrtUpd"));
            idOfUpdateActionButton.Click();

            Console.WriteLine("Success on invalid input ;(");

            Assert.Fail("The program did not crash, but it should have...");

        }

        [Test]
        public static void TestSpaceshipDetails()
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
        public static void TestSpaceshipDelete()
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
        public static void TestSpaceshipBackToIndexCreate()
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
        public static void TestSpaceshipBackToIndexUpdate()
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
        public static void TestSpaceshipBackToIndexDelete()
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

