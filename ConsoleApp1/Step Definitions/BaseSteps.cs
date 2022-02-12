using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using System.Configuration;

namespace WebAutomationFramework.Step_Definitions
{
    [Binding]

    public class BaseSteps
    {
        string BaseUrl = ConfigurationManager.AppSettings["BaseUrl"];
        public static IWebDriver driver = new ChromeDriver();         

        [BeforeScenario]
        public static void BeforeTest()
        {
            //something to set up the user
        }

        [Given(@"I open the URL")]
        public void GivenIOpenTheURL()
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }


        [AfterStep]
        public static void AfterTest()
        {

        }

        [AfterScenario]
        public static void AfterTestRun()
        {
            //something to remove the user
        }
    }
}
