using BDDSpecflow_project.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace BDDSpecflow_project.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        [Given(@"I have browser with OrangeHRM")]
        public void GivenIHaveBrowserWithOrangeHRM()
        {
            AutomationHooks.driver = new ChromeDriver();
            AutomationHooks.driver.Manage().Window.Maximize();
            AutomationHooks.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            AutomationHooks.driver.Url = "https://opensource-demo.orangehrmlive.com/";
        }

        [When(@"I enter username as ""([^""]*)""")]
        public void WhenIEnterUsernameAs(string username)
        {
            AutomationHooks.driver.FindElement(By.Name("username")).SendKeys(username);
        }


        [When(@"I enter password as ""([^""]*)""")]
        public void WhenIEnterPasswordAs(string password)
        {
            AutomationHooks.driver.FindElement(By.Name("password")).SendKeys(password);
        }

        [When(@"I click on login")]
        public void WhenIClickOnLogin()
        {
            AutomationHooks.driver.FindElement(By.CssSelector("button[type='submit']")).Click();
        }

        [Then(@"I should navigate to ""([^""]*)""")]
        public void ThenIShouldNavigateTo(string navigateTo)
        {
            Console.WriteLine(navigateTo);
        }



        [Then(@"I should get error message ""([^""]*)""")]
        public void ThenIShouldGetErrorMessage(string error)
        {
            Console.WriteLine(error);
        }

    }
}
