using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome; 
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace YourProjectNamespace
{
    [Binding]
    public class LoginSteps
    {
        private IWebDriver driver;
        private LoginPage loginPage;

        public LoginSteps()
        {
            // ���������� ������� � �����������
            driver = new ChromeDriver(); // �� ������ ������� ����� ������� �� ��������
            loginPage = new LoginPage(driver);
        }

        [Given(@"I am on the banking website")]
        public void GivenIAmOnTheBankingWebsite()
        {
            loginPage.OpenLoginPage("https://www.globalsqa.com/angularJs-protractor/BankingProject"); // ������ URL �� �������� URL ������ ���-�����
        }

        [When(@"I select ""Login as User"" option")]
        public void WhenISelectLoginAsUserOption()
        {
            loginPage.ClickLoginAsUser();
        }

        [When(@"I select ""Hermoine Granger"" as a customer")]

        public void WhenISelectHarryPotter() {
            loginPage.SelectCustomer("Hermoine Granger");
        }

        [When(@"I click Login button")]

        public void WhenIClickLoginButton()
        {
            loginPage.ClickLogin();
        }

        [Then(@"I should be on the bank's home page")]
        public void ThenIShouldSeeTheMainDivBlock()
        {
            bool isMainDivVisible = loginPage.IsWelcomeTextVisible();
            Assert.IsTrue(isMainDivVisible, "The 'mainBox' block is not visible.");
        }

        [When(@"I click the Withdrawl button")]

        public void WhenIClickWithdraw()
        {
            loginPage.OpenWithdrawMenu();
        }

        [When(@"I enter the withdrawal amount as full sum / 2")]
        public void EnterAmount()
        {
            loginPage.EnterAmount();
        }

        [When(@"I click the ""Confirm Withdrawal"" button")]
        public void ConfirmWithdraw()
        {
            loginPage.ClickWithdraw();
        }

      

        public void EnterMoreAmount()
        {
            loginPage.EnterMoreAmount();
        }

        [When(@"I click the ""Confirm Withdrawal"" button again")]


        [Then(@"I should close Chrome")]
        public void CloseChrome()
        {
            loginPage.CloseDriver();
        }
    }
}
