
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


//Open a chrome brower

IWebDriver peggydriver = new ChromeDriver();
peggydriver.Manage().Window.Maximize();

//lauach a portal
peggydriver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

//Identify the user name textbox and enter a valid user name
IWebElement usernametextbox = peggydriver.FindElement(By.Id("UserName"));
usernametextbox.SendKeys("hari");

//Identify the password textbox and enter a valid password

IWebElement passwordtextbox = peggydriver.FindElement(By.Id("Password"));
passwordtextbox.SendKeys("123123");

//Identify the login button and click on the login button
IWebElement loginbutton = peggydriver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginbutton.Click();

//check if user has successfully login
IWebElement HelloHari = peggydriver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if(HelloHari.Text == "Hello hari!")
{
    Console.WriteLine("Login successfully");
}
else
{
    Console.WriteLine("login failed");
}






