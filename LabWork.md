# Lab Work



## Quizzes

40-question test on Proprofs - please complete and submit the score and if it's below 90% please repeat until you can obtain a 90% score and let me know how long each test took also.

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


### Rabbit Population Explosion With Foxes Decimating The Population

Or add foxes and this will correspondingly reduce the rabbit population !!!  Once we have reached the population limit of rabbits, if we introduce foxes which multiply at half the rate of rabbits.  How long will it take to decimate the population of rabbits to zero?