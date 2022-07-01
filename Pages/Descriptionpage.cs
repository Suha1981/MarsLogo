using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsLogo.POM
{
    internal class Description
    {
        [When(@"User filled the Description details and saved")]
        public void WhenUserFilledTheDescriptionDetailsAndSaved(IWebDriver driver)
        {
            // Identify Description //
            IWebElement Description = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            Description.Click();
            // Navigate to Description Textbox//
            IWebElement description_Textbox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            description_Textbox.Clear();
            description_Textbox.SendKeys("ILove dancing,cooking,gym and long walks ,prefer to spend time with friends on the weekends.I consider myself as an all rounder,My biggest strength is multitasking skills");
            driver.FindElement(By.XPath("//*[@id='account-profile-section']//div[3]/div/div/form/div/div/div[2]/button")).Click();


        }

        [Then(@"The Description details should be added successfully")]
        public void ThenTheDescriptionDetailsShouldBeAddedSuccessfully(IWebDriver driver)
        {
            IWebElement Description = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/span"));
            Assert.True(Description.Displayed);
        }
    }
}    

       
        

