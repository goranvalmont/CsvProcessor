CSVProcessor

This is the application to read and write the data from CSV files.


CsvProcessor.BL
- this is the main business logic library 
- CsvBase is a base class that contains ConvertToCsv and ConvertFromCsv functions 
	> functions use reflection to find the properties of an object and write/read the values from them
- Models folder contains couple of test classes Bank, Account, Transaction
	> all three inherit from CsvBase class and can be converted/read from CSV file
- CsvHelper is a helper class to read/write the data from and to a file

CsvProcessorClient
- simple console application to consume the main logic
- TestData folder is the drop folder for the CSV fles
- TestDataFactory is a folder where I'm creating test data for saving.

 

 TO run the application:
 1. Set CsvConsoleClient as start up project
 2. In Program.cs change the following value to appropriate location (leave \ at the end) :
  string testDataFolderPath = @"C:\ProjectsRepos\CsvProcessor\CsvProcessorClient\TestData\";
