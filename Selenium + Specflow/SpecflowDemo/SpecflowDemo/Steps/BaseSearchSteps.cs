using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;
using PageObjectFramework;

namespace SpecflowDemo
{
    [Binding]
    public class BaseSearchSteps
    {
        [Given(@"I have navigated to TradeMe search page")]
        public void GivenIHaveNavigatedToTradeMeSearchPage()
        {            
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("http://www.trademe.co.nz/");
        }


        [When(@"I enter an Iphone keyword")]
        public void WhenIEnterAIphoneKeyword()
        {
            BaseSearchPageObject page = new BaseSearchPageObject();
            string TestData = "Iphone 6";
            page.SearchByKeyword(TestData);
        }

      
        
        [Then(@"the result set should match the keyword I entered")]
        public void ThenTheResultSetShouldMatchTheKeywordIEntered()
        {
            BaseSearchPageObject page = new BaseSearchPageObject();
            string TestData = "Iphone 6";
            page.CheckSearchResults(TestData);
        }
    }
}
