# Software_Engineering_HW1
UTCN
Computer Science Department
Software Design 2018

ASSIGNMENT A1
====================================================================
Objective
The objective of this assignment is to allow students to become familiar with layers architectural pattern, repository, services and unit tests.

Application Description
Use JAVA/C# API to design and implement an application for the National Theater of Cluj. The application should have two types of users (a cashier user represented and an administrator) which must provide a username and a password to use the application.
The administrator user can perform the following operations:
CRUD on cashiers’ information.
CRUD on the list of shows that are performed at the theater. Keep track of the Genre (Opera, Ballet), Title, Distribution list (a long string is enough), Date of the show and the Number of tickets per show. 
From time to time he can export all the tickets that were sold for a certain show (e 	ither in a csv or xml file).
The cashier can perform the following operations:
Sell tickets to a show. A ticket should hold information about the seat row and seat number. 
The system should notify the cashier that the number of tickets per show was not exceeded.
A cashier can see all the tickets that were sold for a show, cancel a reservation or edit the seat.

Application Constraints
The data will be stored in a database. 
Use the Layers architectural pattern to organize your application. 
Passwords are encrypted when stored to the database with a one-way encryption algorithm.
Provide unit tests for the number of tickets for show exceeded validation and the encryption algorithm.
Use factory method (not factory) for export to csv/xml.



Requirements
Create the analysis and design document (see the template).
Implement and test the application.

Deliverables
GIT/TFS link with:
Analysis and design document. 
Source files.
SQL script for creating and populating the database with initial values.
Deadline – 2 weeks
