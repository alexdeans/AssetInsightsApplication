Step 1 : Download and Install Microsoft SQL Server 2019

Step 2 : Download and Install SQL Server Management Studio

Step 3 : Download Visual Studio 2019

Step 3 : Connect to the SSMS SQL server 
	 server name 
	 Browse for more
	 Local servers 
	 Database engine
	 (choose local device) 
	 connect 

Step 4 : Right click database file 
	 Import Data-Tier Application
	 Next 
	 Import .bacpac file location 
	 Next 
	 Next 
	 Finish

Step 4 : Launch Visual Studio 2019
	 Tools
	 Connect to Database
	 Insert server name: (same as SSMS server name) 
	 Select or enter a database name: (Database Export) 
	 Ok

Step 5 : Open Server Explorer
	 Right click .dbo data connection
	 Properties
	 Copy Connection String 
	 Open appsettings.json file
	 Replace the old AssetInsightsDB connection string with the new one
	 Save 

Step 6 : Run application (IIS Express) 


