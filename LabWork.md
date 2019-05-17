# Lab Work

## Contents


- [Lab Work](#lab-work)
	- [Quizzes](#quizzes)
		- [C# Technical Quiz](#c-technical-quiz)
		- [Interview Quiz](#interview-quiz)
	- [Quiz Questions](#quiz-questions)
	- [C# Data Types](#c-data-types)
	- [C# Operators](#c-operators)
	- [C# Loops](#c-loops)
	- [Codewars](#codewars)
	- [SQL Lab Work](#sql-lab-work)
		- [SQL Exam Answer Verification Application](#sql-exam-answer-verification-application)
	- [OOP Lab Work](#oop-lab-work)
		- [Rabbit Population Explosion](#rabbit-population-explosion)
		- [Goal For Today](#goal-for-today)
		- [Graph Of Rabbit Population Produced As A CSV file](#graph-of-rabbit-population-produced-as-a-csv-file)
		- [Running Microsoft Excel To Display This File Automatically](#running-microsoft-excel-to-display-this-file-automatically)
		- [Controlling The Population With Rabbit Death](#controlling-the-population-with-rabbit-death)
		- [Rabbit Population Explosion With Foxes Reducing The Population Growth](#rabbit-population-explosion-with-foxes-reducing-the-population-growth)
		- [Setting Random Rabbit Properties](#setting-random-rabbit-properties)
	- [HW_LAB_104 WPF Application Using Entity And Northwind](#hw_lab_104-wpf-application-using-entity-and-northwind)

## Quizzes

### C# Technical Quiz

40-question test on Proprofs - please complete and submit the score and if it's below 90% please repeat until you can obtain a 90% score and let me know how long each test took also.

### Interview Quiz

This has a mix of interview and basic C#, OOP, Agile and SQL questions to help you prepare for an interview.

https://www.proprofs.com/survey/t/?title=interview-thoughts-and-prep-c-agile-sql-oop-covered

## Quiz Questions

What is a method return type?

What is a method parameter?

What is Pascal Case?

What is Camel Case?

What is Snake Case?

What is Kebab Case?

What is an 'out' parameter?

What does 'passing by reference' mean?

What is a reference type?

What is a value type?

What is the Heap?

What is the Stack?


 


OOP

What is a constructor?

When do we use the 'new' keyword?

What is instantiation?

What is an instance?

Can we instantiate an abstract class?

Can we instantiate a sealed class?

What is NUNIT?

What is Entity Framework?

What is CRUD?

What does Try..Catch..Finally.. do?

What is a coding error?

What is an Exception?

Give some examples of System Exception types


 


Can you create a github repo?  Write down about 10 things that you would do in order to create a master branch, then a dev branch, then push to the dev branch, then create a pull request to pull the dev branch into the master branch


 


How would you view all your commits on a local system?


 


What does git reset do?  hard? soft?


 


What does HTTPS SSL encryption do to our web pages?

What is SSH?  How does it secure our web communications?


 


What does SQL distinct do?

What does SQL LIKE search for?
 
What would SQL "LIKE '%a%' " find?  

What would SQL "LIKE 'a%' " find?  

What would SQL "LIKE '%a' " find?  


## C# Data Types

Code out an array

Code out a 2D array

## C# Operators

Code out x++ and ++x - what is the difference?  Display this in code.

## C# Loops

Code out a loop with the `break` keyword

Code out a loop with the `continue` keyword

Code out a `switch` statement

## Codewars

In any spare time, level up with Code Wars.  Let this be an excellent teacher for your raw C# learning as the beauty of this website is that once you have `cracked` a solution then all of the other ways that other people have `cracked` it will become visible to you, so you can learn from other programmers.

## SQL Lab Work

### SQL Exam Answer Verification Application

Create a console app with an NUnit test which can test the predicted output of the first SQL question in the SQL quiz.  The app runs and asks for the SQL input which is pasted into the screen, then the user is informed if the code is correct or not.  Stretch exercise - can we repeat the same thing using WPF app with text blocks where the SQL code is placed inside a text block, then a button is pressed to determine if the answer is correct or not.

## OOP Lab Work

### Rabbit Population Explosion

Population Explosion Project For Today

We are going to build together a population explosion app with Rabbits!!!

Every second a rabbit will spawn exactly one other rabbit, so one will become two, two will become four etc.

I would like you to create a test which will test that after x seconds we expect y rabbits, and firstly create the test (TDD).

Then code against it to solve the puzzle.

Note that I am not just looking for integers to be multiplied; I would actually like rabbit objects to be created and added to a collection of rabbits, say a list for example.

The goal would be to create the test with NUNIT then code this out firstly in a console app, then also a WPF app, then possibly as a 'stretch' exercise to code this as a web application starting out with straightforward 'Web Forms' app (not MVC at present)

You can also set an upper population limit and test how long it will take to reach this population limit!

### Goal For Today

Create a test which sets a population limit and correctly iterates for x seconds to reach this population limit, in 1) Console App 2) WPF app 3) Web forms app.  Forget .CSV until you have done this but when done add the .CSV to the Console app.


### Graph Of Rabbit Population Produced As A CSV file

The output that I would like also is to create a text file with a `.csv` file extension with this structure

	Time (seconds)		Population

	0			0
	1 			1
	2 			2
	3 			8
	4 			16


	Line 1			Time(seconds),Population   		(header)
	Line 2			0,0
	Line 3			1,1
	Line 4			2,2
	Line 5			3,8

### Running Microsoft Excel To Display This File Automatically

Can you add a line 'Process.Start()' which will then run Excel to open this .csv file automatically?

https://www.c-sharpcorner.com/UploadFile/1e050f/process-class-in-C-Sharp/


### Controlling The Population With Rabbit Death

If a rabbit dies after 5 seconds, how long does it now take to reach the upper population limit?


### Rabbit Population Explosion With Foxes Reducing The Population Growth

Add foxes and this will correspondingly reduce the rabbit population !!! If we introduce foxes which multiply at half the rate of rabbits (ie 1 every seconds), how long will it take to reach the rabbit population limit?

### Setting Random Rabbit Properties

We can read random rabbit properties from https://www.json-generator.com/ using C# 




## HW_LAB_104 WPF Application Using Entity And Northwind

Create some buttons across the top of your application - Customers, Employees, Products and Suppliers.

Link these buttons to displaying a StackPanel object.  Each StackPanel object should be the same size and overlap.  Clicking on one button brings that StackPanel eg the Customers one to the front, and hide all the rest.

For Employees just list all employees

For Suppliers just list all suppliers.

For Products just list all products.

Also create a second list of top selling products.  In order to discover the top selling products we will need to cumulatively total up the gross value of sales for each product, and then sort in descending order.  If you want to go really advanced you can add a date field and have the top selling products since that date.  Or to make it a bit easier you can have the top selling products in the last 3 months, and the last 1 year.  Although Northwind might be a bit out of date so you might have to adjust these dates to suit.

For Customers display all customers.  

When we click on a customer, we can display all of the orders of that customer.  

Clicking on an order displays the order details including the product.

If there are any other ideas you have to enhance your application, feel free to share with the rest of the class.

Finally I will give 'cred' points to those who take the time and effort to add a touch of nice styling.

This is the project for today and for the weekend.