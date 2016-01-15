using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AutoFrameworkDemo
{
    public static class Home
    {
        public static String IndexPage1Heading()

        {
           var index1Heading = Browser.driver.FindElement(By.CssSelector("#slider-area > ul > li:nth-child(1) > div.splashIndent > h1")).Text;
           return index1Heading.ToString();
        }
    }

   
}
