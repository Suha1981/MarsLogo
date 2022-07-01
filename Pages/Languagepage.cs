using MarsLogo.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA1.Pages
{
    internal class Languagepage
    {
        private object driver;

        [When(@"User filled the language details and saved")]
        public void WhenUserFilledTheLanguageDetailsAndSaved(IWebDriver driver)
        {
            // Identify Languages //
            IWebElement language = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[1]/h3"));
            language.Click();
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
            // Navigate to Language Textbox//
            IWebElement language_Textbox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            language_Textbox.SendKeys("English");
            SelectOptionByValue(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"), "Fluent");
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")).Click();
        }

        private void SelectOptionByValue(By by, string v)
        {
            throw new NotImplementedException();
        }

        [Then(@"The language details should be added successfully")]
        public void ThenTheLanguageDetailsShouldBeAddedSuccessfully(IWebDriver driver)
        {
            IWebElement language = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            Assert.True(language.Displayed);
        }
    }
}



