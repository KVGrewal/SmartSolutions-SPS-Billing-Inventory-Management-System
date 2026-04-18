🧾 SmartSolutions SPS — Billing & Inventory Management System

A desktop-based Billing and Inventory Management System built with C# .NET Windows Forms and Microsoft SQL Server. Designed for small businesses to manage sales, purchases, customers, inventory, and generate GST-compliant bills with detailed RDLC reports.

✨ Features 🔐 Login & Authentication — Secure login with stored procedure credential check 🏠 Dashboard — Make new sales transactions with product/customer selection

👥 Party / Customer Management Add, update, and delete customers View all parties with live search across all columns and refresh Inline grid editing with duplicate-name protection

🛒 Sales Management Record multi-item GST sales transactions View all sales — filter: All / Fully Paid / Pending Payment Add payments with date picker; view full payment history Generate & print GST bills (Original / Duplicate via billed_status) Print consolidated sales reports (RDLC)

📦 Purchase Management Add new purchases with opening/closing stock tracking View all purchases; add payments; view payment history

🗃️ Inventory / Products Add products with HSN code, brand, GST slab, and initial stock Manage and update stock levels View product catalog with DataSet binding

📊 Statistics Dashboard To Collect — total outstanding receivables (green) To Pay — total outstanding payables (red) Tax to Pay — GST liability summary Browse sales with radio filter: All / Paid / Unpaid

🖨️ Bill Generation Itemised bills with taxable amount, CGST, SGST, and totals Original vs Duplicate bill status Date-parameterised RDLC ReportViewer

🛠️ Tech Stack Layer Technology Language C# (.NET Framework 4.5) UI Framework Windows Forms (WinForms) Database Microsoft SQL Server (named instance) Data Access Microsoft SqlHelper (DAAB) + Typed DataSets Reporting Microsoft RDLC / ReportViewer (WinForms) ORM / Packages Entity Framework 5.0.0 (NuGet) IDE Visual Studio 2019 / 2022

📁 Project Structure

SmartSolutionsSPS/
│
├── Forms/
│   ├── Login.cs / .Designer.cs           # Login (calls getCredentials SP)
│   ├── MainForm.cs / .Designer.cs        # Shell — left nav, child form loader
│   ├── Dashboard.cs                      # New sale — product/customer picker
│   ├── ADD_PARTY.cs                      # Add customer (calls addCustomer SP)
│   ├── VIEW_PARTIES.cs                   # View/search/edit/delete customers
│   ├── VIEW_SALES.cs                     # Sales dashboard — filter/pay/bill
│   ├── VIEW_PURCHASES.cs                 # Purchase dashboard — pay/history
│   ├── Add_Purchases.cs                  # Add new purchase entry
│   ├── INVENTORY.cs                      # Stock management
│   ├── AddProduct.cs                     # Add product (HSN, brand, GST, stock)
│   ├── SHOW.cs                           # Product grid (SSDataSet bound)
│   ├── Bill.cs                           # RDLC bill viewer with date param
│   ├── Statistics.cs                     # To collect / to pay / tax summary
│   └── SalesReport.cs                    # Consolidated sales RDLC report
│
├── Business Logic (Classes)/
│   ├── clsAddCustomer.cs                 # Add customer via addCustomer SP
│   ├── clsPARTIES.cs                     # Show / remove / update customers
│   ├── clsOrder.cs                       # Order line-item: GST calc (CGST+SGST)
│   ├── clsDashboard.cs                   # Fill combos, customer lookup, products
│   ├── clsSales.cs                       # Sales CRUD + payments + bill data
│   ├── clsPurchases.cs                   # Purchases CRUD + payments
│   ├── clsStatistics.cs                  # getToCollect / getToPay / getTax
│   ├── clsProduct.cs                     # Product add/remove/stock update
│   ├── clsProcedures.cs                  # Central registry of all SP names
│   ├── ConnClass.cs                      # Connection string provider
│   └── SqlHelper.cs                      # Microsoft DAAB (sync + async)
│
├── DataSets/
│   ├── SSDataSet.xsd / .cs               # Typed DataSet → tbl_product
│   ├── SSDataSet1.xsd / .cs              # Secondary typed DataSet
│   ├── SalesDataSet.xsd / .cs            # Typed DataSet for bill generation
│   └── DataSet1.cs                       # DataTable1 for RDLC report binding
│
├── Reports/
│   ├── Report1.rdlc                      # Sales summary report
│   ├── Report2.rdlc                      # GST bill report (used by Bill.cs)
│   └── specificSale.rdlc                 # Individual sale bill layout
│
├── database/                             # ← Run these SQL scripts manually in SSMS
│   ├── script_tables.sql                 # Creates all tables
│   ├── script_datatype.sql               # Creates user-defined table types
│   ├── script_procedures.sql             # Creates all stored procedures
│   └── script_user.sql                   # Creates DB users (optional)
│
├── App.config                            # ← Edit this with your connection string
├── Program.cs                            # Entry point (STAThread → MainForm)
├── packages.config                       # NuGet: EntityFramework 5.0.0
└── SmartSolutionsSPS.sln                 # Visual Studio solution
⚠️ Important — Read Before Setting Up

This application does NOT set up the database automatically. Everything must be done manually before running the app for the first time. The application only works after you have:

Installed Microsoft SQL Server
Created the database manually in SSMS
Run all the provided SQL scripts
Pasted the correct connection string into App.config and 'Connclass.cs'
Skipping any of these steps will cause the application to crash or show blank data.

⚙️ Step-by-Step Setup Guide Step 1 — Install the Required Software Install all of the following on your Windows machine before doing anything else: Software Download Link Microsoft SQL Server (Express is free) https://www.microsoft.com/en-us/sql-server/sql-server-downloads SQL Server Management Studio (SSMS) https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms Visual Studio 2019 or 2022 https://visualstudio.microsoft.com/ .NET Framework 4.5 https://dotnet.microsoft.com/en-us/download/dotnet-framework Microsoft ReportViewer Runtime Required for RDLC bill printing — search "Microsoft ReportViewer 2015 Runtime"

Step 2 — Create the Database in SSMS Open SQL Server Management Studio (SSMS) Connect to your SQL Server instance In the top toolbar, click New Query Run this to create the database:

   CREATE DATABASE sample1;
Click Execute (or press F5)
Step 3 — Run the SQL Scripts (in this exact order) Still inside SSMS, open and execute each script one by one in the order listed below. You can open a script by going to File → Open → File and selecting the .sql file from the database/ folder. Run in this order: Order File What it does 1 script_tables.sql Creates all 11 tables 2 script_datatype.sql Creates user-defined table types needed by stored procedures 3 script_procedures.sql Creates all stored procedures the app depends on 4 script_user.sql Creates the DB users (run this only if using the default login)

How to run a script in SSMS: Open the file → make sure the database is set to sample1 in the dropdown at the top → click Execute.

Step 4 — Create a SQL Server Login The app uses SQL Server Authentication (username + password), not Windows Authentication. You need to create a login manually. In SSMS, open a New Query window Run the following:

-- Create the login at the server level
CREATE LOGIN [SSUser1] WITH PASSWORD = 'YourPasswordHere';

-- Switch to the app database
USE [sample1];

-- Create a user for that login
CREATE USER [SSUser1] FOR LOGIN [SSUser1] WITH DEFAULT_SCHEMA = [dbo];

-- Give it full access
ALTER ROLE [db_owner] ADD MEMBER [SSUser1];
Also make sure SQL Server Authentication is enabled on your instance: In SSMS, right-click your server → Properties → Security Select SQL Server and Windows Authentication mode Click OK, then restart the SQL Server service

Step 5 — Find Your Server Name You need your exact SQL Server instance name for the connection string. Open SSMS → the name shown in the Connect to Server dialog is your server name It usually looks like: DESKTOP-XXXXX\SQLEXPRESS or DESKTOP-XXXXX\MSSQLSERVER Copy this name — you will need it in the next step

Step 6 — Update the Connection String in App.config Open the project folder and find App.config Open it with any text editor (Notepad, VS Code, or Visual Studio) Find the <connectionStrings> section and replace the existing values:

<connectionStrings>

  <add name="SmartSolutionsSPS.Properties.Settings.startersqlConnectionString"
       connectionString="Data Source=YOUR_SERVER_NAME\YOUR_INSTANCE;Initial Catalog=sample1;User Id=SSUser1;Password=YourPasswordHere;"
       providerName="System.Data.SqlClient" />

  <add name="SmartSolutionsSPS.Properties.Settings.SSConnectionString"
       connectionString="Data Source=YOUR_SERVER_NAME\YOUR_INSTANCE;Initial Catalog=sample1;User Id=SSUser1;Password=YourPasswordHere;"
       providerName="System.Data.SqlClient" />

  <add name="SSEntities"
       connectionString="metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=YOUR_SERVER_NAME\YOUR_INSTANCE;Initial Catalog=sample1;User Id=SSUser1;Password=YourPasswordHere;MultipleActiveResultSets=True;App=EntityFramework&quot;"
       providerName="System.Data.EntityClient" />

</connectionStrings>
Replace: YOUR_SERVER_NAME\YOUR_INSTANCE → your actual server name from Step 5 YourPasswordHere → the password you set in Step 4

Example: If your server name is DESKTOP-ABC123\SQLEXPRESS and password is Admin@1234, the connection string would be: Data Source=DESKTOP-ABC123\SQLEXPRESS;Initial Catalog=sample1;User Id=SSUser1;Password=Admin@1234;

Step 7 — Build and Run Open SmartSolutionsSPS.sln in Visual Studio Right-click the Solution in Solution Explorer → Restore NuGet Packages Press Ctrl + Shift + B to Build Press F5 to Run If the connection string is correct and all scripts were run successfully, the application will open on the MainForm home screen.

🗄️ Database Schema Reference

Database name: sample1 Tables Table Key Columns tbl_customer customer_id (PK), customer_name, customer_address tbl_product product_id (PK), product_name, brand, hscin_no, available_stock, price tbl_HSCIN hscin_id (PK), gst_rate tbl_transaction sales_id (PK), taxable_amt, cgst, sgst, amount, paid_amt, DOP, billed_status, customer_id tbl_orders sales_id, product_id, hscin_id, gst_slab, quantity, price, taxable_amt, cgst, sgst, amount tbl_payments sales_id, customer_id, amount_paid, date_of_payment tbl_nonSavedCustomer sales_id, customer_name, customer_address tbl_purchase bill_no (PK), product_id, quantity, opening_stock, final_stock, supplier_name, price, taxable_amt, tax, total_amt, paid_amt tbl_purchaseDetails bill_no, product_id, quantity, price, taxable_amt, tax, total_amt tbl_purchasePayments bill_no, amount_paid, date_of_payment tbl_users username, pass User-Defined Table Types Type Used For sales_entries Passing multiple sale line items to saveSale SP purchase_list Passing multiple purchase line items to addPurchase SP UserList General user ID list GST Calculation Logic

Taxable Amount  = Price × Quantity
CGST = SGST     = (Taxable Amount × GST%) / 200
Total Tax       = CGST + SGST
Final Amount    = Taxable Amount + CGST + SGST
🤝 Contributing Pull requests are welcome. For major changes, please open an issue first.

📄 License This project is licensed under the MIT License.

👤 Author Name : Anuj Kumar Panchal GitHub:https://github.com/anujpanchal073-sudo Name : Kuwar Vishesh Grewal GitHub:https://github.com/KVGrewal

Built with ❤️ using C# Windows Forms & Microsoft SQL Server
