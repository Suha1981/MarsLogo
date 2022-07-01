using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA1.Pages
{
    internal class Skillspage
    {

        [When(@"User filled the skills details and saved")]
        public void WhenUserFilledTheSkillsDetailsAndSaved(IWebDriver driver)
        {
            // Identify Skills //
            IWebElement Skills = driver.FindElement(By.XPath("//*[@id='account-profile-section']//div[3]//div[1]/a[2]"));
            Skills.Click();
            driver.FindElement(By.XPath("//*[@id='account-profile-section']//section[2]//div[3]/form/div[3]//table/thead/tr/th[3]/div")).Click();
            // Navigate to Skills Textbox//
            IWebElement Skills_Textbox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]//div[3]//div[1]/input"));
            Skills_Textbox.Clear();
            Skills_Textbox.SendKeys("Typing");
            SelectOptionByValue(By.XPath("//*[@id='account-profile-section']//div[3]//div[2]/select"), "Expert");
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]//span/input[1]")).Click();

        }

        private void SelectOptionByValue(By by, string v)
        {
            throw new NotImplementedException();
        }
    }

    [Then(@"The skills details should be added successfully")]
    public void ThenTheSkillsDetailsShouldBeAddedSuccessfully(IWebDriver driver)
    {
        IWebElement skills = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
        Assert.True(skills.Displayed);
    }
}

    

