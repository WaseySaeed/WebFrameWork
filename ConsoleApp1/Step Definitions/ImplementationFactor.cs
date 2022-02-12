using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAutomationFramework.Locators;
using TechTalk.SpecFlow;
using WebAutomationFramework.Step_Definitions;

namespace WebAutomationFramework
{
    class ImplementationFactor : BaseSteps
    {
        public void EnterValueInField(string p0, string element)
        {
            driver.FindElement(By.XPath(element)).Clear();
            driver.FindElement(By.XPath(element)).SendKeys(p0);
        }

        public void TapAnElemet(string element)
        {
            driver.FindElement(By.XPath(element)).Click();
        }
    }
}
