using FirstLesson;
using NUnit.Framework;
using OpenQA.Selenium;


namespace AutoTestFramework.Scenarios
{
    public class LoginValidUsername
    {
        IAlert alert;
        public LoginValidUsername() 
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void ValidLogin()
        {
            NavigateTo.LoginFormThroughTheMenu();
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);

            alert = Driver.driver.SwitchTo().Alert();
            Assert.That(Config.AlertMessages.SuccessfulLogin, Is.EqualTo(alert.Text));

            alert.Accept();
        }

        [OneTimeTearDown]
        public void Cleanup()
        {
            Driver.driver.Quit();
        }
    }
}
