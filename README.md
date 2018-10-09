# MySql8_NetConnector8
this is a complete sample for configuring the MySQL Connector/NET 8.0 
the sample example provided in MySQL Documentation URL "https://dev.mysql.com/doc/connector-net/en/connector-net-entityframework60.html" is  INVALID as the below
 <br/> 1-	NET Connector 8 use different libraries files “MySql.Data.EntityFramework ” instead of “MySql.Data.Entity.EF6 “
  <br/> 2-	NET Connector 8 use MySQL Data Provider with different assembly version”8.0.12” from the one registered in Visual studio ID assemblies “8.0.10”
  <br/>  3-	The MySql.Data.Entity NuGet package use the old assemblies and the old assemblies versions check the above points

<h2>Prerequisites</h2>
To support the NoSql features you must use the below 
  <br/>1-	Connector/NET 8.0.x
  <br/>2-	MySQL Server 8.0.12
<h2>Steps</h2>
  <br/>1-	Add the below assemblies manually to the solution reference 
  <br/>&nbsp;&nbsp; a.	MySql.Data.dll from the connector setup folder make sure its version “8.0.12.0”
  <br/>&nbsp;&nbsp; b.	MySql.Data.EntityFramework.dll from the connector setup folder make sure its version “8.0.12.0”
  <br/>2-	Change the configurations files ‘app.config ‘ to be like the sample code

3-	Add the model normally exactly like the SQL but use the data provider “.NET frame work data provider for mysql” and data source “mysql database”

