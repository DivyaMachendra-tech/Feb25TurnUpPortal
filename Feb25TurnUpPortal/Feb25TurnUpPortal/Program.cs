using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class Program
{
    private static void Main(string[] args)
    {
        //Open ChromeBrowser
        IWebDriver driver = new ChromeDriver();


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

        //Create time record
        IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
        administrationTab.Click();

        //Navigate to time and material page
        IWebElement timeAndMaterialOption = driver.FindElement(By.XPath("//a[text()='Time & Materials']"));
        timeAndMaterialOption.Click();


        //Click on create new button
        IWebElement createNewButton = driver.FindElement(By.XPath("//a[text()='Create New']"));
        createNewButton.Click();

        //Select time from dropdown
        IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span"));
        typeCodeDropdown.Click();

        IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
        timeOption.Click();

        //Type the code into code textbox
        IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
        codeTextBox.SendKeys("TA Programme");

        //Type description into description textbox
        IWebElement descriptionTextPath = driver.FindElement(By.Id("Description"));
        descriptionTextPath.SendKeys("This is a description");

        //Type price into price textbox
        IWebElement priceTagOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
        priceTagOverlap.Click();

        IWebElement priceTextBox = driver.FindElement(By.Id("Price"));
        priceTextBox.SendKeys("12");

        //Click on save button
        IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
        saveButton.Click();
        Thread.Sleep(3000);

        //check time record has been created successfully
        IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        goToLastPageButton.Click();
        Thread.Sleep(3000);

        IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

        if (newCode.Text == "TA Programme")
        {
            Console.WriteLine("Time record created successfully!");
        }
        else
        {
            Console.WriteLine("New time recorded has not been created!");

        }

        Thread.Sleep(3000);
        //Click on the Edit button
        IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
        editButton.Click();

        //Edit the price per unit
        IWebElement priceTagOverlap1 = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
        priceTagOverlap1.Click();

        IWebElement priceTextBox1 = driver.FindElement(By.Id("Price"));
        priceTextBox1.Clear();

        IWebElement priceTagOverlap2 = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
        priceTagOverlap1.Click();

        IWebElement priceTextBox2 = driver.FindElement(By.Id("Price"));
        priceTextBox2.SendKeys("40");

        //Click on save button
        IWebElement saveButtonAfterEdit = driver.FindElement(By.Id("SaveButton"));
        saveButtonAfterEdit.Click();
        Thread.Sleep(3000);


        IWebElement goToLastPageButton1 = driver.FindElement(By.XPath("//span[text()='Go to the last page']"));
        goToLastPageButton1.Click();

        //Click on the Delete button
        IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
        deleteButton.Click();

        //Deleting a record
        IAlert confirmAlert = driver.SwitchTo().Alert();
        confirmAlert.Accept();
        //String alertText = confirmAlert.Text;
        //Console.WriteLine(alertText);

        //check if the record is deleted

        IWebElement checkDelete = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));

        if (checkDelete.Text == "40")
        {
            Console.WriteLine("Record is not deleted");

        }
        else
        {
            Console.WriteLine("Record is deleted successfully");
        }



    }
}