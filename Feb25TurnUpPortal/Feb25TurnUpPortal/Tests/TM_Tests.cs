using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Feb25TurnUpPortal.Pages;
using Feb25TurnUpPortal.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Feb25TurnUpPortal.Tests
{
    [TestFixture]
    public class TM_Tests : CommonDriver
    {
        [SetUp]
        public void SetUpSteps()

        {
            driver = new ChromeDriver();
            
            //LoginPage Object initaialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver,"hari","123123");

            //HomePage Object initaialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.NavigateToTMPage(driver);

        }
        [Test]
        public void CreateTime_Test() {


            //TMPage Object initaialization and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTimeRecord(driver);


        }
        [Test]
        public void EditTime_Test()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTimeRecord(driver);

        }
        [Test]
        public void DeleteTime_Test()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTimeRecord(driver);


        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();

        }

    }
}
