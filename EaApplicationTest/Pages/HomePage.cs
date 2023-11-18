using EaFramework.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EaApplicationTest.Pages
{
    internal class HomePage
    {   
        private readonly IDriverFixture _driverFixture;

        public HomePage(IDriverFixture driverFixture)
        {
            _driverFixture = driverFixture;
        }

        private IWebElement linkHome => _driverFixture.Driver.FindElement(By.LinkText("Home"));
        private IWebElement linkPrivacy => _driverFixture.Driver.FindElement(By.LinkText("Privacy"));
        private IWebElement linkProduct => _driverFixture.Driver.FindElement(By.LinkText("Product"));

        public void ClickProduct() => linkProduct.Click();

    }
}
