Web Scraping with HtmlAgilityPack and CsvHelper
This C# application showcases a simple web scraper designed to extract information from a static website. Using the HtmlAgilityPack library, the code targets the Twitter website (https://twitter.com/i/api/1.1/jot/ces/p2) and retrieves a specific paragraph's content. The extracted data, representing the description, is then saved to a CSV file ("pokemon-products.csv") using the CsvHelper library.

Features
Utilizes HtmlAgilityPack for HTML parsing and node selection.
Demonstrates a simple XPath query to locate specific content within the HTML structure.
Outputs the extracted information to the console.
Writes the extracted data to a CSV file using CsvHelper.
How to Use
Clone or download the repository.
Ensure the HtmlAgilityPack and CsvHelper libraries are installed in your project.
Build and run the application.
View the extracted description on the console and find the CSV file ("pokemon-products.csv") in the project directory.
