using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebAutomationFramework.Step_Definitions;

namespace WebAutomationFramework 
{
    [Binding]

    class DemoSD : BaseSteps
    {
        ImplementationFactor obj1 = new ImplementationFactor();
      
        [When(@"I input text """"(.*)""""")]
        public void WhenIInputTextInTheGivenField(string p0,string element)
        {
            obj1.EnterValueInField(p0,element);
        }


        [When(@"I click ""(.*)""")]
        public void WhenIClick(string element)
        {
            obj1.TapAnElemet(element);
        }
   

        // Radio Button

        // DropDown

        // Navigate back

        // Switch to next tab

        // Handling pop up

        // upload file

    }
}
