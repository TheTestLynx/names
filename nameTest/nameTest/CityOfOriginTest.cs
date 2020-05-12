using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;


namespace nameTest
{
	[TestClass]
	public class CityOfOriginTest
	{
		FirefoxDriver driver;

		[TestInitialize]
		public void Init()
		{
			driver = new FirefoxDriver();
			driver.Url = @"file:///C:/Users/Noemi/Documents/entrevista/ui-test-assessment-master/employees.html";
		}

		[TestCleanup]
		public void cleanup()
		{
			driver.Close();
			driver.Dispose();
		}

		[TestMethod]
		public void CheckNameIsPresentWhenSelected()
		{
			
			CityOfOriginPage.clickCheckBox(driver, 0);
			CityOfOriginPage.clickViewData(driver);

			String name = CityOfOriginPage.getName(driver, 0);
			String retrievedName = CityOfOriginPage.getViewDataText(driver, 0);

			Assert.IsTrue(retrievedName.Contains(name), "The name " + name + " does not match the contents "+ retrievedName);
			CityOfOriginPage.clickCheckBox(driver, 0);
			CityOfOriginPage.clickViewData(driver);

		}

		[TestMethod]
		public void CheckNameIsNotPresentWhenNotSelected()
		{

			CityOfOriginPage.clickCheckBox(driver, 0);
			CityOfOriginPage.clickCheckBox(driver, 1);
			CityOfOriginPage.clickViewData(driver);

			CityOfOriginPage.clickCheckBox(driver, 0);
			CityOfOriginPage.clickViewData(driver);

			String name = CityOfOriginPage.getName(driver, 0);
			String retrievedName = CityOfOriginPage.getViewDataText(driver, 0);

			Assert.IsFalse(retrievedName.Contains(name), "The name " + name + " does not match the contents " + retrievedName);
			CityOfOriginPage.clickCheckBox(driver, 1);

		}
	}
}
