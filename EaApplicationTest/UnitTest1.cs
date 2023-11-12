using EaApplicationTest.Pages;
using EaFramework.Config;
using EaFramework.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EaApplicationTest
{
    public class UnitTest1 : IDisposable
    {

        private IDriverFixture _driverFixture;

        public UnitTest1()
        {
            var testSettings = new TestSettings()
            {
                BrowserType = BrowserType.Chrome,
                ApplicationUrl = new Uri("http://localhost:33084/"),
                TimeoutInterval = 30
            };

            _driverFixture = new DriverFixture(testSettings);
        
        }

        [Fact]
        public void Test1()
        {
            //HomePage
            var homePage = new HomePage(_driverFixture);
            var productPage = new ProductPage(_driverFixture);

            //Click the Create Link
            homePage.ClickProduct();

            //Create Product
            productPage.ClickCreateButton();
            productPage.CreateProduct("FirstProduct","description of product","200","MONITOR");

        }

        public void Dispose()
        {
            _driverFixture.Driver.Quit();
        }
    }
}