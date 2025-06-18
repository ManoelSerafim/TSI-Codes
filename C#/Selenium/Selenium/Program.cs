using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Selenium
{

    class Program
    {
        static void Main(string[] args)
        {
            // Cria uma instância do Chrome  
            ChromeDriver driver = null;
            try
            {
                driver = new ChromeDriver();

                // Acessa uma URL  
                driver.Navigate().GoToUrl("https://www.google.com");
                String url = driver.Url;
                Console.WriteLine("Acessando a URL: " + url);

                // Encontra a barra de busca  
                var searchBox = driver.FindElement(By.Name("q"));
                searchBox.SendKeys("Cauã é gay?");
                searchBox.Submit();

                // Aguarda alguns segundos para ver o resultado  
                Thread.Sleep(5000);
            }
            finally
            {
                // Fecha o navegador  
               // driver?.Quit();
            }
        }
    }
}

