using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using task_DEV_10.PageObjectsLocators;
using System.Collections.Generic;
using System.Linq;

namespace task_DEV_10.PageObjects
{
    /// <summary>
    /// Search result page.
    /// </summary>
    public class SearchResultPage
    {
        IWebDriver driver;
        public SearchResultPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        /// <summary>
        /// Get brand and model cars on page.
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="searchResultPageLocators"></param>
        /// <returns>List of brands and models of cars on page.</returns>
        public IList<IWebElement> GetBrandAndModelOfCarsOnPage(IWebDriver driver, SearchResultPageLocators searchResultPageLocators, WebDriverWait wait)
        {
            return driver.FindElements(searchResultPageLocators.brandAndModelOfCars);
        }

        /// <summary>
        /// Go to next search page.
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="searchResultPageLocators"></param>
        /// <param name="wait"></param>
        public void GoToNextPageOfSearch(IWebDriver driver, SearchResultPageLocators searchResultPageLocators, WebDriverWait wait)
        {
            IWebElement nextPageButton = driver.FindElement(searchResultPageLocators.NextPageButton);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", nextPageButton);
            nextPageButton.Click();
        }

        /// <summary>
        /// Create cars list.
        /// </summary>
        /// <param name="listOfAllCarsModelsOnPage"></param>
        /// <returns>List of cars on page.</returns>
        public List<Car> FillCarsList(IList<IWebElement> listOfAllCarsModelsOnPage)
        {
            List<Car> cars = new List<Car>();
            foreach (IWebElement carModel in listOfAllCarsModelsOnPage)
            {
                cars.Add(new Car(carModel.Text));
            }
            return cars;
        }

        /// <summary>
        /// Is element present on page checker.
        /// </summary>
        /// <param name = "By locator" ></ param >
        /// < returns > False if it is not. True if it is.</returns>
        public bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException e)
            {
                return false;
            }
        }

        /// <summary>
        /// Create a cars list of selected brand from all pages.
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="searchResultPageLocators"></param>
        /// <param name="wait"></param>
        /// /// <param name=""></param>
        /// <returns>List of cars from all pages.</returns>
        public List<Car> GetCarsAllPages(IWebDriver driver, SearchResultPageLocators searchResultPageLocators, WebDriverWait wait)
        {
            List<Car> cars = new List<Car>();
            cars.AddRange(this.FillCarsList(GetBrandAndModelOfCarsOnPage(driver, searchResultPageLocators, wait)));
            while (IsElementPresent(searchResultPageLocators.NextPageButton))
            {
                this.GoToNextPageOfSearch(driver, searchResultPageLocators, wait);
                cars.AddRange(this.FillCarsList(GetBrandAndModelOfCarsOnPage(driver, searchResultPageLocators, wait)));
            }
            return cars;
        }

        /// <summary>
        /// Group and sort list of cars.
        /// </summary>
        /// <param name="cars"></param>
        /// <returns></returns>
        public dynamic SortedCarsList(List<Car> cars)
        {
            var groupedAndSortedCars = (from car in cars
                            group car by car.Model into value
                            select new { value = value.Key, count = value.Count() }).ToList();
            groupedAndSortedCars = groupedAndSortedCars.OrderByDescending(m => m.count).ToList();
            return groupedAndSortedCars;
        }

        /// <summary>
        /// Output grouped and sorted cars.
        /// </summary>
        /// <param name="cars"></param>
        public void OutputSortedCars(dynamic cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine(car.value + ": " + car.count);
            }
        }
    }
}
