**Nainstalovat do PC:**

.NET 7.0 nebo 6.0 s dlouhou podporou

Visual Studio Code

nebo 

Visual Studio 2022 - pouze WIN a MacOS



**Potřebná rozšíření ve VS Code:**

.NET Extension Pack

C#

Nuget Package Manager



**Postup vs code:**


Založení nového projektu ve Visual Studio Code:

dotnet new mstest -n MyTestProject 


**Stažení Selenia** (stahne potřebý základ): v terminálu musíme do složky projektu co vytvořila dotnet new mstest

dotnet add package Selenium.WebDriver

**Test se spustí:**

dotnet test

nebo za pomocí 

dotnet watch který sám automaticky sleduje změny v kódu a je schopný spustit testy

Tento návod funguje jak pod Linux (odzkoušené v distribucích EndeavorOS, Ubuntu 22.04), MacOS, Windows 11.

Z důvodu kompaktibility jseou je na GitHub pouze samotný kód testu. Ostatní soubory a složky se vytvoří po založení projektu.

Složka TestResults také není součásti verze GitHub.


**Hints:**

 klik na tlačítko

        IWebElement tlačítko<nastavení proměnné> = driver.FindElement(By.Id("xPath tlačítka"));
        tlačítko.Click();



        expectedTitle = "O mně - Lukáš bloguje"; 

        actualTitle = driver.Title;

        Assert.AreEqual(expectedTitle, actualTitle, "Title does not match");

        