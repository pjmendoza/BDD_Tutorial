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
    public static class Browser
    {
        public static IWebDriver driver = new ChromeDriver();
        
        public static void openBrowswer(String url)

        {
            driver.Url = url;
       
        }

        public static void closeBrowswer()
        {
            driver.Quit();

        }
    }

  
}
