using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Feb25TurnUpPortal.Pages
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver)
        {
            //Launch TurnUPportal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
            driver.Manage().Window.Maximize();

            //Identify UserName TextBox and enter valid username
            IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
            usernameTextBox.SendKeys("hari");

            //Identify Password TextBox and enter valid Password
            IWebElement pwdTextBox = driver.FindElement(By.Id("Password"));
            pwdTextBox.SendKeys("123123");


            //Identify LoginButton and click on it
            IWebElement loginButton = driver.FindElement(By.XPath("//input[@value='Log in']"));
            loginButton.Click();




        }
        public void CheckSuccessfulLogin(IWebDriver driver)
        {
            //Check if user has logged in successfuly
            IWebElement hellohari = driver.FindElement(By.XPath("//a[text()='Hello hari!']"));

            if (hellohari.Text == "Hello hari!")
            {
                Console.WriteLine("User has logged in successfully.Test Passed");
            }
            else
            {
                Console.WriteLine("User has not logged in.Test failed");

            }

        }
    }
}