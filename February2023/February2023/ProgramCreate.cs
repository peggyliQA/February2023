
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;
using System;


//Open a chrome brower *********************
IWebDriver peggydriver = new ChromeDriver(chromeDriverDirectory:@"c:/February2023");
peggydriver.Manage().Window.Maximize();


//lauach a portal ********************
peggydriver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
Thread.Sleep(1500);


//Identify the user name textbox and enter a valid user name ***************
IWebElement usernametextbox = peggydriver.FindElement(By.Id("UserName"));
usernametextbox.SendKeys("hari");

//Identify the password textbox and enter a valid password 

IWebElement passwordtextbox = peggydriver.FindElement(By.Id("Password"));
passwordtextbox.SendKeys("123123");

//Identify the login button and click on the login button
IWebElement loginbutton = peggydriver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginbutton.Click();
Thread.Sleep(1500);

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
//================================================================================
//naivigate the time and material page (go to admin -> select time and material)

IWebElement adminmenu = peggydriver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
adminmenu.Click();
IWebElement timematerialopt = peggydriver.FindElement(By.XPath("//html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
timematerialopt.Click();
Thread.Sleep(2000);


//Add new record - click on create new button
IWebElement createnewrecord = peggydriver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createnewrecord.Click();
Thread.Sleep(1500);

//Add record details - select the time from the drop down type code list
IWebElement typecodedropdownbox = peggydriver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
//select time from the dropdown box
IWebElement selecttime = peggydriver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
selecttime.Click();


//add record details - input code into code text box
IWebElement codetextbox = peggydriver.FindElement(By.Id("Code"));
codetextbox.SendKeys("Peggy February 2023");
Thread.Sleep(2000);


//add record details - input description into description box
IWebElement descriptionbox = peggydriver.FindElement(By.Id("Description"));
descriptionbox.SendKeys("Peggy February 2023");
Thread.Sleep(3000);

//add record details -input unit into price text box (LEARN THIS)

IWebElement priceTextbox = peggydriver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
priceTextbox.SendKeys("12");
Thread.Sleep(2000);


//add record details - click on save button
IWebElement savebutton = peggydriver.FindElement(By.Id("SaveButton"));
savebutton.Click();
Thread.Sleep(2500);

//check if the record is being created
//locating last page button (not sure)
IWebElement gotolastpage = peggydriver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
gotolastpage.Click();
Thread.Sleep(1500);

//locating last record
IWebElement LastRecord   = peggydriver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
Thread.Sleep(2000);
if(LastRecord.Text == "Peggy February 2023")
{
    Console.WriteLine("new record created successfully for Peggy");
}
else
{
    Console.WriteLine("record has not been created for Peggy");
}

