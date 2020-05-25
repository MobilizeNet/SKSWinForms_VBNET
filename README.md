# Salmon King Seafood migration tutorial

![SKS](/assets/SKS.PNG)

## VB6 to WinForms VB.NET

### **VBUC** - Visual Basic Upgrade Companion

![](/assets/VBUC-logo.webp)

VBUC is a [Mobilize.net](https://www.mobilize.net/) product capable of VB6 to VB.NET or WinForms migrations. For more information about this product click [here](https://www.mobilize.net/vbuc-free-trial).

To migrate SKS follow the next steps

#### 1. Create a new VBUC project

Start the VBUC desktop app and click the new project icon.

![](/assets//NewProject.PNG)

Next, choose a proper project name and set the source directory where the VB6 project file `SKS.vbp` is located. Then, set the output directory for your migration.

![](/assets//NewProjectSKS.png)

#### 2. Resolve References
Sometimes there might be some unresolved references that the VBUC can not resolve by itself, so they have to be set manually by right clicking it and selecting the option `Set Reference Manually`.

![](/assets//ResolveReferences.PNG)

If you are having a hard time looking for unresolved references, take a look a our [TLB Github Repo](https://github.com/orellabac/TLBRepo.git). The reference you are looking for might be there.

#### 3. Upgrade Options

Choose and confirm the upgrade options for your project. For SKS demo use default options. 

![](/assets//UpgradeOptions.PNG)

#### 4. Upgrade Process

Before starting the upgrade, choose the target `ASP.NET` framework version and choose how you want to include our code helpers in the migrated app, for SKS demo use `.NET framework 4.7` and `Binary Helpers Integration` option.

![](/assets//UpgradeOutput.PNG)

Next, start the migration by clicking `Upgrade Projects` and wait for the process to end.

![](/assets//AfterMigration.PNG)

After the process ends, open your migrated solution and compile your app.

#### 5. Resolve migration conflicts

Finally, move the file `Orders.db` in the SKS_VB6 directory to the `bin` directory in the migration output directory. Also, create an `App.config` in the migrated solution and add the following to it.

``` xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <configSections>
    <section name="AdoFactories" type="UpgradeHelpers.DB.AdoFactoriesConfigurationSection, UpgradeHelpers.DB.Essentials" allowExeDefinition="MachineToApplication" allowLocation="true" />
    <section name="AdoIdentityColumns" type="UpgradeHelpers.DB.AdoIdentityColumnsConfigurationSection, UpgradeHelpers.DB.Essentials" allowExeDefinition="MachineToApplication" allowLocation="true" />
  </configSections>
  <connectionStrings>
  </connectionStrings>
  <AdoFactories>
    <!--
    
    The following section declares some of the most common factories. It can be modified in order to accomplish your needs.
	The factory declaration with the "isdefault" attribute set to true will be used by the upgraded application as the current provider factory.
    
    The database type attribute can take one of the following values
      * SQLServer: when the application interacts wiht Ms SQL Server
      * Oracle: when the application interacts wiht Oracle
      * Access: when the application interacts wiht Ms Access
      * Undefined: when none of the previous is being used
    
    -->
    <Factories>
      <add name="SQLServer" factorytype="System.Data.SqlClient" isdefault="false" databasetype="SQLServer" />
      <!-- MS SQL Server -->
      <add name="Oracle" factorytype="System.Data.OracleClient" isdefault="false" databasetype="Oracle" />
      <!-- Oracle -->
      <add name="Oledb" factorytype="System.Data.OleDb" isdefault="false" databasetype="Access" />
      <!-- Any database through Oledb -->
      <add name="Access" factorytype="System.Data.Odbc" isdefault="true" databasetype="Access" />
      <!-- Any database through ODBC -->
    </Factories>
  </AdoFactories>
  <AdoIdentityColumns>
  </AdoIdentityColumns>
</configuration>
```

This will set the default database driver that the SKS WinForms application will use in run time.

#### 6. Running the migrated app

Run the new WinForms version of SKS.

![](/assets/SKS.png)

## WinForms to Web

### WebMAP

![](/assets/WebMAP.png)

WebMAP is a [Mobilize.net](https://www.mobilize.net/) product capable of migrating WinForms apps to .NET core and Angular. For more information about this product click [here](https://www.mobilize.net/webmap).

#### 1. Prerequisites
 
* Contact [Mobilize.net](https://www.mobilize.net/) to request a WebMAP license required in the migration process.
* Download and install [node.js](https://nodejs.org/en/download/). 
* Run the command  `npm install yarn` to install yarn.
* Install Angular by running the command `npm install -g @angular/cli`.

These steps are required to migrate and install dependencies in your migrated web app.

#### 2. Migration process

Run WebMAP convertion tool using the following command.

```
./Mobilize.WFNetMAP.ConversionTool.exe -i <YourWinFormsSolutionFile.sln> -o <output directory> -l <License Path> --UseProductionNugets
```

#### 3. Installing dependencies

First, add the new dependencies registry by running the following command.

```
npm config set registry https://www.myget.org/F/mobilizewebmap/auth/559d63b6-5f30-45eb-8acb-d5f7cb2858bc/npm/
```

After the registry was added, install Angular dependencies, go to the `sks-angular` folder located inside the migrated app directory and run the following command.

```
yarn
```
This will automatically install all the required dependencies needed for the project. After the installation is finished, run the following command to build the Angular application.

```
ng build --prod
```

#### 4. Running the app

Before compiling and running the app, copy the files `Orders.db` and `App.config` to the migrated app root directory. After doing that just run your fresh new SKS web app.

![SKS Web](/assets/SKSWeb.png)
