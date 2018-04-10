using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {        IWebDriver driver;
        static int i = 0;
        int usercount = 2;
        [TestMethod]
        public void TestMethod1()
        {
            Login();


            //create users
            /*driver.FindElement(By.LinkText("Users")).Click();
             driver.FindElement(By.XPath("//*[@id='navigation']/td[1]/ul/li[1]/a")).Click();
            System.Threading.Thread.Sleep(6000);
            for (int i = 0; i < usercount; i++)
            {
                System.Threading.Thread.Sleep(4000);
                CreateUser();
            }*/

            //create FACILITY
            /*  driver.FindElement(By.LinkText("Facility")).Click();
              System.Threading.Thread.Sleep(6000);
             // for (int i = 0; i < usercount; i++)            {
                  System.Threading.Thread.Sleep(4000);
                  CreateFacility();
             // }*/
        




        }

        private void CreateFacility()
        {
            driver.FindElement(By.XPath("//*[@id='dialog_link']")).Click();
            driver.FindElement(By.Name("inputName")).SendKeys("Demofacility");
            driver.FindElement(By.Name("Address1")).SendKeys("HYD");
            driver.FindElement(By.Name("city")).SendKeys("HYD");
            driver.FindElement(By.Id("states")).SendKeys("l");
            driver.FindElement(By.Id("timezone")).SendKeys("c");
            driver.FindElement(By.Id("zip")).SendKeys("48200");
            driver.FindElement(By.Id("inputPhone10")).SendKeys("(555) 555-5555");

            CreateRefFacility();
            //CreateAdmFacility();

        }

        private void CreateAdmFacility()
        {
        }

        private void CreateRefFacility()
        {
            driver.FindElement(By.XPath("//*[@id='dd']/label[2]/i")).Click();
            driver.FindElement(By.Id("subfacility")).SendKeys("c");
            driver.FindElement(By.Id("contactp")).SendKeys("himanshufacility");
            driver.FindElement(By.Id("cpemail")).SendKeys("him@him.com");
            driver.FindElement(By.XPath("//*[@id='ReferAmitDeSelect']/option[28]")).Click();
            driver.FindElement(By.Id("addrefergrp")).Click();
            driver.FindElement(By.LinkText("Facility")).Click();


            
        }
    

        public void Login()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.dashadmit123.com");
            driver.FindElement(By.Id("login")).SendKeys("admin");
            driver.FindElement(By.Id("passwd")).SendKeys("123" + Keys.Enter);
            System.Threading.Thread.Sleep(5000);
        }

        public void CreateUser()
        {
            driver.FindElement(By.Id("dialog_link_users")).Click();
            driver.FindElement(By.Name("username")).SendKeys("abc1234");
            driver.FindElement(By.Name("first_name")).SendKeys("Himanshu");
            driver.FindElement(By.Name("last_name")).SendKeys("singh");
            driver.FindElement(By.Id("auth_user_email")).SendKeys("Himanshu@gg.gg");
            driver.FindElement(By.Id("auth_user_type"));
            driver.FindElement(By.XPath("//*[@id='auth_user_type']/option[11]")).Click();
            driver.FindElement(By.XPath("//*[@id='usrTypeRols']/option[2]")).Click();
            driver.FindElement(By.XPath("//*[@id='usrTypeRols']/option[2]")).Click();
            driver.FindElement(By.Id("evhc")).SendKeys("n");
            Submit();
        }

        public void Submit()
        {
            if (driver.FindElement(By.Id("recommends")).Displayed)
            {

               
                String demo = "HimanshuDemo";

                demo = demo + i++;
                driver.FindElement(By.Name("username")).Clear();
                driver.FindElement(By.Name("username")).SendKeys(demo);
                Submit();

            }
            else
            {
                try
                {
                    driver.FindElement(By.XPath("//*[@id='rootEle']/body/div[10]/div[3]/div/button[1]")).Click();
                }
                catch (Exception e)
                {
                    driver.FindElement(By.XPath("//*[@id='rootEle']/body/div[11]/div[3]/div/button[1]")).Click();
                }

            }
        }

       
    }
}



        
     

     