﻿// <copyright file="BingTests.cs" company="Automate The Planet Ltd.">
// Copyright 2017 Automate The Planet Ltd.
// Licensed under the Apache License, Version 2.0 (the "License");
// You may not use this file except in compliance with the License.
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <author>Anton Angelov</author>
// <site>http://automatetheplanet.com/</site>
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebDriverCsharpSeven.DigitSeparators
{
    [TestClass]
    public class BingTests
    {
        private IWebDriver driver;

        [TestInitialize]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            // Prior C# 7.0
            ////driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(30000);
            // C# 7.0
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30_000);
        }

        [TestCleanup]
        public void TeardownTest()
        {
            this.driver.Quit();
        }

        [TestMethod]
        public void SearchTextInBing_First()
        {
            var bingMainPage = new BingMainPage(driver);
            bingMainPage.Navigate();
            bingMainPage.Search("Automate The Planet");
            // Prior C# 7.0
            ////bingMainPage.AssertResultsCount(236000);
            // C# 7.0
            bingMainPage.AssertResultsCount(236_000);
        }
    }
}
