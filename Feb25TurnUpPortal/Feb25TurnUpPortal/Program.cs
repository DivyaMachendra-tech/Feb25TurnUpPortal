using Feb25TurnUpPortal.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

public class Program
{
    private static void Main(string[] args)
    {
        //Open ChromeBrowser
        IWebDriver driver = new ChromeDriver();

        //LoginPage Object initaialization and definition
        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginActions(driver);

        //HomePage Object initaialization and definition
        HomePage homePageObj = new HomePage();
        homePageObj.NavigateToTMPage(driver);

        //TMPage Object initaialization and definition
        TMPage tmPageObj = new TMPage();
        tmPageObj.CreateTimeRecord(driver);
        tmPageObj.EditTimeRecord(driver);
        tmPageObj.DeleteTimeRecord(driver);
















    }
}