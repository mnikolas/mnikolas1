using mnikolas.Selenium.IE;
using mnikolas.Selenium.Firefox;
using mnikolas.Selenium;

namespace TestSelenium
{
	class Program
	{
		static void Main(string[] args)
		{
			var driver = new ChromeDriver(@"C:\Libraries\");	
			driver.navigate().GoToUrl("http://www.google.com")
			var query = driver.FindElement(By.Name("q"));
			query.Sendkeys("Selenide");
			query.Submit();
			//driver.Close();
		}
	}
}
 
