﻿using EaFramework.Driver;
using EaFramework.Extensions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EaApplicationTest.Pages
{
    public class ProductPage
    {
        private readonly IDriverFixture _driverFixture;
        public ProductPage(IDriverFixture driverFixture)
        {
            _driverFixture = driverFixture;
        }

        private IWebElement txtName => _driverFixture.Driver.FindElement(By.Name("Name"));
        private IWebElement txtDescription => _driverFixture.Driver.FindElement(By.Id("Description"));
        private IWebElement txtPrice => _driverFixture.Driver.FindElement(By.Id("Price"));
        private IWebElement ddlProductType => _driverFixture.Driver.FindElement(By.Id("ProductType"));
        private IWebElement lnkCreate => _driverFixture.Driver.FindElement(By.LinkText("Create"));
        private IWebElement btnCreate => _driverFixture.Driver.FindElement(By.Id("Create"));

        public void ClickCreateButton() => lnkCreate.Click();

        public void CreateProduct(String name, String description, String price, String productType)
        {
            txtName.SendKeys(name);
            txtDescription.SendKeys(description);
            txtPrice.SendKeys(price);
            ddlProductType.SelectDropDownByText(productType);
            btnCreate.Click();
        }

    }
}
