using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;

namespace AppiumTests
{
    public class AppTest
    {
        private AndroidDriver<AndroidElement> driver;

        [OneTimeSetUp]
        public void Setup()
        {
            var appiumOptions = new AppiumOptions();
            //appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            //appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "9.0");
            //appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Xiaomi MI 8 Lite");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.Udid, "7c3e209b");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.App, @"C:\Users\nymka\Downloads\royal_gold(0.1.2252).apk");
            //appiumOptions.AddAdditionalCapability(MobileCapabilityType.AutomationName, "UiAutomator2");

            driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), appiumOptions);

            //driver.LaunchApp();
        }

        [Test]
        public void SampleTest()
        {
            // Пример теста
            Assert.NotNull(driver);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver?.Quit();
        }
    }
}
