﻿using OpenQA.Selenium;

namespace EaFramework.Driver
{
    public interface IDriverFixture
    {
        IWebDriver Driver { get; }
    }
}