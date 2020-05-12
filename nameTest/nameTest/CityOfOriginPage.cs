using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace nameTest
{
	class CityOfOriginPage
	{

		public static void clickCheckBox(FirefoxDriver driver, int num)
		{
			IWebElement checkBox = driver.FindElementByCssSelector("span.jqx-tree-grid-checkbox:nth-child("+(num+2)+")");
			checkBox.Click();
		}

		public static void clickViewData(FirefoxDriver driver)
		{
			IWebElement viewData = driver.FindElementById("btn");
			viewData.Click();
		}

		public static String getName(FirefoxDriver driver, int num)
		{
			IWebElement nameBox = driver.FindElementByCssSelector("span.jqx-tree-grid-title:nth-child("+(num+3)+")");
			return nameBox.Text;
		}

		public static String getViewDataText(FirefoxDriver driver, int num)
		{
			IWebElement viewDataText = driver.FindElementByXPath("//*[@id=\"listitem"+num+"listBoxSelected\"]");
			return viewDataText.Text;
		}
	}
}
