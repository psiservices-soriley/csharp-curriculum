using NUnit.Framework;
using OpenQA.Selenium;
using Psi.AutomationFramework.Categorization;
using Psi.AutomationFramework.Common;
using Psi.AutomationFramework.Tests;
using SampleAutomation.Pages;

namespace SampleAutomation;

public class GoogleSearchTests : BaseTest
{
    [Test]
    [TestCaseId(1)]
    public void CanSearch()
    {
        WebDriver.NavigateToUrl("http://google.com");

        var searchPage = new GoogleSearchPage();
        searchPage.SearchInput.EnterValue("books");

        WebDriver.FindElement(By.TagName("body")).WaitAndClick();

        searchPage.SearchButton.WaitAndClick();
        WaitFor(() => searchPage.ResultLinks.Count > 0);

        Assert.That(searchPage.ResultLinks.Count, Is.GreaterThan(0));
    }
}