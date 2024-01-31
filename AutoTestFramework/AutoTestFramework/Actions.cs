using AutoTestFramework.Pages;
using FirstLesson;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestFramework
{
    public static class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.BasicURL);
        }
        public static void FillLoginForm(string username, string password, string repeatPassword)
        {
            LoginScenarioPost lsPost = new LoginScenarioPost();
            lsPost.UsernameField.Clear();
            lsPost.PasswordField.Clear();
            lsPost.RepeatPasswordField.Clear();
            
            
            lsPost.UsernameField.SendKeys(username);
            
            lsPost.PasswordField.SendKeys(password);
           
            lsPost.RepeatPasswordField.SendKeys(repeatPassword);
            
            lsPost.LoginButton.Click();
        }
    }
}
