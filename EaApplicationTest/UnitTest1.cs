using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EaApplicationTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:33084/");

            driver.FindElement(By.LinkText("Product")).Click();

            driver.FindElement(By.LinkText("Create")).Click();

        }
    }
}