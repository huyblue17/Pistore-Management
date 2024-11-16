# Pi-Store Management System

## Description

This Windows Forms application uses Entity Framework to manage a store. It provides CRUD (Create, Read, Update, Delete) functionalities for managing clients, employees, and orders. Additionally, it allows exporting bills.

## Features

-   Manage Clients: Add, view, update, search and delete client information.
-   Manage Employees: Add, view, update, search and delete employee information.
-   Manage Products: Add, view, update, search and delete product information.
-   Manage Orders: Create, view, update, search and delete orders.
-   Export Bills: Generate and export bills for orders.
-   Overview the total incomes of the store.
-   Show total products have been sold.

## Technologies

-   Windows Forms
-   Entity Framework
-   C#
-   SQL Server

## Installation

1. Unzip the file name "midterm-project"
2. Open the "PiStoreManage.sql" to run the database.
3. Open the the file name "PiStoreManageMent.sln"
4. Login in the application with acount and password, both "admin".
5. Using the application.

## How to uses

There are 7 main functions in the application

1. Dashboard:

    - Show total of employees, clients, bills, and products.
    - Next page, there are 2 chart: Columns chart - Total incomes (daily, weekly, yearly) and Pie chart - Total sold products.

2. Employee:

    - CRUD functions with name, phonenumber, mail, address, salary and hiredate.
    - ID is auto generated.
    - Search the employee by name or ID.

3. Client:

    - CRUD functions with name, phonenumber, mail, address.
    - ID is auto generated.
    - Search the client by name or ID.

4. Product:

    - CRUD functions with name, description, quantity, price.
    - ID is auto generated.
    - Search the product by name or ID.

5. Order:

    - CRUD functions employee ID, client ID, create date.
    - ID is auto generated.
    - Search the order by ID.

6. OrderItems:

    - CRUD functions by select product and put it into order with quantity and update the total prices.
    - ID is auto generated.

7. Bill:

    - View all bills when finish created orders.
    - Export the bill with a pdf format.

## Warning

There still some missing error that i couldn't handle. Hope you enjoy the application!
