using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using AutoFrameworkDemo;

namespace AutoFrameworkDemo
{
    public static class ContactUs
    {
        //properties
        
        //methods
        public static void goToContactUs()

        {
           // Browser.openBrowswer();
           // Browser.driver.Url = "http://www.planit.net.au/contact/";
       
        }

        public static String getHeaderContactUs()
        {
            
            return Browser.driver.FindElement(By.CssSelector("#left > h1")).Text.ToString();
            //return MyExtensions       
            //MyExtensions                        
            
        }

        public static String getfNameContactUs()
        {
            return Browser.driver.FindElement(By.CssSelector("#lw_f14_table #f48")).Text;
        }

        public static void setfNameContactUs(String input)
        {
            Browser.driver.FindElement(By.CssSelector("#lw_f14_table #f48")).SendKeys(input);
        }

        public static String getlNameContactUs()
        {
            return Browser.driver.FindElement(By.CssSelector("#lw_f14_table #f49")).Text;
        }

        public static void setlNameContactUs(String input)
        {
            Browser.driver.FindElement(By.CssSelector("#lw_f14_table #f49")).SendKeys(input);
        }

        public static String getphoneContactUs()
        {
            return Browser.driver.FindElement(By.CssSelector("#lw_f14_table #f144")).Text;
        }

        public static void setphoneContactUs(String input)
        {
            Browser.driver.FindElement(By.CssSelector("#lw_f14_table #f144")).SendKeys(input);
        }

        public static String getstateContactUs()
        {
            return Browser.driver.FindElement(By.CssSelector("#lw_f14_table #f145")).Text;
        }

         


        public static void setStateContactUs()
        {

            //SelectElement selector = new SelectElement(By.CssSelector(""));
            //selector.SelectByIndex(1);
        }

        public static void setDepartmentContactUs(String depart)
        {

            IWebElement x = Browser.driver.FindElement(By.CssSelector("#lw_f14_table #f52"));
            new SelectElement(x).SelectByText(depart);
        }



        public static void clickEnquireContactUs()
        {
            Browser.driver.FindElement(By.CssSelector("#lw_f14_table #f53")).Click();
        }

        public static String getErrorMessage()
        {
            return Browser.driver.FindElement(By.CssSelector("#lw_f14_table > tbody > tr:nth-child(7) > td:nth-child(2) > label")).Text;
        }
        
    }

  
}
