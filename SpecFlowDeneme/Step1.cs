using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowDeneme
{
    [Binding]
    public class CalculatorSteps
    {
        private int result { get; set; }
        private Calculator cal = new Calculator();


        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredİntoTheCalculator(int p0)
        {
            Console.WriteLine("Given");
            cal.FirstNumber = p0;
        }
        
        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredİntoTheCalculator(int p0)
        {
            cal.SecondNumber = p0;
        }
       

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = cal.Add();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(p0, result);
        }

    }
}
