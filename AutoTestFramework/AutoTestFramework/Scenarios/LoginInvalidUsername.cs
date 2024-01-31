

using FirstLesson;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutoTestFramework.Scenarios
{
   
    public class LoginInvalidUsername
    {
        IAlert alert;

        public LoginInvalidUsername()
        {

        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void LessThan5Characters()
        {
            NavigateTo.LoginFormThroughTheMenu();
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.FourCharacters, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);

            alert = Driver.driver.SwitchTo().Alert();
            Assert.That(Config.AlertMessages.InvalidUsername, Is.EqualTo(alert.Text));

            alert.Accept();
        }

        [Test]
        public void MoreThan12Characters()
        {
            NavigateTo.LoginFormThroughTheMenu();
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.ThirteenCharacters, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);

            alert = Driver.driver.SwitchTo().Alert();
            Assert.That(Config.AlertMessages.InvalidUsername, Is.EqualTo(alert.Text));

            alert.Accept();
        }

        [OneTimeTearDown]
        public void Cleanup()
        {
            Driver.driver.Close();
        }
    }
}
