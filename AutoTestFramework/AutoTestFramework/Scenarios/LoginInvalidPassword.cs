using FirstLesson;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestFramework.Scenarios
{
    internal class LoginInvalidPassword
    {
        IAlert alert;

        public LoginInvalidPassword()
        {

        }

        [SetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void RepeatedPasswordDoNotMatch()
        {
            NavigateTo.LoginFormThroughTheMenu();
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Invalid.Password.InvalidPassword, Config.Credentials.Valid.RepeatPassword);

            alert = Driver.driver.SwitchTo().Alert();
            Assert.That(Config.AlertMessages.PasswordDoNotMatch, Is.EqualTo(alert.Text));

            alert.Accept();
        }

        [TearDown]
        public void Cleanup()
        {
            Driver.driver.Close();
        }
    }
}
