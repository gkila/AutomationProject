using AutomationProject.Screens;
using NUnitLite;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationProject;

public class Tests
{
    private IWebDriver driver;
    private GoogleSearchScreen googleSearchScreen;
        
    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
        googleSearchScreen = new GoogleSearchScreen(driver);
    }

    [Test]
    public void Test1()
    {
        googleSearchScreen.Open();
        googleSearchScreen.SearchFor("teste");

    }

    [TearDown]
    public void Teardown()
    {
        driver.Quit();
    }
}