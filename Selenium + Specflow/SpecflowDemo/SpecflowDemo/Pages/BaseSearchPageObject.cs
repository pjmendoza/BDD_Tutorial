using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using SpecflowDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageObjectFramework;

namespace ConsoleApplication1
{
    class BaseSearchPageObject
    {
        public BaseSearchPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='searchString']")]
        public IWebElement SearchBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='generalSearch']/div[2]/button")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='mainContent']/h1/span")]
        public IWebElement ResultString { get; set; }



        public void SearchByKeyword(string keyword)
        {
            Custom_Methods.EnterText(SearchBox, keyword);
            Custom_Methods.Click(SearchButton);


        }

        public void CheckSearchResults(string keyword)
        {

            //Sync Point
            Custom_Methods.WaitForObject(By.XPath("//*[@id='mainContent']/h1"));

            string Searchresult1 = Custom_Methods.GetText(ResultString);
            string Searchresult = Custom_Methods.TrimResults(Searchresult1);

            //Checkpoints
            Assert.AreEqual(keyword, Searchresult);
        }
    }



}
