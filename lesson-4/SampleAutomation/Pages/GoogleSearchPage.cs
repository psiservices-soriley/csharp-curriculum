using System.Collections.Generic;
using OpenQA.Selenium;
using Psi.AutomationFramework.Pages;

namespace SampleAutomation.Pages;

public class GoogleSearchPage : BasePage
{
    [FindsBy(How = How.CssSelector, Using = "form[action='/search'] input[aria-label='Search']")]
    public IWebElement SearchInput { get; set; }

    [FindsBy(How = How.CssSelector, Using = ".FPdoLc input[value='Google Search']")]
    public IWebElement SearchButton { get; set; }

    [FindsBy(How = How.XPath, Using = "//div[@class='g']//a[1]")]
    public IList<IWebElement> ResultLinks { get; set; }
}