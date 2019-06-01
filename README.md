
# 2019-04-c-sharp-labs

This repository holds teaching notes and labs for C#

The notes cover C# from basic to more advanced including ASP.NET and .NET Core, with Entity Framework included.

The labs are ordered in numbered sequence in ascending order of difficulty, starting at the most easy and progressing to the harder labs and concepts.

## Table Of Contents


- [2019-04-c-sharp-labs](#2019-04-c-sharp-labs)
  - [Installed Apps](#installed-apps)
    - [Rapid Business Skills Exam Prep](#rapid-business-skills-exam-prep)
    - [Extra Exam Prep](#extra-exam-prep)
- [C#](#c)
- [Programming](#programming)
  - [Simple Programming](#simple-programming)
  - [Operators](#operators)
    - [Increment operators](#increment-operators)
    - [NOT OPERATOR](#not-operator)
    - [Bodmas / Bidmas](#bodmas--bidmas)
  - [Data Types](#data-types)
    - [bytes](#bytes)
    - [raw object data type](#raw-object-data-type)
    - [Casting](#casting)
    - [OOP Object Oriented Programming](#oop-object-oriented-programming)
    - [Scripting](#scripting)
    - [.bat](#bat)
    - [.ps1](#ps1)
    - [Linux computer 'BASH' shell does similar work](#linux-computer-bash-shell-does-similar-work)
    - [OOP](#oop)
  - [Methods](#methods)
  - [Finish off day with some more simple coding](#finish-off-day-with-some-more-simple-coding)
    - [if..else if .. else](#ifelse-if--else)
    - [Ternary operator](#ternary-operator)
  - [Random Notes And Topics](#random-notes-and-topics)
- [Week 2 : Tuesday : Review Of Terms](#week-2--tuesday--review-of-terms)
  - [List<T>](#listt)
  - [Stacks](#stacks)
  - [Summary so far](#summary-so-far)
  - [Queue](#queue)
  - [Review Of Classes with Fields And Properties](#review-of-classes-with-fields-and-properties)
  - [Methods](#methods-1)
    - [Return type](#return-type)
    - [Parameters](#parameters)
    - [Out parameter for methods](#out-parameter-for-methods)
    - [Optional parameters](#optional-parameters)
    - [Named Parameters](#named-parameters)
    - [Constructor Methods](#constructor-methods)
    - [Overloading](#overloading)
    - [Summary](#summary)
    - [Passing integers into a method `by reference`](#passing-integers-into-a-method-by-reference)
    - [Passing an OBJECT into a method](#passing-an-object-into-a-method)
  - [Polymorphism](#polymorphism)
    - [Overload vs Override](#overload-vs-override)
  - [Abstract Classes](#abstract-classes)
  - [Homework End Of OOP Day 2](#homework-end-of-oop-day-2)
  - [Wednesday Term Review](#wednesday-term-review)
  - [Testing](#testing)
  - [Working With Databases](#working-with-databases)
    - [Continuation of Entity](#continuation-of-entity)
    - [Summary of actions so far](#summary-of-actions-so-far)
    - [Summary Of Entity : 4 CRUD Operations (Create, Read, Update, Delete)](#summary-of-entity--4-crud-operations-create-read-update-delete)
  - [File Operations](#file-operations)
  - [Files : Summary So Far](#files--summary-so-far)
  - [Collections](#collections)
  - [Friday : going over a few topics which we have not yet covered](#friday--going-over-a-few-topics-which-we-have-not-yet-covered)
  - [Naming Conventions](#naming-conventions)
  - [Break And Continue In Loops](#break-and-continue-in-loops)
  - [Return](#return)
  - [Exiting A Loop Or Method By Throwing An Exception!](#exiting-a-loop-or-method-by-throwing-an-exception)
  - [Goto](#goto)
  - [Try..Catch..Finally](#trycatchfinally)
    - [Handled vs Unhandled Exception](#handled-vs-unhandled-exception)
    - [try.catch.finally](#trycatchfinally)
    - [Throwing An Exception](#throwing-an-exception)
  - [WPF Grid](#wpf-grid)
  - [Reference Type And Value Type](#reference-type-and-value-type)
  - [Reference Types](#reference-types)
    - [Code Example : Copy 1) Value Type 2) Reference Type](#code-example--copy-1-value-type-2-reference-type)
- [Git and Github](#git-and-github)
    - [Quick summary of commands : git in 'local' realm on your PC!](#quick-summary-of-commands--git-in-local-realm-on-your-pc)
- [Push To Internet](#push-to-internet)
- [git remote](#git-remote)
  - [git pull](#git-pull)
  - [git config](#git-config)
  - [git branch](#git-branch)
  - [Lock master so can't push directly](#lock-master-so-cant-push-directly)
  - [Pull request from dev to master](#pull-request-from-dev-to-master)
  - [Pull down changes from master](#pull-down-changes-from-master)
  - [changes in master : from someone else : use `git merge` to merge master into our dev](#changes-in-master--from-someone-else--use-git-merge-to-merge-master-into-our-dev)
- [git log](#git-log)
- [git reset --soft](#git-reset---soft)
- [git reset --hard](#git-reset---hard)
- [Adding SSH keys to your GitHub account](#adding-ssh-keys-to-your-github-account)
- [SQL](#sql)
  - [Basic commands](#basic-commands)
    - [alter](#alter)
    - [insert into](#insert-into)
    - [update](#update)
    - [delete](#delete)
  - [Types Of SQL command](#types-of-sql-command)
  - [Best practice](#best-practice)
  - [RAW DATA : AND STRUCTURE](#raw-data--and-structure)
    - [Normal Form](#normal-form)
    - [Ways to store data](#ways-to-store-data)
  - [SQL revision session](#sql-revision-session)
  - [SQL Day 2 : Querying Your Database : Simple and Advanced Query Syntax](#sql-day-2--querying-your-database--simple-and-advanced-query-syntax)
    - [select top 5](#select-top-5)
    - [SELECT .. WHERE .. AND ...](#select--where--and-)
    - [Operators](#operators-1)
    - [distinct](#distinct)
    - [wildcards](#wildcards)
    - [LIKE %...%](#like-)
    - [Starts With 'abc%'](#starts-with-abc)
    - [using % wildcard and _ single letter wildcard](#using--wildcard-and-_-single-letter-wildcard)
    - [OR query](#or-query)
    - [IN query](#in-query)
    - [between](#between)
    - [count](#count)
    - [exercises](#exercises)
    - [AS](#as)
    - [Null](#null)
    - [Arithmetic Operators](#arithmetic-operators)
  - [String Manipulation](#string-manipulation)
    - [CharIndex : find the (FIRST) index of a character inside a string](#charindex--find-the-first-index-of-a-character-inside-a-string)
    - [Substring](#substring)
    - [left and right](#left-and-right)
    - [LTRIM (RTRIM) remove spaces from start or end](#ltrim-rtrim-remove-spaces-from-start-or-end)
    - [LEN is length of string](#len-is-length-of-string)
    - [replace](#replace)
    - [upper/lower](#upperlower)
    - [Homework](#homework)
    - [SQL Day 3](#sql-day-3)
    - [Count, Sum, Avg, Min, Max](#count-sum-avg-min-max)
    - [Group By](#group-by)
    - [Quiz](#quiz)
    - [order of commands](#order-of-commands)
    - [Having](#having)
  - [JOINS](#joins)
    - [Use Alias to Shorten Queries](#use-alias-to-shorten-queries)
    - [Quiz](#quiz-1)
    - [Selecting Data From 3 Tables](#selecting-data-from-3-tables)
    - [Methodologies : Scrum and Agile](#methodologies--scrum-and-agile)
    - [History Of Agile](#history-of-agile)
    - [Agile Methodology](#agile-methodology)
    - [Scrum Methodology](#scrum-methodology)
  - [Monday - Week 4 - Revision](#monday---week-4---revision)
  - [Tuesday - Week 4 - Revision](#tuesday---week-4---revision)
- [arrays](#arrays)
    - [static vs instance variables](#static-vs-instance-variables)
- [Events](#events)
    - [Games Week : Top-Up Tech !!!](#games-week--top-up-tech-)
  - [Wed : Revision (break from SQL)](#wed--revision-break-from-sql)
    - [Polymorphism](#polymorphism-1)
    - [Thursday : Morning review](#thursday--morning-review)
    - [GitHub lab](#github-lab)
    - [20 minutes flash review](#20-minutes-flash-review)
    - [Interface](#interface)
    - [Coding Prep Exercise](#coding-prep-exercise)
  - [Luitzen question](#luitzen-question)

## Installed Apps

	* Visual Studio 2017/2019

	Sublime Text 3
	
	Notepad++

	Notion Desktop

	Microsoft OneNote

	Microsoft Office 	
	
	VSCode : web development : Microsoft

	


## Be A Lifelong learner !!!

	Mornings!!!		2-3 hours on fresh brain : incredibly productive

	Evenings!  		Quiet time 	
	
	Low energy ==> break; exercise/fresh air

	Note taking 

		Mind maps : head around subject

		Electronic notes : Google Docs, Notion, OneNote

		Programmers ==> MARKDOWN FORMAT .md

			### HEADER

			```html
			<div>some html here</div>
			```

		

## Communication In A Business

Business Email

Hi

I’m enquiring about possible courses in C# with Sparta.

My background is Civil Engineering and I have recently graduated with a 2:2 from Brunel University last year.

I enclose my CV and look forward to hearing from you.

Thank you

Philip Anderson





Friendly email


Hi 

Great to see you in class yesterday; hope things went well.

How did the Treehouse go?

Thanks

Phil

??



Send 2 emails


1.	Friendly asking for something

2.	Business : manager : time off




Whatsapp

	Great for quick, instant communication, team spirit 


Microsoft Teams

	Chat : Business app : keep spelling and grammar good; otherwise no particular rules

	Group Chat: professional environment 



Managing emails

	Inbox 			==> actionble email (ie something to do or reply)

		> Topic1

		> Topic2

		> Topic3

		> Archive 

		Trash


	Good practice : daily go through emails and try and ignore them while you want to do 'useful work'

		((Batch replies : until you've finished your 'useful work' for the day))

		Study time : 

			'Go dark' and not reply to ANY EMAILS until 3pm 

			Bad : study day : 9am reply to email ==> a) ask to do work
							         b) distraction (trivia)
								 c) disturb YOUR FOCUS

		Try not to let email 'rule your life' by 'always-on', must-instant-reply !!!


	THINK ABOUT !!!

		INBOX ZERO : keep inbox clear!!!

		?? Work from oldest emails up ??




Use of English

	
	Grammar : learn how to use English grammar correctly 

	Spelling : learn and increase your learning !  


Delicate or sensitive matters

	Write once, not send then reread carefully either straight away or, better, after a pause.



## Time Management

	Under-promise, over-deliver

	Always assume things will take longer than you might initially plan

	Big task

		Break down : Prioritise


		Eisenhower Model

						Urgent			

			Important		Necessity (fighting fires!)			(High) Quality 
												(life-enhancing
												work lives here)


						Urgent, Not important				Not important
						(Deception) - time wasters			Not urgent
												(Waste) of time!

			

	Pareto Principle

		20% of effort can produce 80% of desired results

	Time Boxing

		Putting a time limit on task : psychologically can trigger more effective work



	Task management 

		If it takes less than 2 minutes, DO IT!!!


		To Do Lists!!!


			1. Capture Tasks : phone calls, emails, chat etc ==> INTO ONE PLACE!!!

			2. Organise : Prioritise Tasks and Your Day

				Calendar : (Google calendar ==> alerts & emails!!!)

				Daily : Write out tasks for day  (night before or first thing)

			3  Do IT!!!!

				In order !!!

				Projects

					1) Plan well

					2) Track progress

					3) Report on progress



	Exam : Time Management main points/categories

		1) Timeboxing
		2) Measuring/Recording tasks and progress
		3) Effective Meetings (at work)

			Developers : Daily 'stand-up'  (10-15 min max total time)

					Everyone : What you did (yesterday), Doing (today), Blocker/hindrances

			Planned meeting : invite people carefully, agenda, minutes, report on outcomes and actions
			




## How Your Progress Is Measured At The Academy

	Lominger 	

		Score behaviour

			Behaviour (actions)

			Technical Knowledge 

			Attitude (outlook mentally)

			Attributes (qualities about you)


	Behaviour

		Horsepower : raw ability to learn, progress, push through problems etc (tenacity)		

		Interpersonal : create and develop relationships

		Perseverance : overcome obstacles etc
	
		Self Development : how you take steps to progress your own knowledge		

		Standing Alone : being counted, have a voice, not let others speak for you, being confident amongst others,
				  
		Problem Solving : how to fix stuff/problems - many ways!!! be creative!

	


	Coding

		Functionality : Does code work???

		Readability : does code read well visually? appropriate comments?

		Reuse/Maintain

			DRY Don't Repeat Yourself!

				Loop 1 to 100

				Loop 1 to 1000


				or (better)				

				Loop(1 to max)
						
		Git / GitHub       
			Git : local
			GitHub : online
						keep record of work done, in stages
	
	Presentation Skills

		Practice during course : code reviews, company reviews to whole academy		
					 project : summarise with powerpoint

		Intro / Close

		Design 

		Poise : posture

		Knowledge

		Elocution : how you speak		


	Project work

		Awareness of 'deliverables' (what you have to do!)
		
		Best practice : coding standards???, GitHub together

		Tools

		Problem solving

		Communication

	Interview
			
		Appearance
		Behaviour : passion, enthusiasm (not over the top!)
		Academy knowledge
		Technical knowledge
		Integrity : honest 



## Communication Skills

	Onsite

		Representing not just yourself but another company (Sparta)

		Professional behaviour : in academy and on placement on site

	Communication

		Content : what is said    5%			VERBAL

		Tone : way you say it     40%			VOCAL

		Body Language 		   55%			VISUAL

	
	Listening

		2 ears + 1 mouth : people like a good listener



		Not really listening / interested  (something else on mind!)		COSMETIC

		Casual interest (nod, yes..)						CONVERSATIONAL
	
		Active interest (questions!)						ACTIVE

		Deep passionate interest						DEEP
	
		
	Personalities

		If everyone agrees then someone's not thinking!  Great teams are diverse in 
				thought and opinion

		Great group 

			Introvert
			Extrovert
			Team players
			Directors (leaders)
			Analytical (hard worker, thinker)

		
	Questions

		Closed

			Yes/No
			One-word

		Open

			Tell me about..
			How did you find..
			Share a little..
			What did you think about that?

	Conflicts

		Always try and understand 'other side'

			Think WIN - WIN 

			
		Reason for clash

			Personality

			Communication : written/verbal/body language

				'gossip'

			Working style 


		Nullifier : seeks peace

		Seeker : proactive to find solution


	Example of communication for group



 	Advanced communication : finish in the morning



## Presentation Skills

	
	Why?

		Communication of key facts

	Influence : persuasion : show others your point of view 

		Stakeholder : any person with an interest in our project

			Customer (ordering the work) , Directors, Employees, Managers
			End user, competition, Media, 

			If project is run by government/council ==> general public, activist

	Good presentation

		Exam : 

			C	Confidence in speaking
			M	Manner : Body Language
			A	Attitude : humility, honesty etc
			D	Diligence : work of quality
			E	Enthusiasm : no one likes a dull speaker!

	Structure

		Slides - not too 'wordy'

		1. Intro
		2. Outline
		3. Topics
			
					Report vs Powerpoint
			
						Report : rule of 5 : Intro, Backgound to topic, 
							Transition into details, Fine detail, conclusion

						Powerpoint : rule of 3 : 3 sections/slides per topic

	KISS : Keep It Simple, Stupid!!!

	Tips for newbies

		Bottle of water : 'pause time' 

		Humour!
	


## Project Management

	BAU Business As Usual		Regular run-of-mill-work

	Projects

		Unique
		Transient
					Inserted into workplace with definite goal
		
		Clear aim

			Phases

			Specialists

			Involve complexity

	Constraints on a project

		1) Balance 		TIME       vs         QUALITY           vs       COST


	POPIT IT Model

					people

			  		IT
			
			processes		 organisation
			(flow of work)            (company)






		

## IT Project Methodologies : Waterfall vs Agile

SDLC = Software Development Life Cycle

	Waterfall : simple, fixed projects

		First IT projects like this
		Fixed, unchanging : List of Requirements, Analyse, Design, Build, Test, Release	
		Good for manufacturing / military / small projects	
		
		V-model
			Waterfall + Extra Testing for mission-critical projects

	Agile : changing projects

		Check ' Agile Manifesto '
		
		IT : spectacular fails!!!  Design : too big + whole project : takes too long!!!	

		Solution : Don't design project fully in intricate detail up front.  Only design
			first simple prototype (( MVP Minimum Viable Product ))  (Sprint 1)
			Then => Sprint 2 : Add an INCREMENT OF FUNCTIONALITY!!!
			Sprint 3 : Next iteration etc
		
		Scrum : work in short increments (sprints)

			3-9 developers
			Daily 'stand up'
			Sprint is a focused piece of work

	Kanban : continuous flow

		Car manufacturing is 24/7

		Some industries better with 'flow' of work non-stop.

			Kanban 'board' list of tasks but limit 'number of tasks in progress at any
				one time'


	
	Proposing a new project

		Risk

			% chance that something will go wrong

				% Probability 'x' which will result in loss of impact 'y'

				20% chance market will collapse with loss of £1,000,000

		Cost  

		Timescale (Crossrail!!!)

		Approvers ???

		Stakeholders !!! (give account to)

			Investors 
		
		Cost-Benefit Analysis : How will it benefit our business?

			ROI : Return On Investment  (long term)

			




## Advanced Communication

NLP Neuro		First responses ('first mental map'
			ie how you encounter world around you
			5 SENSES : Touch, smell, taste, sight , hear
    Linguistic 
			Learning : how you process information

    Programming		Action : what you DO!  

Bias
	
	tend to take sides based on our personal preference

		OBJECTIVE		FACTUAL, IMPARTIAL, UNBIASED

		SUBJECTIVE		OPINION BASED, CAN CHANGE

	Exam : cases which may cause bias

		Pressure of time : people tend not to think things through 
					carefully

		Money : lack of it : tends to cause pressured behaviour

		Lack of information / meaning / clarity : Poor decisions based
				on half-information
		
		Diversity issues

		Overwhelmed with choice : too much info!

		(human level) forget which can limit ability to make good 
				decisions (limitations of memory)

	Examples

		Anchoring bias : tend to choose 'first option'

		Choice-supportive : support option which you personally prefer				
		Confirmation bias : I've already reached my conclusion so
			the facts must fit my choice.

		Outcome bias : concerned about the consequences of a certain
				outcome rather than making a good, rational
				decision

	Reducing Bias

		6 'objective hats'   (De Bono Thinking Hats)

		White		pure facts only
		Yellow		optimistic choice
		Black		pessimist / negatives / dangers
		Red		emotional / feelings to do with this decision
		Green		creativity, creating opportunities from 				nothing
		Blue		rational decision	


## CV

	Profile Statement

		Best opportunity to 'sell yourself'

		3rd person 'Jas is a hard working, proactive individual ..

			She has graduated recently with a 2:1 in Software
			Engineering from xx university.  Having recently 
			attended Sparta Academy she has developed on C# skills
			already strong from University. 

	Grammar and spelling : critical !!!

	
	Structure
		Personal Profile Statement !!! Yes !!! 

		Sparta ...

		Education History (most recent first) degree, A level, GCSE

		Work History (most recent first)

		Interests

			xxxx no !!!  party/drinking / friends
	

## Programming Puzzle : Fizz-Buzz

	Count to 100

		If divisible by 3 ==> Print 'fizz'

		                5           'buzz'

				3 and 5     'fizzbuzz'

		Otherwise just print the number


		1,2,fizz,4,buzz,fizz,7,8,fizz,buzz

		divisible????

			/                        10/3  3.333
			% remainder (modulus)    10%3 = 10 divide by 3 and what is the remainder???  ==> 1

						 i%3 = 0  on 3,6,9
						 i%5 = 0  on 5,10,15

		Equals

			a=6    assigning 6 to a

			if(a==6)    does a equal 6???




## Thursday : Review of work 

Loops
	For, Foreach, Do, Do..While

SQL : Structured Query Language
	MS-SQL : Paid product
	MYSQL  : Open source

Microsoft vs Open source : Web server (hosts websites)

	IIS Internet Information Server : Microsoft

	Apache : Open source
	NGINX  

	
Git		Local application running on computer.  Allows you to TRACK VERSIONS OF FILES

	GitBash (fake command line, looks like 'Linux' computer)

Github		Website which allows us to 'push' files stored in Git up
		to internet.  Others can 'pull' down those files

 CMADE : Presentation acronym

	Confidence, Manner, Attitude, Diligence (hard work), Enthusiasm

KISS Keep it simple, stupid!


Lominger : 'Competencies' (ability to operate in certain areas)

	4 main categories

		Behaviour (actions)
		Technical Knowledge
		Attitude (posture)
		Attributes (qualities you have)

	5 Sparta categories
		Behaviour, Coding, Interview, Presentation, Project
		
	Scored on : 
		Horsepower, interpersonal, perseverance, standing alone, 
		Self development
		
		
2 Triangles

		'Triple Constraint'           TIME VS QUALITY VS COST

					   People	
					
		POPIT			    Tech

				 Organisation        Processes
				(company)            (flow of info/data)

SDLC models

	Software Dev Life Cycle

Waterfall
	Simple, structured project which will NOT CHANGE!

V-Model

	Add to waterfall : extra testing at each stage

Agile
	builds 'MVP' minimum viable product ie first prototype, then 
		add functionality steadily each 'sprint'
	'manifesto' ==> value people, embrace change

	Scrum : Implementation of agile in a practical way
		'Sprints' : build fixed chosen new 'iteration' (improvement)
			Stand-up :  Did yesterday, Do today, 'blockers'	

	Customer : 'list of requirements' (product backlog)
		Sprint : choose one or two items to build (sprint backlog)

Kanban
	Continuous flow of work : limit work-in-progress at any one time!

	Backlog     Chosen For development       In development      Done

	lots         few                         5 max               

Time Management 

	Boxing : limit time on task, helps not to just run without end

	2 mins : just do it!

	1	Capture
	2	Organise
			Prioritise
	3. 	Do
			Plan , Track progress, Report 

Pareto : 20/80     

Underpromise / Overdeliver

Eisenhower 'box of tasks'
			URGENCY
			HIGH		LOW	

IMPORTANCE  HIGH	1 fire-fight	2 BEST PLACE 'high quality'
			  'necessity'

	LOW		3 not important		4. waste of time 	
			  (urgent but for
			  reasons often not
			  helpful to yourself) 
			    (deception)

Communication
	Cultural, geographical, working styles

	Verbal   	Content
	Vocal		How said, tone
	Visual		Body language


Listen types
	
	Passive : think about something else!	
	Conversational 
	Active : questions
	Deep

	
TDD
BDD

	
	
## Rapid Business Skills Exam Prep

Paragraphs : Rule of 5 : Start, Background, Transition, Details, Conclusion

Powerpoint : rule of 3 : 3 sections/slides per topic

Time Management : Timboxing, Meetings, Measuring and Recording

Lominger : Behaviour, Technical, Attributes, Attitudes

Task Manage : Collect, Organise, Do

	Do (Larger Tasks) : Plan, Track, Report

Eisenhower : Important vs Urgency

	1. Fires : Necessity 2. High Quality    3. Deception  4. Waste

Pareto 20/80

Communication : Verbal Vocal Visible

Listening : Cosmetic, Conversational, Active, Deep

Open/Closed questions
	Closed : yes/no or one word answers

Presentation : CMADE  Confidence, Manner, Attitude, Diligence, Enthusiasm

NLP : Neuro = first response (5 senses), L=Linguistic : adding learning, P=Programming = Action

Cognitive Bias : caused by : Pressure of time, money, Too much info, too little info, limitations of memory

Types of bias : Anchor (to first option), Choice-support(your preference), confirmation(support the one you chose), outcome (focus on result not on good choices)

CMADE presentation : CONFIDENCE, MANNER, ATTITUDE, DILIGENCE,ENTHUSIASM

BAU : Business as usual
Project : Unique and transient

Triple Constraint : Time, Cost, Quality

POPIT : IT at centre with people, processes and organisation

Waterfall : Propose, Analyse, Design, Build, Test, Maintain

V-Model = Waterfall + testing

Agile : build in increments

Project Planning : Initiate, Plan, Execute, Monitor/Control, Close

Project Roles : 
	Business Owner = customer, our client
	Analyst = Analyse client needs, gets ball rolling
	Project Manager : runs project
	Tester = ensures high quality (QA)

Stakeholders
	

## Extra Exam Prep

TDD Test Driven Development : tests written in code
BDD Behaviour Driven Development : tests written in plain english
XP Extreme Programming 


Critical path : most efficient path for project

Interview Succces

	STAR Situation Task Action Result

		Situation : background to problem
		Task : what was your task
		Action : you did
		Result : outcome



Project has a critical path which details the correct path to take to complete all of the work in the project

Preceding tasks must be completed before a task can be started (Precedence)

Scope = Total sum of all of the work in a project

Gantt Chart = Projects over time

Proposing a new business venture.  Also called 'making a case' for a new project
	Risk
	Estimation of Time, Money, Resources (People and Assets)	
	Gantt Chart


Stakeholders
	High power and interest : actively manage
		   medium interest : satisfy
                   low interest : watch
	Medium power : keep onside
	Low power : inform




## Exam Prep

Presenation : CMADE Confidence Manner Attitude Diligence Enthusiasm

Paragraphs : rule of 5 : intro, background, transition, detail, summary

Powerpoint : rule of 3 

KISS

Time boxing

Time Management : effective meetings, measure/report

Tasks : Capture/Gather, organise, Do		

	Do : Track, Progress, Report

Pareto : 20 effort produces 80 result

Eisenhower

1 Necessity = Must do (high importance/urgency)
2 High Quality : Important
3 Deception : Not important
4 Waste 

Triple constraint   :   TIME QUALITY COST

POPIT :  IT at focus , people, process, organisation

Lominger : behaviour
		
	67
	4 categories  : Behaviour, attitude, attributes, Technical 

Sparta attributes : horsepower, interpersonal, persevere, stand alone, problem solve, self develop

Listening : Costmetic, conversation, active, deep

IT Project
	Waterfall : Analysis, Design, Build, Test, Release, Maintain
		V-model	 + TESTING
	Agile : increments
		Scrum  : sprint (2-4 weeks) + daily standup
	Kanban    roll 24/7 : limit tasks

	No longer write code then test it
	But write TESTS then build code to pass tests
		TDD 	Test Driven Development
						Assert.AreEqual(x,y)   x=actual y=expected
		BDD 	Behaviour Driven Development 
						If user clicks button then link 'x' should open
	Older XP Extreme Programming

Meetings : invitees, agenda, minutes, actions




















# C# #

## High And Low Level Programming

CPU : instruction set : raw binary commands which make cpu operate

Machine code : raw instructions sent to CPU

Assembly Language : low level

CIL half-way-house 

High level languages : C#, C++, Java, Javascript, Python 

	C,C++ very fast as direct memory access etc







## Structure of an application

.sln
	Solution
		Container object : of itself it does nothing
		XML : lists projects and other 'meta' data
 
	Project

		.csproj
			XML with details of project

		ONE PROJECT : COMPILE TO BINARY FILES (NON-HUMAN-READABLE)
				1) .exe  running application 
				2) .dll  library (dynamic link library)  

### Referencing files

	From one project to another, we can 'use' or 'reference' files (normally we call them 'classes') from one project in another project.

	Lab
		1) Build lab_04.dll and exposed a PUBLIC CLASS WITH A PUBLIC FIELD

		2) Build lab_05_using_dll.exe which reads from lab_04.dll

			((Add a reference to achieve this))


### CSC C Sharp Compiler

To 'compile' is to take code from readable .cs to .exe running code

	compile = repackage our code in such a way that it can be processed by the CPU as 
			running code, and run as an application/library on the computer

	.NET has several languages and they can all compile to same code

							==>      'half-way-house'                   ==>        Runtime			

		C++
		C#
		VB Visual Basic			     CIL COMMON INTERMEDIATE LANGUAGE             'CLR'
		F#																		Common language
																				Runtime (matched to CPU
																				architecture)

		Exercise : view and inspect CIL compiled code

			TOOL : ILDASM  (Visual Studio Command Line 'Developer Tools')


		.cs raw human-readable code

			CIL half-way-house compiled code

				CLR runtime 


### .CSC compiling a single file

	The C Sharp compiler can compile just one file, without Visual Studio

	Copy program.cs to notepad and save as myapp.cs

		Compile c:\......\csc.exe  myapp.cs

			==> create myapp.exe  


## .NET vs .NET Core

Windows computers are built with a programming language called 'C'.  This has developed into modern C++.  ((Linux/Apple/Android/Windows all have 'C' at heart))

	Raw, fast ==> C++ best option

	But!!!  Visual Basic (old) and C# have both been created with developer in mind, for ease 
			of coding

			Java (non-microsoft)
			VB
			C#
						High level languages ==> slower but a lot of features, easy to use !

	Windows ==> over time, huge 'library' of code built by Microsoft

		.NET library

			using System.IO;    part of .NET

				Too big!!! (4.2GB) and Windows-only

	.NET Core => cut-down version for all operating systems
	
	Both are now OPEN SOURCE!!!

		CLOSED SOURCE ==> WINDOWS10,APPLE  (only the company can work on this code)
		OPEN SOURCE ==> ANYONE CAN CONTRIBUTE


## Namespace

	Useful for creating a 'container' for our code

		In each container we can have unique names, so there is no risk of conflict



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using phil1;

namespace lab_06_namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = new phil1.GreatTrainer();
            // add using statement, can see directly
            var item2 = new GreatTrainer();

            var item3 = new phil2.ExcellentLearning();
            Console.WriteLine(item3.LearnLots);
        }
    }
}

namespace phil1 {
    public class GreatTrainer { }
}

namespace phil2 {
    public class ExcellentLearning {
        public string LearnLots = "running C#";
    }
}




	

	Main() method	


		Start point for every program

	Program types

		Console EXE
		Library  DLL
		Old - Windows Forms
		New - WPF Forms
		Xamarin - Mobile Apps (Android, IOS)
		Unity - Games
		UWP Universal Windows Platform : Windows 10 'Store' apps 


## Args array

	When we run a program the Main() method gives us access to the 'Args' array


	If we run any program eg myapp.exe some data here then the extra words are treated
			as input for the program 


            Console.WriteLine("Printing out arguments array");
           
            if(args.Length == 0)
            {
                Console.WriteLine("There are no arguments");
            }
            else
            {
                foreach (string item in args)
                {
                    Console.WriteLine("Your item is - " + item);
                }
            }


## Simple Programming

Covered last week, in passing!

Loops

	4 types

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_08_loops
{
    class Program
    {
        static void Main(string[] args)
        {

            // FOR
            for (int i = 0; i < 10; i++) {
                Console.WriteLine($"Your number is {i}");
                Console.WriteLine($"Number squared is {i*i}");
            }

            // WHILE
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"While loop : number is {counter}");
                counter++;
            }

            // DO..WHILE
            counter = 0; // reset
            do
            {
                Console.WriteLine($"Do..While : number is {counter}");
                counter++;
            }
            while (counter < 10);


            // ARRAY

            // ARRAY is a FIXED-SIZE STRUCTURE which is very fast to access.

            // DECLARE
            int[] myIntegerArray = new int[10];    // size has 10 boxes for integers
            string[] myStringArray = new string[10];    // size has 10 boxes for strings

            // ACCESS ONE ITEM
            // FIRST ITEM HAS INDEX 0
            myIntegerArray[0] = 100;
            myIntegerArray[1] = 101;
            myIntegerArray[2] = 102;
            // LAST ITEM : INDEX = SIZE-1  IE 10-1 = [9]
            myIntegerArray[9] = 999;

            // FOREACH : COUNT OVER EVERY ITEM IN ARRAY
            foreach(int item in myIntegerArray)
            {
                Console.WriteLine($"Item in array is {item}");
            }

            // REPEAT FOR A STRING ARRAY
            string[] myArray  = new string[3];
            // FILL ARRAY AT SAME TIME : STRING 'LITERALS' GOING IN CODE
            string[] myArray2 = new string[]{ "one", "two", "three" };
            // fill the array 
            myArray[0] = "one";
            myArray[1] = "two";
            myArray[2] = "three";
            // foreach loop to print the items
            // PRINT myArray
            foreach(string item in myArray)
            {
                Console.WriteLine(item);
            }
            foreach(string item in myArray2){
                Console.WriteLine(item);
            }
            // NOTE CAN USE FOR - start at 0 and count to the array length - 1 
            for(int i = 0;i < myArray2.Length; i++)
            {
                Console.WriteLine($"Using for loop over array - {myArray2[i]}");
            }

            // 10-MINUTE LAB : BUILD FOR LOOP, THEN ALSO BUILD A WHILE LOOP.
            // BOTH WILL COUNT TO 1000 (step 50)
            for(int i = 0; i < 1000; i+=50)
            {
                Console.WriteLine($"for loop to 1000 - {i}");
            }

            counter = 0;
            while (counter < 1000)
            {
                Console.WriteLine($"While loop to 1000 - {counter}");
                counter+=50;
            }
            // BONUS : FILL ARRAY WITH 1000 NUMBERS AND PRINT OUT ALSO
            // VAR JUST MEANS 'any variable type' - let the computer decide
            // (ALREADY STATED TYPE ON RIGHT IE int[1000]
            var myLargeArray = new int[1000];
            for (int i = 0; i < myLargeArray.Length; i++)
            {
                // fill the array
                myLargeArray[i] = i;
            }
            for (int i = 0; i < myLargeArray.Length; i++)
            {
                // print the items
                myLargeArray[i] = i;
            }

        }
    }
}

```


## Operators

We can use `operators` to do things, like addition, subtraction etc

### Increment operators

```CS
// increment operators - adding one!
int x = 100;
//  y=x  then x++ ie increment x by 1
// so y=x=100 then x increments to 101
int y = x++;  // same as int x=100; y=x; x++;
// think answer is :     101         100
// actual answer is :    
Console.WriteLine($"x is {x} and y is {y}");

// if we want expected results use this
int a = 100;
int b = ++a;
// BOTH 101 AS EXPECTED
// firstly increment a to 101 then b=a=101 after
Console.WriteLine($"a is {a} and b is {b}");

// GENERAL RULE = JUST ONLY USE ++; ON IT'S OWN SEPARATE LINE!!!

// best way

int r = 1000;
r++;          // UP TO 1001
int s = r;  // clear and no nonsense!!!  BOTH 1001

```

X-- is decrement operator


### NOT OPERATOR

```cs
//  !true=false

bool isExcellent = true;
bool isRubbish = false;

Console.WriteLine(isExcellent);   // TRUE
Console.WriteLine(!isExcellent);  // FALSE

```

### Bodmas / Bidmas

Brackets
Indices
Divide/Multiply
Add/Subtract


// Got to get your BIDMAS clear!!!

// 96 + 20 / 5 - 77 / 11

//  96  +  4    -     7

//  93

// WRITE OUT ON COMPUTER AND GET ANSWER

//  5 SQUARED * 13 CUBED - 7 / 4

```CS


Console.WriteLine(5*5*13*13*13-(7/4.0));

var FiveSquared = Math.Pow(5, 2);
var ThirteenCubed = Math.Pow(13, 3);

Console.WriteLine(FiveSquared*ThirteenCubed-(7/4.0));


Console.WriteLine(Math.Sqrt(100));

// modulus

Console.WriteLine(100/8); // 12 WRONG - CARE!! integers yield integers!!!
Console.WriteLine(100/8.0);  // 12.5 CORRECT
Console.WriteLine(100%8); // 4 REMAINDER CORRECT



```



## Data Types 

Let's look at the following

Strings

Integers : short, int and long

Unsigned integers : uint

Floats

Doubles

Decimal

null


```CS
// string
string x = "hi";
String y = " there";
// use lowercase 'string'
// uppercase String is when use String as a 'class'

// concatenate
Console.WriteLine(x+y);
//  super-long strings this is MEMORY INEFFICIENT
// stringbuilder : use to build very long strings
var longString = new StringBuilder();
for(int i = 0; i < 1000000; i++)
{
    longString.Append($"adding{i}");
}
// Console.WriteLine(longString);

// Integers ARE 32 BITS LONG!!!
int anyNumber = 23456;
Console.WriteLine(anyNumber.GetType());

```

Using computers to store data

All computers store data like this

	var number = 1010;      raw data is stored as 0 or 1 (bit)

	If our number had 4 bits then in binary we can count from

		0       0000
		1       0001
		2       0010
		3       0011
        4       0100
        ..
        15      1111

        With 4 bits we can count from 0 to 15 (16 spaces ie 2 to power 4 = 16)


        Now let's take a number with 32 bits - what is the maximum???

        	2^32 = ????  4 billion

        			4 294 967 296

        short = 16 bits (2^16 = 65536)

        long = 64 bits (2^64 = 1.8446744e+19)


        Only thing to be aware of is that we also have to store a +/- sign for every number
        	because -200000 or +200000 

        Therefore ONE BIT IS FOR 'SIGN' 

        	INT : 32 BITS : ACTUALLY HAS ONLY 31 BITS FOR NUMBER AND 1 BIT FOR SIGN

        	Prove : Int.MaxValue()
        	        Int.MinValue()



Casting
Boxing
Value types
Reference types
Loop : break; continue; switch; return
 exceptions try..catch..finally


























## Tuesday : Review Of Monday

```cs
            // DATA TYPES
            // int

            // signed
            short x;    // 16 bit
            Int16 xx;  // same thing

            long l;     // 64 bit
            Int64 ll;

            int i;      // 32 bit default  (31 for data, 1 for sign) 
            Int32 ii; 

            // unsigned : positive only
            ushort u1;

            // danger : integer division TRUNCATES!!!! CARE!!!!
            Console.WriteLine(12 / 6); // expected 2
            Console.WriteLine(12 / 5); // expected 2.something but get 2

            Console.WriteLine(12.0 / 5); // 2.4
            Console.WriteLine(12 / 5.0); // 2.4

            // decimals : default is DOUBLE AND HAS 64 BIT PRECISION

            var num1 = 1.23456778901234567890; // DOUBLE 64 BITS 
            var num2 = 1.23456778901234567890F;  // turns into FLOAT 32 BIT PRECISION
            var decimal01 = 1.23456789012345678901234567890123456789012345678901M;
            // super long 128 bit decimal type

            // float 32 bit
            // double 64 bit
            // decimal 128 bits long (precise for money)

            // INTEGERS
            // DECIMALS

            // division
            Console.WriteLine(100/8);    // 12 INCORRECT (INTEGER WHOLE NUM ONLY)
            Console.WriteLine(100/8.0);  // 12.5 CORRECT 
            Console.WriteLine(100%8);    // MODULUS  REMAINDER 4 CORRECT


            // LOOPS : 4 TYPES

            // FOR

            // FOREACH
            string[] myArray = new string[] { "one", "two", "three" };

            // WHILE

            // DO.WHILE

            // BODMAS / BIDMAS   Brachet, operator/indexes, dm , as

            //NAMESPACE : SEPARATE CODE
            // main() always runs first
            //  .sln     SOLUTION  CONTAINER FOR MULTIPLE PROJECTS
            //  .csproj  PROJECT ==> GENERATES EXE OR DLL LIBRARY

            // OPERATOR

            // increment  ++  and decrement --
            // rule : put ++ on separate line

            // boolean
            var isOff = true;
            var isOn = false;



```

Compile : turn .cs code into .exe binary or .dll binary

.NET : Can use multiple languages C# C++ which all compile to CIL intermediate language

.NET CORE : websites

Main() method has string[] array called 'args'

	myapp 1 2 3   sends 1 2 3 as 'arguments'


Debugging

	How to stop a program and inspect the variables???

	Set a breakpoint!!!  

	F5 to start

	F10 or F11 to continue stepping through program

	Conditional debug : only break if a certain condition is met !!!!

	Watching a variable 

		Right click and watch

	Autos : very useful : just shows all of variables in use ON THIS LINE OR PREVIOUS LINE  (Variables in 'scope')


Running an application in 'debug' mode or 'release' mode

	DEBUG ==> SLOWER

	RELEASE ==> PRODUCTION ie debug tools turned off


		SET THIS IN  BUILD=>CONFIGURATION MANAGER => DEBUG/RELEASE

				((Similar to 'minification' in Javascript world  .min.js faster))

		F5 => DEBUG

		CONTROL + F5 ==> RELEASE



WPF application demo

	Current app in Windows 

		WPF = WINDOWS PRESENTATION FOUNDATION

	WPF uses XML for graphic interface

	<window ...>  main graphics  .xaml     eXtensible Application Markup Language

		.cs  'code-behind'    ie 2 files (XML and .cs)  for every page		




Rounding Errors In Computing

	Computers cannot store decimal numbers accurately


		eg 10.1 cannot be stored 100% accurately on a computer

				Computers think in powers of 1,2,4,8, 16 etc and decimal is an 'alien'
				numbering structure

	Worked example to illustrate this

```cs
double total = 0;
for (int i = 1; i <= 8192; i++)
{
    total += 0.7;
}
Console.WriteLine(total);

// after 8000 loops, 9 decimal places is enough
// for us to lose accuracy++++++


decimal total2 = 0;
for (int i = 1; i <= 8192; i++)
{
    total2 += 0.7M;
}
Console.WriteLine(total2);

```	

Other data types

null

```cs
string x = null;
string y = "";
Console.WriteLine(x == y);  // false

// If reading from database and there
// literally is no data coming in,
// then that's a 'null'

// integers : default value is '0'
int z = new int();
Console.WriteLine(z);

// Scenario : reading numbers from database
// Want to differentiate from '0' and blank space

// nullable integer
int? zz = 0;
zz = null;
```


DateTime

```cs

// declare date
// not very helpful : default date is 1 Jan 0001 at midnight
var d = new DateTime();


Console.WriteLine(d);

var e = DateTime.Today;   // midnight 
var f = DateTime.Now;     // now


Console.WriteLine(e);
Console.WriteLine(f);

// add calendar day/week/month
e = e.AddDays(1);
e = e.AddMonths(1);
e = e.AddHours(1);

Console.WriteLine(e);

// elapsed time
// use seconds, milliseconds, ticks (10-7 seconds ie 100 nanoseconds!)

// CRUDE : SUBTRACTING TIME
var start = DateTime.Now;

int total = 0;

for(int i = 0; i < 100000000; i++)
{
    total += i;
}

Console.WriteLine(total);

var stop = DateTime.Now;

Console.WriteLine($"Counting took {(stop - start)}");
Console.WriteLine($"Counting took {(stop - start).Milliseconds}");
Console.WriteLine($"Counting took {(stop - start).Ticks}");


// EASY WAY : CREATE 'STOPWATCH'

var s = new Stopwatch();
s.Start();

total = 0;

for (int i = 0; i < 100000000; i++)
{
    total += i;
}

s.Stop();
Console.WriteLine(s.ElapsedTicks);
Console.WriteLine(s.Elapsed);
```



### bytes

Bytes are important 

	raw data is stored in bits = 1 or 0

	bytes are blocks of 8 bits   10101010

		bytes can have min value 0 (00000000) and max value 255 which is all 1's (11111111)

	nibble are blocks of 4 bits 1010  with min 0 (0000) and max 15 (1111)

				                             HEX  0.9     A=10,B=11,C=12,D=13,E=14,F=15	
```cs

            byte b = 0b10101010; // latest c# has literal binary type

            // also use hex

            byte bb = 0xFF;   // f=15 decimal = 1111 binary
                              //   FF = 11111111 in binary

            byte bbb = 15;

```


Bytes become useful with	a) Encryption
	b) Sending data : STREAMING : data is sent in chunks of BYTES

			byte[] array of bytes to send raw data


 
Char

	ASCII is a numbering system for basic characters

	Each 'character' has a related number and we call this  a 'char' data type

```cs
char c = 'f';
Console.WriteLine(c);
// convert to a number using (int) (casting)
Console.WriteLine((int)c);

char c02 = 'g';
Console.WriteLine(c02);
// convert to a number using (int) (casting)
Console.WriteLine((int)c02);

// Convert a number to a character
char c03 = (char)104;
Console.WriteLine(c03);
```	

Char is useful to parse strings character by character

```cs
string s = "abcdef";
foreach (char item in s)
{
    Console.WriteLine(item);
}
```


Encoding!

ASCII counts from 0 to 127

Web : count from 0 to 255 and call this UTF8  (internet, default way write text)

C#  : uses the upgrade to this called UNICODE OR UTF16 and this means 16 bits for every character 
	used.  Reason we use this ==> allows for Chinese and other non-english characters



### raw object data type

In most computing languages 'object' is the parent of all other data types

```CS
// raw objects

object o1 = 10;
o1 = "hi";
Console.WriteLine(o1);
object o2 = "hi";
object o3 = false;

// custom
// key/value pairs
object o4 = new
{
    name = "Bob",
    dob = "20/3/2000"
};


// BAD BAD CODING BUT JUST FOR ILLUSTRATION!!!
dynamic o5 = 12;
o5 = "hi";
o5 = false;


// const

const string DONT_CHANGE_ME = "I don't change";
// DontChangeMe = "to something else";

```


## Casting

C# is 'strongly typed' so int, double are 'different'

2 ==> 2.0      IMPLICIT (= SAFE) CASTING

2.3 ==> 2  (LOSE DATA)     EXPLICIT (=DANGEROUS) CASTING 

	CASTING

```cs
// SAFE CASTING

int i = 10;
double d = i;


// EXPLICIT (DANGEROUS) CASTING
double dd = 10.79;
int ii = (int)dd;
Console.WriteLine(ii);

// different to rounding

Console.WriteLine(Math.Round(dd));
Console.WriteLine(Math.Floor(dd));
Console.WriteLine(Math.Ceiling(dd));
```


BOXING

```cs

// boxing is same as casting but to object

int iii = 100;
object ooo = iii;

// unbox

int jjj = (int)ooo;

```




## AND/OR/XOR

Truth table

AND OPERATOR 

										 OUTPUT    : ARE THEY BOTH ON?  (AND)      

	INPUT    1     1                     							HIGH (TRUE OR 1)
            high  high


             0     0												LOW (FALSE OR  0)
             low   low 


             1     0												0

             0     1												0



OR OPERATOR

			INPUT    		OUTPUT (ARE EITHER OF THEM HIGH)
			1 1 						1
			0 0 						0
			1 0 						1
			0 1 						1


// ^ XOR

// SAME AS OR BUT FALSE IF BOTH HIGH		ARE ONE (AND ONLY ONE) OF THEM HIGH?	

		1 1      0
		1 0      1
		0 1      1
		0 0      0

		1^1     RETURN FALSE
		1^0            TRUE











## OOP Object Oriented Programming

Intro to OOP!!!

What is OOP??

### Scripting

Historically computing was created with 'batch files' which run 'top-down' ie start at line 1 and run to close

### .bat

Windows 'batch' file

run with myScript.bat

also .cmd works as well

### .ps1

Same thing but with  more powerful scripts

Remember : must allow Powershell scripts with 'Set-ExecutionPolicy Unrestricted'

Run file with ./myScript.ps1

### Linux computer 'BASH' shell does similar work


## OOP 

With GUI (Graphic User Interface) all of a sudden users interact with screen 'objects' eg button, inputs etc

Screen 'object' and user 'event' eg click, double-click, hover, keypress, select etc

New style of coding where no longer 'top-down' scripting but code attached to indiviual objects or events.

Much simpler to maintain as code is naturally 'modular' and tied to objects/events.

Javascript 'onclick' handler and 'click' event

	Button addEventListener('click', function(){ // do some stuff })

CSharp in 'WPF' graphic app we similar structure

	Button_01_Click(object sender, eventArgs e){  // do stuff here }

		'sender' object would be our button
		eventArgs 'e' would contain ARRAY OF STRINGS PASSED FROM BUTTON TO OUR EVENT HANDLER CODE (METHOD)

How do we create objects in C#?

	Manually ==> Object o = new {  name="fred",age=21 }

But say we have 1000 cars in a factory : we want to be able to create 1000 'car objects' with fixed structure - how do we create our 'template' for a new car?

    car01 = { weight:1000, length:2000, width:1500, color:"red" }


The template we use is called a 'Class'

	Class Car {


	}


The reason we use classes is similar to nature

In nature we have 'genus' or 'species' = 'class' of animal or plant

mammal

		cat
				lion
						american lion
						asiatic lion

				tiger


				cheetah



		dog


reptile


car
	mercedes
			a-class
					A180D
							sport
					A35


Let's create some code ...

```cs
    class Parent
    {
        public string Name;
        public int Age;
        public double Height;
    }
```

We think of 'class' as 'blueprint' for new objects

When we create a building the 'blueprint' is the master drawing.  Builders would then create real building from our blueprint

Computing : blueprint ==> 'class'
	
	From class ==> create 'real' object (real Parent)  ==>  INSTANTIATION



```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_24_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var p01 = new Parent();
            p01.Name = "Father";
            var c01 = new Child();
            c01.Name = "Child";
            // give age
            c01.Age = 12;
            // make grow in loop : 10 times
            c01.Grow();
            c01.Grow();
            Console.WriteLine(c01.GrowReturningAge());  //increase age, print new age
            Console.WriteLine(c01.GrowReturningAge());
            Console.WriteLine(c01.GrowReturningAge());
            var newAge = c01.GrowReturningAge();
            newAge = c01.GrowReturningAge();
        }
    }

    class Parent {
        public string Name;
        public int Age;
        // age
        public void Grow() {
            Age++;
        }
        // grow
        public int GrowReturningAge()
        {
            Age++;
            return Age;
        }
    }

    class Child : Parent { }
}


```

## Methods

```cs
            // void method

// return int
int ReturnNumber()
{
    return 12;
}

// return string
string ReturnText()
{
    return "some text";
}

// CALL THE METHODS
ReturnNumber();    // WASTING THE OUTPUT; NOT USING IT!!!
ReturnText();
// use the output
var output1 = ReturnNumber();
var output2 = ReturnText();
// print outputs
Console.WriteLine($"output 1 is {output1} and output 2 is {output2}");
Console.WriteLine($"output 1 is {ReturnNumber()} and output 2 is {ReturnText()}");


// PASS IN INPUT ALSO INTO A METHOD
void PrintNumber(int myNumber)
{
    Console.WriteLine($"Your number is {myNumber}");
}

PrintNumber(10);
PrintNumber(100);
PrintNumber(1000);


// send in data and get data back
double Cube(int myNumber)
{
    return Math.Pow(myNumber, 3);
}

Console.WriteLine(Cube(10));
Console.WriteLine(Cube(11));
Console.WriteLine(Cube(12));

```



	
## Finish off day with some more simple coding

### if..else if .. else

  int x = 100;

  if (x == 10){ .. }
  else if (x == 20) { }
  else {   }

### Ternary operator

  (Test a condition : is it true or false?) ? if true do this
  			:  if false do this ;

















## Collections

### List<T> 

List<int>
List<string>
List<AnyType>
T = Type : Generics  (Generic item is a general item)
using System.Collections.Generic;  is required
List has an INDEX LIKE ARRAY [0] first item, [1] second item etc
	So for this reason we can use any methods which are valid over arrays
	including List01.ForEach() method

	Note : Arrow notation (Lambda) is used often to replace a longer method

List.Add(item)  (end)
List.Insert(item,index)
List.RemoveAt..
               0 1 2 3 4
               insert new item at index 2 : push others along 
               0 1  (new item at 2)  3 4 5
foreach(var item in MyList){
	cw(item)   in numeric order of index ie 0 1 2 3 etc
}
Unlike array, can extend.
.Concat() method 
Yes it is possible to do List<List<int>>


```cs
        static List<int> list01 = new List<int>();
        List<string> list02 = new List<string>();

        static void Main(string[] args)
        {
            list01.Add(10);
            list01.Add(20);
            foreach (var item in list01) {
                Console.WriteLine(item);
            }
        }
```

### Stacks

Stack<int>
Stack<string>

Stacks are useful actually inside real computers 

			z=30
		DoThat()
			y=10
			x=20;
		DoThis();
		Main();
		==========STACK MEMORY==============

We call this a LIFO structure : Last in - First out and the picture is that of either a pack of cards or a rugby scrum.

Methods : Push() and Pop()
		Push : add to top
		Pop  : remove from top
		Contains : searches (quite slow) through stack one item at a time : output
				is boolean if a match is found
		Peek : inspect top item without removal


### Summary so far

	List : good thing is that we can extend and it has an index

	Stack : similar to real computer - how it actually runs your programs

	Array : fixed size but easily fastest for Read/Write operations


### Queue

Queue uses FIFO structure : First in first out

	Think  : quiet village where people queue for a bus : first person in queue is also
			first person to get on the bus

			Computing : use this a lot for 1) Batch processing 2) Printing 3) Emails


	Methods : Enqueue(10)   add item
			  Dequeue       remove
			  Contains
			  Peek

   Lab : Write a little lab to queue up 10 integers, check if an item is contained within, peek the first item, and dequeue 3 items then print the queue out with a
   foreach loop




## Review Of Classes with Fields And Properties

field = private
property = public

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_31_classes_with_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Parent();
            p.SetHidden("hello private data");
            p.Age = 23;
            p.Height = 1500;
            Console.WriteLine(p.Height);
            p.Height = -1500;
            Console.WriteLine(p.Height);
        }
    }

    class Parent {

        private string _hidden;  // private field
        private double height; // private field
        public int Age { get; set; }  // public property : abbreviated form
                                       // auto-implemented properties

        // expanded form

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value > 0)
                {
                    height = value;  // value is c# code word
                }
            }
        }



        public void SetHidden(string setData)
        {
            _hidden = setData;
        }
        public string GetHidden()
        {
            return _hidden;
        }
    }
}


```


## Methods

`out` keyword
optional parameters
named parameters
static method
instance method
overloading
passing 'by value' and 'by reference'
passing objects into method


There are 3 places we can declare a method

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_32_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. in another method (not recommended as gets messy with 'nesting')

            void DoSomething()
            {
                Console.WriteLine("Hey I am doing something");
            }

            // call it
            DoSomething();

            // call static method
            DoSomethingElse();

 
        }


        // 2. In the same class using STATIC KEYWORD WHICH ATTACHES METHOD TO THIS CLASS
        static void DoSomethingElse()
        {
            Console.WriteLine("Hey I'm now doing something else");
        }


    }


    // 3. in another class either as STATIC or INSTANCE method

    class Dog
    {
        // instance method
        public void Bark()
        {
            Console.WriteLine("dog is now barking loudly");
        }

        // static field
        public static int NumLegs = 4;



    }

}

```


### Return type

void DoThis(){}
string DoThat(){ return "hi"; }
bool DoNow(){ return true; }


### Parameters

Pass data into method

void DoThis(int x, string y){  // use x, y }

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_33_parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            DoThis(10, "hello world");
            var listOutput = BuildAList(100, 200, 300); // using list
            listOutput.ForEach(item => Console.WriteLine(item));
        }

        static void DoThis(int x, string y)
        {
            Console.WriteLine(x + " " + y);
        }

        static List<int> BuildAList(int x, int y, int z)
        {
            var list = new List<int>();
            list.Add(x);
            list.Add(y);
            list.Add(z);
            return list;
        }

    }
}


```


### Out parameter for methods

By default, methods only return a single item eg void, int, string

But we can also add `out` parameters as well


```cs
var listOutput = BuildAList(100, 200, 300, out bool isLong); // using list


        static List<int> BuildAList(int x, int y, int z, out bool isLongList)
        {
            var list = new List<int>();
            list.Add(x);
            list.Add(y);
            list.Add(z);
            if (list.Count > 10)
            {
                isLongList = true;
            }
            else
            {
                isLongList = false;
            }
            return list;
```


### Optional parameters

Often we have programs which accept many many parameters but not all of them are required all of the time

If we supply default values then these parameters now become optional

Note that optional parameters always must come after required parameters

```cs
        static void Main(string[] args)
        {
            DoThis(10, "hi", true);
            DoThis(10, "hi");
            DoThat(1, 2, 3, 4);
            DoThat(10,2);
        }

        static void DoThis(int x, string y, bool z = false)
        {

        }

        static void DoThat(int a, int b=5, int c=6, int d=7)
        {

        }

```


### Named Parameters

Named parameters are useful when we have a lot of parameters and don't want to have to remember the order each time.

We just call the method using MyMethod(x:5,y:6,z:7) etc 





### Constructor Methods

In every class we also have a default method called the `constructor`.

This is used to `construct` a new object when we `instantiate` the class

```cs

    class Program
    {
        static void Main(string[] args)
        {
            var p = new Parent("fred",32);

        }
    }

    class Parent {
        public string Name { get; set; }  //  Property
        public int Age;                   //  Field
        // create a constructor : same name as class
        // this keyword refers to 'instance' ie 'p' above
        public Parent(string name, int age) {
            this.Name = name;
            this.Age = age;
        }
    }
```

Note : constructor is present even when we don't code one.

Default (blank) constructor which is why we use new ... keyword with Class name and brackets

```CS
	var p = new Parent();    // calling CONSTRUCTOR METHOD HERE!
```

But be aware when you code your OWN CONSTRUCTOR, the default (blank) one no longer exists

Be aware for the future that there is also a method called the `destructor` or `finalizer` which can be called when we are destroying an object.  It looks like

  ~MyClass{
  		// code which runs when destroying an object
	}

But!!! C# won't require to use them unless we are dealing with objects outside C# like files, databases, computer memory.

	Actually a cleaner way of using these : using(){} block





### Overloading


Overloading allows us to call the SAME METHOD WITH DIFFERENT PARAMETERS

	DoThis();
	DoThis(10);    
	DoThis(10,20,30);

```cs
    class Program
    {
        static void Main(string[] args)
        {
            // must instantiate first
            var p = new Parent();
            // can now run INSTANCE METHOD
            p.DoThis();
            p.DoThis(10);
            p.DoThis("hi");
            p.DoThis(10, "hi", true);
            
            // or a STATIC METHOD
            Parent.DoThat();  // same for all instances
            
        }
    }

    class Parent {
        public void DoThis() { Console.WriteLine("no parameters"); }
        public void DoThis(int x) { Console.WriteLine("integer parameter"); }
        public void DoThis(string y) { Console.WriteLine("string parameter"); }
        public void DoThis(int x, string y, bool z) { Console.WriteLine("3 parameters"); }
        public static void DoThat() { Console.WriteLine("static method"); }
    }
```




### Passing integers into a method `by reference`  

	`ref` keyword which allows us to track the integer inside the method

	Normally when we pass an integer into a method it's treated as PRIVATE OR LOCAL INSIDE THE METHOD

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_37_by_reference
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare integer
            int x = 1000;
            DoThis(ref x);
            Console.WriteLine($"x in the main method is {x}");
        }

        static void DoThis(ref int x) {
            x = x + 1;
            Console.WriteLine($"x in the method is {x}");
        }
    }
}
```



### Passing an OBJECT into a method

Objects by nature don't need the `ref` keyword - they will be tracked even when we pass them into a method

Let's create an instance p of a class and pass it into a method

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_38_pass_object_into_method
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Animal("lion",12,200);
            var b = new Animal("tiger", 13, 150);
            ProcessAnimal(a); // 
            ProcessAnimal(a);
            Console.WriteLine($"after processing animal has age {a.Age} and weight {a.Weight}");
        }

        // process animals
        static void ProcessAnimal(Animal animal) {
            var newAnimal = new Animal(animal.Type, animal.Age, animal.Weight);
            // .. process newAnimal;
            animal.Age++;
            animal.Weight += 20;
        }
    }

    class Animal {
        public string Type { get; set; }
        public int Age { get; set; }
 
        // constructor
        public Animal(string type,int age,double weight) {
            this.Type = type;
            this.Age = age;
            this.Weight = weight;
        }
    }


}



```




## Polymorphism

When dealing with inheritance there may be a method in the parent which is also in the child class.  It may be that we want the method to run differently in the parent compared with the child.  Also possibly different for different child classes.


	Human example : HAVE A PARTY!!!

			Parent : HaveAParty(){  // posh dinner party }

					Child1 : HaveAParty(){  // swimming }

					Child2 : HaveAParty(){  // quasar   }

					Teenager : HaveAParty(){  // out with friends }


```cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_39_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new BaseParent();
            p.HaveAParty();
            var c = new DerivedChild();
            c.HaveAParty();
            var d = new DerivedTeenager();
            d.HaveAParty();
        }
    }

    class BaseParent {
        // Parent is VIRTUAL (can be overridden)
        public virtual void HaveAParty() { Console.WriteLine("Having A Dinner Party"); }
    }

    class DerivedChild : BaseParent{
        // child OVERRIDES code of parent (optionally)
        public override void HaveAParty() { Console.WriteLine("Having A Swimming Party"); }
    }

    class DerivedTeenager : BaseParent {
        // child OVERRIDES code of parent (optionally)
        public override void HaveAParty() { Console.WriteLine("Going Out With Friends"); }
    }
}


```


### Overload vs Override

Note : in the above code we are using

	Parent Base Class : virtual keyword

	Child Derived Class : override keyword


		POLYMORPHISM : OVERRIDE (Same method with different code)

This is different to methods with OVERLOAD (Same method with different parameters)


Remember

	OVERRIDE : Polymorphism : Same method different code

	OVERLOAD :              : Same method different parameters





## Abstract Classes

Imagine we have a great idea for a holiday or a business venture!  We may pinpoint certain aspects of the venture, but omit many of the other details.  Our holiday has SOME PARTS PLANNED but OTHERS OMITTED.

We can say

	class Holiday

		void ThisPartAllPlannedOut(){ // do stuff in detail };

		void ThisPartNotPlanned(){  // no code !!! }

When we write this code we change it to the following:

	abstract class Holiday

		void ThisPart....    (no change here)

		abstract void ThisPartNotPlanned();        // add 'abstract' and omit blank braces {}


Abstract class has one or more abstract methods

If we think about it, we cannot go on holiday until we fill in all the blanks.  Therefore with our Holiday class we cannot INSTANTIATE IT because it's got empty (abstract) parts!

In order to fill out the blanks, we must first `derive` a child class which inherits from Holiday but also fills out all the blanks => Then we can instantiate it.

	It's a bit like giving our holiday plans to a tour operator who book all the practicalities.




```cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_40_abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            // var h = new Holiday();
            var h = new LetsGo(); // hey we're off!
        }
    }

    abstract class Holiday
    {
        // REAL METHOD
        void VisitGeysers() { 
            // wow - have a great time! 
        }
        // ABSTRACT METHOD
        public abstract void GettingToIceland();
    }

    class LetsGo : Holiday
    {
        public override void GettingToIceland()
        {
            // yes we do travel by plane and hire a car
        }
    }
}

```



## Homework End Of OOP Day 2

We have covered a lot today as it incorporated Thursday's work and today's work (2 days)

Overnight please code me an example on EVERY TOPIC COVERED

List<int>;
List<char>;
Stack : 10 items, push & pop
Queue : 10 items, enqueue & dequeue
Classes : Parent, Child, Grandchild and create FIELDS PROPERTIES METHODS and INSTANTIATE new instances of parent, child and grandchild and use Grow() as the method to add 1 to age
Methods : call a method with 5 parameters : some optional
Methods : call same method with named parameters
Methods : passing object : Create a dog object and pass into method so it grows by 1 year (Age property)




## Wednesday Term Review

Polymorphism

Virtual (in Parent Base Class)    virtual MyMethod() {  // code }
Override (in Child Derived class)  override MyMethod() { // other code }    OPTIONAL OVERRIDE



Abstract (in Parent Base Class)      abstract MyMethod();
Override (in Child Derived Class)    override MyMethod(){  // some code }     MANDATORY OVERRIDE


Override : Same method name but different code body
Overload 
	MyMethod(){}
	MyMethod(int x){}
	MyMethod(string y){}
	MyMethod(int x, string y){}


	call   MyMethod(10);  ==>  choose second option!
	call   MyMethod(20,"hi") ==> choose fourth option!

Constructor
	Class MyClass{
		public int MyProperty {get;set;}

		public MyClass(int myproperty){
			this.MyProperty=myproperty;
		}
	}


	now we can create a new object with       var c = new MyClass(10);     Instantiation

Default constructor : present even if we don't code it!

	Class MyClass{

	}

	same as

	Class MyClass{

		public MyClass(){}

	}

Finally, when we add ANY CONSTRUCTOR the default one disappears!!!

string MyMethod(int x, string y, bool z=true, out int a);

	This method will return string and int

	string MyMethod(int x, string y, bool z = true, out int a){
		a = 101;
		return "some string";
	}

call it with MyMethod(y:"hi",z:false,x:200,out int a);

Method : pass in an integer/bool/char  (simple types  "PRIMITIVES") ==> use 'ref' keyword so that inside method the 'primitive' is treated like a global variable.  Any changes are also reflected outside the method, not just inside it

	int x = 1000;
	MyMethod(ref int x);

	void MyMethod(ref int x){
		x++;
	}

Method : pass object in

	void MyMethod(Dog d){
		d.name="Fred"
		d.age++;
	}


	class Dog{
		string name{get;set;}
		int age{get;set;}
	}

	Main ==> var d = new Dog();
	         MyMethod(d);  ==> passing dog 'd' into this method where give it new name and make 1 year older


Class MyClass{
	
	string x;
	static string y;

	MyMethod(){}
	static int MyMethod2(){ return 500; }

}

	static ==>     MyClass.y  or MyClass.MyMethod2()

	instance member ==>    var m = new MyClass();
	                       m.x  
	                       m.MyMethod();





## Testing

What is testing?

	With testing we can validate

		For a given input that the output is as expected.
		Check quantity, type, even if an exception (error) gets `thrown` at right point.

	We cannot fully eliminate EVERY BUG!

	But, over time, we can accumulate tests to prove more and more accurately that our code works.

	We can also prove, contractually, that our code meets our side of the `bargaining table` ie we have built what the customer requires ==> testing can actually prove this, with documentation.


DevOps ==> Code ==> Tested ==> Implemented on a production server : PIPELINE (automate as much as possible)

	==> Testing today has become an INTEGRAL PART OF THE DEVELOPER'S LIFE-CYCLE for BUILDING MODERN CODE.

			Old days ==> DEV ==> give work to TESTER

			Today ==> Write tests FIRST (TDD TEST DRIVEN DEVELOPMENT) 
				  ==> Pass Tests
				  ==> Push to production

				  BDD (Behaviour Driven Development)  : tests written in human-readable English and 
				  			translated into code for us (Gherkin syntax)


Visual Studio

	NUGET ==> ADD 3RD PARTY PACKAGES 

		NUNIT
		XUNIT

	MSTEST is built in to Visual Studio


Practicalities

	Give meaningful names to Class and Methods in testing module

	Code 		

			// arrange  : initialise 

			// act : run code

			// assert : test if pass/fail


	Nuget : install NUNIT




## Working With Databases

With C# we can work with traditional SQL directly.

	Install database
	Talk to it
	Use regular SQL commands

This is rather slow for the developer, and rather 'yesterday' though, but it still all works.

Today we have a slightly more modern way of interacting with databases

	Entity Framework

		Interact with 1) SQL 2) SQLite (mobile devices ie local, small database)

		Entity can be used to `scaffold` much of our code for us (scaffold = build)

			1. Database First ==> Build our database + tables + fields + primary keys etc and any relationship between tables.   Entity builds for us, in code, all classes etc needed so we just use these Entity classes and we can easily talk to the database through this.

			2. Code First ==> Build our CLASSES AND PRIMARY KEYS AND RELATIONSHIPS BETWEEN TABLES FIRST, then Entity will actually create the necessary database items for us!

Practical Realm

	1. Database ==> from Microsoft 'Northwind' database

		install the .sql file

		(localdb)\mssqllocaldb
	

SQL

select * from customers where CustomerId = 'ALFKI'
update customers set City = 'PhilsPalace' where CustomerID = 'ALFKI'
select * from customers where CustomerId = 'ALFKI'
insert into customers (customerid,companyname,contactname,city) 
values ('phil3','philsco','phil','here')
select * from customers where customerid = 'phil3'
delete from customers where customerid = 'phil3'
select * from customers where customerid = 'phil3'


So far
	Installed a database from an SQL script
	Accessed database from Visual Studio
	Run raw SQL queries

Next
	Talk to the database with Entity Framework


```cs

namespace lab_43_entity
{
    class Program
    {
        static Customer customerToUpdate;
        static Customer findOneCustomer;

        static void Main(string[] args)
        {

            // automatically clean up database connection when done
            using (var db = new NorthwindEntities())
            {
                var customers = db.Customers.ToList();

                foreach(var customer in customers)
                {
                    Console.WriteLine(customer.CustomerID);
                }

                foreach (var c in customers)
                {
                    Console.WriteLine($"ID is {c.CustomerID}, name is {c.ContactName}");
                }

                // update one customer
                //                all customers where  (just select the one with right id) . just choose first
                customerToUpdate = db.Customers.Where(cust => cust.CustomerID == "Phil1").FirstOrDefault();
                customerToUpdate.City = "PhilsCity";
                db.SaveChanges();




            }

            using (var db = new NorthwindEntities()) {
                findOneCustomer =
                    // select all customers in db.Customers
                    (from cust in db.Customers
                     // just choose this one only
                     where cust.CustomerID == "Phil1"
                     // select that one customer
                     select cust).FirstOrDefault();
                Console.WriteLine($"\n\nUpdated customer has new city = {findOneCustomer.City}");
            }

            try { // contact database
            }
            catch { // any errors
            }
            finally { // close database
            }

        }
    }
}
```


Thursday morning

### Continuation of Entity 

### Summary of actions so far

	1. Add Entity to project

	2. Query Northwind

	3. Updated Existing Record

	4. Inserted New Record

	5. Deleted Record


### Summary Of Entity : 4 CRUD Operations (Create, Read, Update, Delete)

```cs

            // encapsulates database for easy cleanup afterwards
            using(var db = new NorthwindEntities())
            {
                // standard LINQ query
                customerList =
                    (from c in db.Customers
                     select c).ToList<Customer>();

                foreach(Customer c in customerList)
                {
                    Console.WriteLine($"ID : {c.CustomerID}, " +
                        $"Name : {c.ContactName}, City : {c.City}");
                }

                // select one customer and update
                customer = db.Customers.Where(cust => cust.CustomerID == "FRANK").FirstOrDefault();
                customer.City = "BERLIN";
                db.SaveChanges();

            }

            // check if the update has worked : query database from scratch again
            using (var db = new NorthwindEntities())
            {
                foreach (Customer c in db.Customers)
                {
                    Console.WriteLine($"ID : {c.CustomerID}, " +
                        $"Name : {c.ContactName}, City : {c.City}");
                }

                // LINQ LAMBDA QUERY
                customer = db.Customers.Where(cust => cust.CustomerID == "FRANK").FirstOrDefault();
                Console.WriteLine($"{customer.CustomerID}, {customer.ContactName},{customer.City}");

                // LINQ STANDARD
                customer =
                    (from cust in db.Customers
                     where cust.CustomerID == "FRANK"
                     select cust).FirstOrDefault();
                Console.WriteLine($"{customer.CustomerID}, {customer.ContactName},{customer.City}");
            }

            // insert new
            using (var db = new NorthwindEntities())
            {
                newCustomer = new Customer(){
                    CustomerID="Phil6",
                    ContactName ="Bob",
                    CompanyName="SpartaGlobal",
                    City="London"
                };
                db.Customers.Add(newCustomer);
                db.SaveChanges();
            }

            // query 
            using (var db = new NorthwindEntities())
            {
                customer = db.Customers.Where(cust => 
                    cust.CustomerID == "Phil6").FirstOrDefault();
                Console.WriteLine($"Creating new record : {customer.CustomerID}, " +
                    $"{customer.ContactName},{customer.City}");
                
            }

            // delete this new record
            using (var db = new NorthwindEntities())
            {
                // select customer
                customer = db.Customers.Where(cust =>
                    cust.CustomerID == "Phil6").FirstOrDefault();
                // delete customer
                db.Customers.Remove(customer);  // deleting local copy of this customer
                Console.WriteLine("deleting Phil6");
                db.SaveChanges();               // commiting deletion to the database
            }

            // query 
            using (var db = new NorthwindEntities())
            {
                customer = db.Customers.Where(cust =>
                    cust.CustomerID == "Phil6").FirstOrDefault();
                if (customer!=null)
                {
                    Console.WriteLine($"{customer.CustomerID}, " +
                        $"{customer.ContactName},{customer.City}");
                }
                else
                {
                    Console.WriteLine($"Customer Phil6 does not exist");
                }


            }
```

## File Operations

We have looked at database operations : just basic 4 'CRUD' Create Read Update Delete operations

	1. Raw SQL

	2. Entity Framework

In order to build a game you might also want the ability to save, for example, a person's name permanently or even their score or level in the game.  A database is `overkill` for trivial data items - perhaps a text file will be better?  Let's investigate simple file read/write operations.

```cs
using System.IO;
```

## Files : Summary So Far

File.ReadAllText ==> string
File.WriteAllText ==> string
File.AppendAllText ==> string

File.ReadAllLines ==> array

	Search for one term in array!  Now search a text file for 1 line match

File.WriteAllLines ==> array
File.Copy
File.Delete
if(File.Exists)
File.GetCreationTime
File.GetLastWriteTime



```CS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_45_file_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // create new file from scratch
            File.WriteAllText("file.txt", "some data");
            

            // Read 1 line of text as a string
            Console.WriteLine("\n\nRead raw data");
            string data = File.ReadAllText("file.txt");
            Console.WriteLine(data);

            // Write data
            Console.WriteLine("\n\nwriting new text");
            File.WriteAllText("file.txt", "here is some new data",Encoding.UTF8);

            Console.WriteLine("\n\nreading text back again");
            data = File.ReadAllText("file.txt");
            Console.WriteLine(data);

            // append : adds at end
            Console.WriteLine("\n\nAppending Text");
            File.AppendAllText("file.txt", "\nand here is some more data 2 " + DateTime.Now.ToString());
            File.AppendAllText("file.txt", "\nand here is some more data 3 " + DateTime.Now.ToString());
            File.AppendAllText("file.txt", "\nand here is some more data 4 " + DateTime.Now.ToString());
            File.AppendAllText("file.txt", "\nand here is some more data 5 " + DateTime.Now.ToString());
            File.AppendAllText("file.txt", "\nand here is some more data 6 " + DateTime.Now.ToString());
            File.AppendAllText("file.txt", "\nsearchterm22");
            data = File.ReadAllText("file.txt");
            Console.WriteLine(data);

            // data logging : used all the time - add a DateTime.Now
            Console.WriteLine("\n\nLogging With DateTime Stamp");
            File.AppendAllText("file.txt", Environment.NewLine + DateTime.Now);
            data = File.ReadAllText("file.txt");
            Console.WriteLine(data);




            // reading multiple lines to an array
            Console.WriteLine("\n\nSearching text file for a term");
            string[] dataArray = File.ReadAllLines("file.txt"); 
            foreach(string item in dataArray){
                if (item == "searchterm22")
                {
                    Console.WriteLine("Bingo ! searchterm22 has been found!!!" );
                }
            }
            for(int i = 0; i < dataArray.Length; i++)
            {
                if (dataArray[i] == "searchterm22")
                {
                    Console.WriteLine($"Bingo!  searchterm22 found at line {i}");
                }
            }


            // File.Copy   (true means yes overwrite 
            // if exists already)
            File.Copy("file.txt", "filecopy.txt", true);

            File.Delete("file.txt");
            File.Delete("filecopynewname.txt");

            if (!File.Exists("filecopynewname.txt")){
                File.Move("filecopy.txt", "filecopynewname.txt");
            }

            Console.WriteLine(File.GetCreationTime("filecopy.txt"));
            Console.WriteLine(File.GetLastWriteTime("filecopy.txt"));


            // folders
            // create folder
            Directory.CreateDirectory("Parent");
            Directory.CreateDirectory("Parent\\Child1");
            Directory.CreateDirectory("Parent\\Child2");
            Directory.CreateDirectory("Parent\\Child3");
            File.WriteAllText("Parent//Child3//file.txt", "hello");
            File.WriteAllText($"Parent/Child3/file2.txt", "hello");
            // delete one
            Directory.Delete("Parent/Child2", true);
            // create in C:\ drive
            Directory.CreateDirectory("/TestFolder");
            
            // create in MyDocuments
            Directory.CreateDirectory(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) 
                + "/TestFolder");

            // list all files in folder and see if one file exists!!!
            /* lab : 
             *      create folder in My Documents
             *      create 3 text files 
             *      create an array called FileList
             *      put the names of the text files into this array
             *      check if "BobsFile.txt" is one of your files!
             *      return true if it is
             * 
            */
                

        }
    }
}

```
... to complete in the morning!


## Collections

To store multiple items we have

	Arrays 					Fixed size 		Incredibly Fast!
											Each 'pigeon hole' has a unique memory address so we can read/write data instantly to that single memory location

	Collections 			Variable size   Niche roles depending upon
											your needs.  Relatively slow.

	With collections the two most useful are :

		1. Lists because they have an index just same as arrays

			First item is myList[0] etc
			Second item is myList[1] etc

		2. Dictionary

					index 	data

					10      "some"
					20      "data"
					30		"stored"
					40		"here"

				Index has to be UNIQUE

				Write dictionary as

				var d = new Dictionary<TKey,Tvalue>();  
							TKey, TValue can be ANY VALID C# TYPE

				var d = new Dictionary<int,string>();


```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_46_dictionary
{
    class Program
    {

        static void Main(string[] args)
        {
            var d = new Dictionary<int, string>();
            d.Add(10, "hi");
            d.Add(20, "there");
            d.Add(30, "amazing");
            d.Add(40, "C# coders");

            // forbidden
            //d.Add(40, "some more data");
            
            // iterate : loop over items
            foreach(var key in d.Keys)
            {
                Console.WriteLine($"Index is {key} and value is {d[key]}");
            }


            
        }
    }
}


```







## Friday : going over a few topics which we have not yet covered

## Naming Conventions

Javascript on the web uses a very simple naming convention

	camelCase

		firstLetterIsLowerCaseAndEveryOtherWordHasCapitalLetter

		doThis();

Websites tend to use hyphens to separate words

	my-website-here.com

	mydomain.com/folder1/folder2/file.htm

	all lower case, multiple-words-like-this.html

	(kebab case)

SQL
	my_data_field_01    snake case with underscore


C#

	private variables camelCaseLikeThis

		_private   also  (underscore prefix)

	Public variables : PascalCase - first letter capitalised

		DoThis()
		CustomerName   

	Class should be a Noun

		class Car
		class Dog

	Method should be a verb

		Accelerate()
		Grow()

	const int x = 1000;

		const int THIS_FIELD_DOES_NOT_CHANGE = 1000;


	Environment.NewLine  in place of \n

	Path.DirectorySeparatorChar   in place of   //  \\   $" ... / .... "

	AsyncDoThis();   any method which is going to take a long time to finish




## Break And Continue In Loops

continue will just finish this loop and begin next loop

break will finish all loops and move on to the next coding block

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_47_break_continue
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                if (i == 5 || i == 6)
                {
                    continue;
                }

                
                Console.WriteLine(i);
            }

            int counter = 0;
            while (counter < 10)
            {
                if (counter == 8)
                {
                    break;
                }
                Console.WriteLine(counter);
                counter++;
            }
        }
    }
}


```

## Return

Another way of breaking out of a method is to use the 'return' keyword

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_48_return
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = DoThis(10);
            Console.WriteLine(output);
        }

        static string DoThis(int x)
        {
            if (x < 10) return "Your number is low";
            if (x < 20) return "Your number is medium";
            if (x < 30) return "Your number is high";
            return "Your number is off the charts!";
        }
    }
}


```


## Exiting A Loop Or Method By Throwing An Exception!

Another way of exiting a loop or method is by determining that the program should 'throw' or declare an error (exception)

```cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_49_throw
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            while (true)
            {
                counter++;
                if (counter > 100000)
                {
                    throw new Exception("Number is too big");
                }
            }
        }
    }
}

```

## Goto

Never use!!!

```cs

goto a;

// some code skipped over

a:

// program continues here

```


## Try..Catch..Finally

When we write a computer program we have two types of fault

	1) Error

			If you get a bank loan and they overcharge your interest, this is an error in the banking code!!!  Computer will work fine!!!

	2) Exception

			Something has happened which crashes the computer

				StackOverflowException : numbers too big / out of memory
				DivideByZeroException
				FileNotFound


### Handled vs Unhandled Exception

	With exception we don't want user to get a nasty 'program has crashed' message

	Handled 		we detect exception and handle this 'gracefully'

	Unhandled 		computer crashes; user sees nasty message


### try.catch.finally

```

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_50_exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                // something can go wrong here
            }
            catch(Exception e) {
                // process the 'exception' ie 'handle it'
                Console.WriteLine(e);
                Console.WriteLine(e.Data);
                Console.WriteLine(e.Message);
            }
            finally {
                // always do this code regardless if exception or not
            }

            // divide by zero
            int x = 10, y = 0;



            try {
                int z = x / y;
            }

            // catch divide by zero exception only
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error - division by zero");
                Console.WriteLine(e.Data);
                Console.WriteLine(e.Message);
                System.IO.File.WriteAllText("errorlog.txt", "major malfunction" + DateTime.Now);
            }
            // catch every exception of all types
            catch (Exception e) {
                Console.WriteLine("OOPS! SNAP! Something went wrong!");
                Console.WriteLine(e.Data);
                Console.WriteLine(e.Message);
            }
            finally {
                Console.WriteLine("but program is still working");
            }

            Console.WriteLine("Program still works here");
        }
    }
}


```



### Throwing An Exception

We can generate our own exceptions 

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_51_throw
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                var output = TryThis();
                if (output == -1){
                    throw new Exception("Hey something really badly went wrong");
                }
            }
            catch (Exception e){ 
                Console.WriteLine(e.Message);
            }
            finally {
                Console.WriteLine("But program still works!");
            }
        }

        static int TryThis()
        {
            return -1;
        }
    }
}


```


## WPF Grid

Let's build a 3x3 WPF grid to show you how to lay out a game!

```cs
<Window x:Class="lab_52_wpf_grid.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:lab_52_wpf_grid"
        mc:Ignorable="d"
        Title="MainWindow" Height="Auto" Width="Auto">
    <Grid>
        <Grid.RowDefinitions>
            <!--   -->
            <RowDefinition Height="*" />
            <RowDefinition Height="*" />
            <RowDefinition Height="*" />
            <RowDefinition Height="5*" />
        </Grid.RowDefinitions>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="*" />
            <ColumnDefinition Width="*" />
            <ColumnDefinition Width="*" />
        </Grid.ColumnDefinitions>
        <Button x:Name="Button01" Background="#b3caef" 
                Grid.Row="0" Grid.Column="0" 
                Click="Button01_Click" />
        <ListBox x:Name="ListBox01" Grid.Row="3" Grid.Column="0" 
                 Background="#c9cfd8" />
        <ListBox x:Name="ListBox02" Grid.Row="3" Grid.Column="1" 
                 Background="#c9cfd8" >
            <ListBox.ItemTemplate>
                <DataTemplate>
                    <TextBlock>
                        <TextBlock.Text>
                            <MultiBinding StringFormat="ID - {0} - Name {1} - City - {2}">
                                <Binding Path="CustomerID " />
                                <Binding Path="ContactName" />
                                <Binding Path="City" />
                            </MultiBinding>
                        </TextBlock.Text>
                    </TextBlock>
                </DataTemplate>
            </ListBox.ItemTemplate>
        </ListBox>
    </Grid>
</Window>


```


## Reference Type And Value Type

In a computer we have TWO DIFFERENT AREAS OF MEMORY

	STACK

	HEAP

We have two different types of way to store data

	VALUE TYPES (LIVE ON THE 'STACK')

	REFERENCE TYPES (LIVE ON THE 'HEAP')


Stack memory

	We have already discussed STACK a litle bit



          ...Method03(){  int z = 500; }
    ...Method02()
	Method01(){  // int a=10, int b=20, bool c=false }
	Main() Method==========================


	When Method03 finishes it will peel off the top of the stack


    ...Method02()
	Method01(){  // int a=10, int b=20, bool c=false }
	Main() Method==========================

	Any variables (with data) are created and destroyed together

	STACK : RUNNING PROGRAMS & FAST DATA TYPES

		VALUE TYPES = PRIMITIVE TYPES : DATA STORED WITH VARIABLE

		int
		char
		bool
		float
		double
		byte
		short
		long

	Copy one of these variables : create brand new unrelated instance

		x=10;
		y=x;    y,x unrelated.


	Future learning : 'structs' belong here also!


## Reference Types

Value types are SMALL

For larger data items eg an array it may hold a million items!!

Can't put a million items onto a very fast 'STACK MEMORY'

Create HEAP MEMORY

	Hold larger items

		ARRAYS, QUEUE, LIST, DICTIONARY ETC

		STRING is an ARRAY of CHARACTERS!!!     "hello world"


		shortcut to MyArray ===============> MyArray[10,11,12,13.....,1000000]
		int x=12;

		FAST STACK 							SLOWER HEAP 	


		Because STACK holds SHORTCUT, if we create a copy then we don't affect the
			source item held in HEAP MEMORY


			shortcut01 to MyArray ===============> 
			shortcut02 to MyArray ===============> MyArray[10,11,12,13.....,1000000]
			shortcut03 to MyArray ===============> 


### Code Example : Copy 1) Value Type 2) Reference Type


```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_53_reference_value_type
{
    class Program
    {
        static void Main(string[] args)
        {
            // value types  -- WORK AS EXPECTED!!!!!!!!!!!!!!
            int x = 100;
            int y = x;
            Console.WriteLine($"x is {x} and y is {y}");   // 100,100
            // change ONE
            x = 400;
            Console.WriteLine($"x is {x} and y is {y}");  // 400,100


            // reference types

            var array01 = new int[] { 100, 200, 300 };
            var array02 = array01;

            // before
            foreach (int item in array01) { Console.WriteLine(item); }
            foreach (int item in array02) { Console.WriteLine(item); }
            // change ONE item
            array02[2] = 99999999;
            // after
            foreach (int item in array01) { Console.WriteLine(item); }
            foreach (int item in array02) { Console.WriteLine(item); }  
            
            // Change has affected BOTH ARRAYS!

        }
    }
}

```

Snap Labs

Build an array, queue, list, stack and dictionary.  Pass in 3 numbers to the array.  Pass the numbers in turn to the queue, list, stack and dictionary, and whenever you transfer a number also multiply it by 2.  

Return the total.

dictionary

		KEY    			VALUE

		1  				X
		2				Y
		3				Y


FOREACH( var key in myDictionary.keys){
	//	myDictionary[1]  ==> yield X
	myDictionary[key] ==> add to a total
}

PRINT TOTAL


# Git and Github

Let's look at Git and GitHub a little more seriously

Dev structure online

	Repo = Repository = your global set of code pushes ie all branches combined

	Master Branch : final production code

		Locked!  Cannot 'push' to this directly

		Dev : code in progress : sum of all developer accumulated, approved code 'pushes'

			Push ==> from local to an internet held storage 'branch' or 'repository'

			Feature : New features introduced into code 

			BugFix : fixing faults


When developer finished work, push to 'feature' branch or 'bugfix' branch

	Larger projects : both 'master' and 'dev' branches locked out.

	Dev ==> feature => push when done to internet

		Collaborator : another developer or manager etc

		Developer creates a 'pull request' and the collaborator must approve this
			and 'pull' the work of the developer up from the feature branch and into
			the working 'dev' combined branch.

		At end of project or sprint, when the combined 'dev' work has been approved,
			it too can be 'pulled' into the master branch (production-ready code)



### Quick summary of commands : git in 'local' realm on your PC!

git -version    installed

git init 		create a new project locally, then push it to the internet

					((prefer to create online first))

git status 		shows any changed files ready to commit

git add file.txt   track this file so we can commit changes (and roll back if necessary)

git add .       track all files

git reset file.txt   un-track this file so changes are not recorded	

.gitignore 		Don't track files/folders at all in here

git clone   	https://github.com/philanderson888/deletemetest01

Adding your text editor to your PATH
	
	PATH is a SET OF FOLDERS checked automatically when there is no ABSOLUTE PATH

		ABSOLUTE PATH BEGINS  C:\....    OR  / on Linux

		RELATIVE PATH myfile.txt 

	Open 'Environment Variables'

		Add path to Chrome or Sublime Text 3 into your PATH (system) 

	Close Powershell and reopen


# Push To Internet

We now have a local repo.

git remote

git push

git pull

git config


# git remote

git remote

git remote -v  show any remote url configured

git remote add origin https://github.com/philanderson888/deletemetest01

then 

git push -u origin master


## git pull

use to pull down remote changes


## git config

git config --global -l     	lists user account and email

// add details

git config --global user.name philanderson888
git config --global user.email philanderson888@hotmail.com



## git branch

```bash
# list all branches
git branch
# create
git branch dev 
# start working in that branch
git checkout dev 
# combine two commands in one
git checkout -b dev 
# work in master
git checkout master
```

Let's push up DEV changes

```bash
git checkout dev
# make changes
git add .
git commit -m "some changes"
git push
```

## Lock master so can't push directly

Github.com => settings => branches => add rule

## Pull request from dev to master

Add collaborator

Pull request : add reviewer and wait for response

## Pull down changes from master

```bash
git checkout master
git pull
```

## changes in master : from someone else : use `git merge` to merge master into our dev

Fake this by editing Master

```bash
git checkout master
# work from other developers (approved into master)
git pull # into our master
git checkout dev
git merge  # merge master into our local dev also
```

```bash
# seb : pushes from dev
# seb : creates pull reqest
# luitzen : approve and pull changes into master (online)
# everyone else : git checkout master & git pull 
# everyone else : git checkout dev & git merge 
# now sebastian's changes are now in my master and dev
# start work again
```

# git log

# git reset --soft

# git reset --hard


# Adding SSH keys to your GitHub account

1) Make changes using SSL or HTTPS or TLS (newer) : Encrypted HTTP traffic

	(default)

2) Make changes using SSH with a KEY stored on your machine

```bash
# create key
ssh-keygen -t rsa -b 4096
# start service
eval $(ssh-agent -s)
# add key to my account
ssh-add ~/.ssh/id_rsa
# copy key to clipboard
clip < ~/.ssh/id_rsa.pub
# log in to GitHub : Settings : Add key, paste in details
# change to use SSH
git remote set-url origin git@github.com:philanderson888/deletemetest01.git 
git checkout dev
git push origin dev
```



# SQL

Structured Query Language

We can run SQL from

	Visual Studio

	or

	SQL Server but this is a big install!

		We can create a 'container' to run SQL server inside it - will do, for interest sake

## Basic commands

```bash
use Northwind

create databasetestdb

drop database testdb  : completely erase structure and any tables inside 

create database [Dont Create Databases With Spaces In The Name]

	eg [Order Details] in Northwind!!!  must use square brackets
				as the table name has 2 words

create table table01(
 id int identity not null primary key,
 name nvarchar(50)
)

# Data types available#
int 
nvarchar(50)  : very common for strings of length up to 50 characters UNICODE 16 bit
varchar  8 bit characters
char(5)  fixed length string : same every time
tinyint  same as byte 0 to 255
bit 0, 1 or null 
decimal 
float 
date / time / datetime 

```



### alter

We can alter a table although often best practice is to drop and recreate from scratch with a script

alter table table01 alter column name varchar(10) not null;


### insert into

insert into table01 (id,name) values (8,'dave')
select * from table01

### update

UPDATE TABLE01 SET name='bill' where id=4
select * from table01

### delete

delete from table01 where id=6
select * from table01


## Types Of SQL command

DML Data Manipulation Language   	SELECT  INSERT  UPDATE  DELETE

DDL Data Definition Language 		CREATE ALTER DROP TRUNCATE

DCL Data Control Language 			GRANT REVOKE (Permissions)

TCL Transaction Control Language 	COMMIT ROLLBACK SAVEPOINT  (multiple transactions)


## Best practice

COMMANDS HAVE CAPITALS

names_underscore_separator


## RAW DATA : AND STRUCTURE

SP_HELP
SP_HELP table01

(first command)


### Normal Form

1st  single item : single field

	mobile phone    -   07777771234

2nd  fields depend on primary key

3rd  fields have no other inter-relationships with each other


### Ways to store data


10 minutes : create a database structure for blogging system

Bloggers : create posts

Users : read and comment

Comments 

Posts










## SQL revision session

DML Data Manipulation : Select, Insert, Update, Delete

DDL Data Definition : Create, Drop, Alter, Truncate

DCL Data Control : Permissions Grant, Revoke

TCL Transaction Control : Multiple related transactions : all to succeed or all to fail

		COMMIT, ROLLBACK, SAVEPOINT  (mid-point of transaction)

ALTER

UPDATE table01 SET name='fred' WHERE id=1

INSERT INTO table01 (1,'fred')

INSERT INTO table01 (id,name) VALUES (1,'FRED')

INSERT INTO table01('fred')      if IDENTITY set (ie auto-increment the ID)

CRUD  CREATE         READ       UPDATE      DELETE
SQL   INSERT INTO    SELECT     UPDATE      DELETE

Normal Form
1 one item per field
2 depend on primary key
3 no inter-relationship between fields

DBMS : DB Management System

	Access, PHPMyAdmin, MySQL, Oracle, SQLite, PostGres	

Flat file
	.txt
	.csv
	.log
	.dat
			raw plain text files storing data line by line, in order
			to get to your data you have to read every line

	CONFIG ==> CONFIGURATION

		RUNTIME ==> ALTERED WITHOUT HAVING TO RECOMPILE YOUR APPLICATION

	.sql    LISTS OF SQL INSTRUCTIONS IN ORDER - 'SEED' DATABASE IS TO PUT DATA INTO IT

JSON

	Big Data is UNSTRUCTURED key/value pairs

	NOSQL is UNSTRUCTURED key/value pairs




## SQL Day 2 : Querying Your Database : Simple and Advanced Query Syntax

```sql
use northwind
select * from customers
/* select all employees in london */
select * from Employees where city='london'
/* select title of courtesy from employees  */
select distinct titleofcourtesy from employees
/* select all employees with title 'Dr' */
select * from Employees where titleofcourtesy='Dr.'
/* select all Products which are discontinued */
select * from products
select * from products where Discontinued=1

```

### select top 5

select top 5 * from customers 
/* last 5  : order by .... descending */
select top 5 * from customers order by CustomerID desc



### SELECT .. WHERE .. AND ...

```sql
/* SELECT products where categoryid=1 and not discontinued */
select * from products where CategoryID=1 and Discontinued=0
/* SELECT name,price,cat, discontinued from 
products where categoryid=1 and not discontinued */
select ProductName,UnitPrice,CategoryID,Discontinued
from products where CategoryID=1 and Discontinued=0
```

### Operators

AND

OR

`<>`   `!=`         NOT EQUAL TO

`>`  `<`

<=  >=

Using products table create a query with these operators

```sql
/* select productname and price where item is in stock 
and price > 29.99, ordered by price */
select productname,unitprice, UnitsInStock from products 
where UnitPrice > 29.99 
and UnitsInStock > 0
order by UnitPrice desc
```

### distinct

```cs
/* distinct */
select distinct country from customers
select distinct city from customers 
```

### wildcards

LIKE ... keyword

%   0 or more

_ 	substitute for one single character

[ABC]    contains these letters

^[ABC]   does not contain

abc%     starts with abc

%xyz     ends with xyz


### LIKE %...%

LIKE - we can check for partial matches of text eg 'contains this text'

### Starts With 'abc%'

```sql
/* products starting with Ch */
select productname from products 
where productname LIKE 'Ch%'
select * from products where productname LIKE 'Ch%'
```
### using % wildcard and _ single letter wildcard

```sql
/* customers where region ends a */
select * from customers where region like '%a'
/* customers where region contains a    %a%     */
select * from customers where region like '%a%'
/* customers where region has 2 characters only, ending a  _a    */
select * from customers where region like '_a'
select * from customers where region like 'a_'
```

### OR query 

### IN query

both do same thing, more efficient 'IN'

```sql
/* customers where region = WA or SP */
select * from customers where region='wa' or region='sp'
select * from customers where region in ('wa','sp')
```

### between

```sql
/* BETWEEN */
select * from products where unitprice between 10 and 20
select * from EmployeeTerritories where TerritoryID between 06800 and 09999
```

### count

```sql
/* COUNT */
select count(productName) from products where Discontinued=0
select count (*) from customers   /* 91 */
/* remove duplicates with distinct */
select count (country) from customers   /* 91 */
select count(distinct country) from customers   /* 21 */
```

### exercises

```sql
/* products cheaper than 5 per unit */ 
select * from products where UnitPrice < 5
/* products starting with B or S */
select * from products where ProductName LIKE 'b%' or ProductName LIKE 's%'
/* orders from employees with ID 5 and 7 combined */
select * from orders where employeeid in (5,7)
/* count orders from employees with ID 5 and 7 combined */
select count(*) from orders where employeeid in (5,7)
```


### AS

```sql
select 
customerid as id, 
contactname as name, 
address + ' ' + city as address
from customers 

select 
customerid as id, 
contactname as name, 
address + ' ' + city as 'lives here'
from customers 
```

We can even omit the 'as' keyword and get the same results

```sql
select 
customerid id, 
contactname name, 
address + ' ' + city 'lives here'
from customers 
```

### Null

Filter by `null` or `not null`

```sql
/* select customers depending if region is null or not null */
select * from customers where region is not null
select * from customers where region is null
```

### Arithmetic Operators

Select `col1*col2` as 'description',....

Use the following
+
-
*
/
%  remainder after division (modululs)

```sql
select unitprice, quantity, discount, 
unitprice*quantity as 'Gross Value Of Order' from [Order Details]
/* now get the NET PRICE!!! (keep gross price) */
select unitprice, quantity, discount, 
unitprice*quantity as 'Gross Value Of Order',
unitprice*quantity*(1-discount) as 'Net Value Of Order'
from [Order Details]
/* order by new column - just use the new name */
select unitprice, quantity, discount, 
unitprice*quantity as 'Gross Value Of Order' from [Order Details]
/* now get the NET PRICE!!! (keep gross price) */
select unitprice, quantity, discount, 
unitprice*quantity as 'Gross Value Of Order',
unitprice*quantity*(1-discount) as 'Net Value Of Order'
from [Order Details] order by 'net value of order' desc
```

## String Manipulation

### CharIndex : find the (FIRST) index of a character inside a string

	(( remember a STRING is an ARRAY OF CHARACTERS ))

CharIndex('g',string)  // find location of 'g' in the string

```sql
select * from customers where PostalCode LIKE '%[a-z]'
/* get index of 'space' character ie ' ' in postcode */
select *,PostalCode, CHARINDEX(' ',PostalCode) as 'Index' from customers
where PostalCode LIKE '%[a-z]'
select Address,CHARINDEX('a',Address) as 'Index' 
from customers where PostalCode LIKE '%[a-z]'
select SUM(CHARINDEX('a',Address)) as 'Total' 
from customers where PostalCode LIKE '%[a-z]'
```

### Substring

We can extract part of a string from another string

SUBSTRING(string,startIndex,length)

	SUBSTRING('cheese',2,2) return 'he'
	SUBSTRING('cheese',2,3) return 'hee'
	SUBSTRING('cheese',2,4) return 'hees'
	SUBSTRING('cheese',3,3) return 'ees'

Let's work on the postcode

Simple way : select first 4 characters - job done!

```sql
select PostalCode, SUBSTRING(postalcode,1,4) as 'first part' from Customers 
where PostalCode LIKE '%[a-z]'
```

More profesional way - select up to the 'space' character

```sql
select PostalCode, 
CHARINDEX(' ',PostalCode) as 'index',
SUBSTRING(postalcode,1,(CHARINDEX(' ',PostalCode)-1)) as 'first part' 
from Customers 
where PostalCode LIKE '%[a-z]'
```

### left and right

We can also use `left` and `right` to select the first x or last x characters

LEFT('hello',2)   ==> 'he'
RIGHT('hello',2)  ==> 'lo'

and use this to select the last part of the postcode

```sql
select PostalCode, 
CHARINDEX(' ',PostalCode) as 'index',
SUBSTRING(postalcode,1,(CHARINDEX(' ',PostalCode)-1)) as 'first part' ,
RIGHT(PostalCode,3) as 'last part'
from Customers 
where PostalCode LIKE '%[a-z]'
```

### LTRIM (RTRIM) remove spaces from start or end

### LEN is length of string

```sql
select LEN('hello')            
select LEN('   hello')         
select LEN('          hello           ')         
select LEN(LTRIM(RTRIM('      hello      ')))  
```

### replace

replace(`some text here`,` `,`_`)   ==> `some_text_here`

### upper/lower

upper('Hello')  return 'HELLO'
lower('Hello')         'hello'


### Homework

create some queries using these  keywords on the Northwind database

1. sum

2. avg

3. Min/max

4. count

5. group by ???

6. having ???

7. inner join


### SQL Day 3

### Count, Sum, Avg, Min, Max

```sql
select * from [Order Details]

/* 2156 items */
select count(OrderId) as count from [Order Details]

select count(OrderId) as count, 
sum(UnitPrice*Quantity) AS 'total stock value',
avg(UnitPrice) as 'average',
min(UnitPrice),max(UnitPrice)
from [Order Details]
```

### Group By

Main col
	sub col  

```sql
select 
sum(UnitsOnOrder) as sum,
avg(UnitsOnOrder) as avg,
min(UnitsOnOrder) as min,
max(UnitsOnOrder) as max
from Products
```

Now sort by Supplier ID

```sql
select 
sum(UnitsOnOrder) as sum,
avg(UnitsOnOrder) as avg,
min(UnitsOnOrder) as min,
max(UnitsOnOrder) as max
from Products
where UnitsOnOrder>0 
GROUP BY SupplierID
```

### Quiz

Select average reorder level and average units on order from Products
Group by CategoryID  (have to add this as a column also)

```sql
select 
CategoryId,
avg(ReorderLevel),
avg(UnitsOnOrder)
from products
group by CategoryID
```

Sort by average reorder level descending

```sql
select 
CategoryId,
avg(ReorderLevel) as 'reorder level',
avg(UnitsOnOrder) as 'units on order'
from products
group by CategoryID
order by 'reorder level' desc
```

### order of commands

With SQL the order of commands matters

SELECT
DISTINCT
FROM
WHERE     ::: only works on existing columns
GROUP BY
HAVING    ::: can use this to filter by columns we have just created
ORDER BY

### Having

Let's filter the last query on the column we have just created

```sql
select 
CategoryId,
avg(ReorderLevel) as 'reorder level',
avg(UnitsOnOrder) as 'units on order'
from products
where CategoryID>3 
group by CategoryID
having avg(UnitsOnOrder) > 4
order by 'reorder level' desc
```

## JOINS

Select data from multiple tables

INNER JOIN

```sql
SELECT fields 
FROM table1 
INNER JOIN table2 
ON table1.field=table2.field
```

	student 						course

	studentid 						courseid
	name 							coursename
	courseid 

select all students and display their course name

1. all students
2. all courses
3. all students inner join courses : get course name

```sql
select * from student

select * from course 

select studentid,name,student.CourseId,coursename 
from student 
inner join course 
on student.courseid = course.courseid 
```
	
### Use Alias to Shorten Queries


```sql
select studentid,name,s.CourseId,coursename 
from student s
inner join course c
on s.courseid = c.courseid 
```


### Quiz

Select average (units on order) 
from products
group by supplier

Add in the supplier name also

```sql
select * from suppliers

select * from products 

select companyName, avg(unitsonorder) as 'average units'
from products p
inner join Suppliers s
on p.SupplierID = s.SupplierID
group by CompanyName
having avg(p.unitsonorder)>0
order by 'average units'
```


### Selecting Data From 3 Tables

1. Let's select all products with their Unit Price.

2. Let's get the supplier name (who supplies the product)

```sql
select p.ProductName, p.UnitPrice, s.CompanyName as 'Supplier'
from products p
inner join suppliers s
on p.SupplierID = s.SupplierID
```

3. Let's add in the Product Categories table in order to get the Product Category Name

```sql
select p.ProductName, p.UnitPrice, 
s.CompanyName as 'Supplier', 
p.CategoryID,
c.CategoryName
from products p
inner join suppliers s on p.SupplierID = s.SupplierID
inner join Categories c on p.CategoryID = c.CategoryID

```



### Methodologies : Scrum and Agile

Methodology = way of working

	SDLC Software Dev Life Cycle

		Waterfall

			Linear method of building code

				Analysis
					Talk with customer
					Feasibility study : is this project feasible?
						Initial calculations, research etc
						Basic project plan, financial plan ==> CAN IT WORK???

							RISKS => FINANCIAL, COMPETITORS, MARKET MOVEMENTS,
							         UNFORESEEN NATURAL EVENTS, FRAUD, 
							         HACKING (INTERNAL & EXTERNAL), LEGAL FROM
							         SUING YOU(ADVERTISING, PRODUCT ACCURACY, CATER FOR 'ACCESSIBILITY')

					Requirements Engineering
						Obtain list of customer 'requirements'
						    ((this becomes our 'BACKLOG' in development))

						Specify (because testing becomes more and more 
							important today) 'User Acceptance Tests' ie
							what user deems the conditions under which they 
							will say we have completed the work

				'Big Picture' Architecture of our project
				
					$$$Highest earners sit here$$$

					Hardware?  Software? IDE? Language? Legacy buy-in (code
						which we have to talk to)
					
					Cloud provider?  AWS Amazon?  Azure? Google?

					Business : Manpower (people), resources (buildings, 
						access to datacenters, local computing power)
						Timescale
						Budget    overall cost
						CashFlow  company to stay 'afloat' ie have money to 
									pay bills

					Risks  :    % chance .... will happen 
											          * impact (consequence)
					
						Mitigate : reduce risk (Take action, do nothing, 
									insure, take alternative action)					

					Greenfield : project from scratch (very rare)
					Brownfield : merge existing with new work (norm)

					==> Produce 'Project Plan'

						Gantt Chart : all tasks on big 'timescale' board


				Design : in detail

					1. Analysis ==> requirements
					2. Architecture ==> big picture
					3. Design : technical spec for developers

					GUI Graphical Design

					Data Structure

						Classes
							FIELDS
							PROPERTIES
							METHODS

							===> diagram called 'UML'  unified markup language

						Data Diagram

							ERD Entity Relationship Diagram

				4. Build 'units' of code

				5. Testing
				
					UNIT TESTING ==> test blocks of code built by dev team

					INTEGRATION TESTING  ==> join units together, test as such

					SYSTEM TESTING ==> entire system together including join to 
										remote systems / databases

					ALPHA RELEASE : first working version, by invitation only
									(press, journalist, authors, marketing...)

					BETA RELEASE  : almost-ready software, released for free to public
									==> without any legal consequence ('disclaimer')

									public inform company of all bugs (for free!)

					REGRESSION : when you go live and fix a bug then you must also
									check you haven't broken anything afresh!!!

					TEST COVERAGE : % of your code base that your TESTS ACTUALLY TEST!

										50% not good

				6. Release to deployment (production)

						DEV 				in progress

						STAGING  			ready to go

						PRODUCTION 			live 

						Note : critical to have a 'flip-switch' so when go live, if 
								things do go wrong, quickly back out and regress back
								to old version which was live

				7. Ongoing support 

						Helpdesk

							Log faults

						New features


				8. Documentation !!!

		Waterfall
			Fixed, linear stucture IN ORDER
				Good for projects which will not change
					BRIDGE, DAM, HIGH TOWER
				Good for military where ROBUST 
				Good for mission critical eg Power station, electricity, 
					water treatment
				Good for budgeting!  

		V-model
			used for military or mission-critical systems where perhaps life is at
			stake

				fire system
				ambulance system
				helicopter software


				analysis (list of requirements)		===>  	UAT USER ACCEPTANCE TEST
															(does user agree our app
															does meet their needs)

					architecture                    ===>    SYSTEM TESTING
						high level design           ===>    INTEGRATION TEST
						design 	(individual spec)   ===>    UNIT TEST!!

							            build


### History Of Agile

There have been some spectacular 'fails' in big software projects 

People tried different ways of working

	XP : extreme programming
	Pair programming
	Spiral 
	RAD Rapid Application Development

	Agile

	Scrum

### Agile Methodology

	Online 'agile manifesto'

		Value : 

			Individuals 					over  			Following A Process
			   (value is in human beings)                 


			Working software                over 			Documentation
			
			   ((Sprint : goal is to produce 
			   	one fresh 'iteration' ie incremental
			   	build of new part of our software))	

			Collaboration : working with your     over      Negotiation ('us' and 
			   customer as if they are part of 				'them') mentality
			   your 'team' 


			Embrace change  							over  fixed plans
				Aware that today, changes in society
				and business and tech products and
				tech tools can happen in short time-
				scales


				Consider Amazon : 2-hour grocery deliveries
								  same-day parcel deliveries		


### Scrum Methodology

Agile : theory model
Scrum : practical outworking of this model


Scrum : create 'sprints' which are individual units / blocks of work

	'EPIC' 			overall big picture 'architecture of our project'

	'FEATURE' 		major goal

	'SPRINT'  		choose next 'iteration' or 'minor build' of our software

					Agile : theory : start simple and build gradually more complex
					Sprint 0 : setup
					Sprint 1 : early prototype
					Sprint 2 : first working model
					       3 : add functionality

					Goal : every sprint : working software to show customer

					Timescale : 1-4 weeks

					Meetings : 

						1. Sprint Planning : set goals and timescale
						2. Daily 'standup'
								a) did yesterday?
								b) doing today?
								c) impediments/blockers to progress?
						3. Sprint Review : invite customer to see our work at the end
						4. Sprint Retrospective : internal 


	Scrum teams

		Product owner 		Person who liaises closely with the client/customer

						 	In charge of the 'backlog' list of requirements to be
						 	built	

		Scrum master 		In charge of making sure the whole 'scrum methodology'
							works and flows on a daily basis; help to remove blockers
							etc.

		Dev team 			3-9 developers
							multi-skilled, cross-functional
							jointly take ownership of responsibility for commitments
							made


https://github.com/JacobLRL/Tests


































































## Monday - Week 4 - Revision

try{}
catch(DivisionByZeroException e){}  specific
catch(Exception e){}   // general, all exceptions
finally{}
try{
	throw new Exception("something went wrong");
}

try{
	try{}
	catch{  throw; }   // puts exception back to parent
}
catch{
	
}

value type      FAST STACK MEMORY  "PRIMITIVES"
					int,bool,char,byte

reference type  HEAP MEMORY        LARGER ITEMS
					array, string,class, collection

int x=10
switch(x){
	case 1:
		break;
	case 10: 
		break;
	default:
		break;
}

overload   : different parameters
	DoThis()
	DoThis(int x)

						DoThis()
						DoThis(10)

override

	Polymorphism

				PARENT  (BASE)        virtual  HaveAParty(){   // parent party }

				  CHILD1  (DERIVED)   override HaveAParty(){ // swim party } 
				  CHILD2                                     // tramopoline
				  CHILD3                                     // out with friends


				PARENT METHOD     virtual DoThis(){}

				CHILD METHOD      override DoThis(){}
								  new      DoThis(){}


///  

WPF Image

        <Grid Grid.Row="2" Grid.Column="2">
            <Grid.Background>
                <ImageBrush ImageSource="/lab_52a_WPF;component/Images/snakes-and-ladders.jpg"  />
                <!--   <ImageBrush ImageSource="pack://application:,,,/Images//>    -->



StackPanel.SendToBack()
          .BringToFront()
          .Hide()
          .Show()


Visual Basic : came first : no longer official supported
Visual C# : current


Random Number 1 to 6
Download from internet six different dice pictures
Create 6 buttons one one grid space
switch(diceRoll)
	case 1:
		pic1.show();
		pic2.hide();
		pic3.hide();





## Tuesday - Week 4 - Revision

 #region

# arrays

```cs
            int[] array1D = new int[] { 10, 20, 30 }; // literal
            var array1Da = new int[10];
            Console.WriteLine(array1Da[0]);  // first
            Console.WriteLine(array1Da[array1Da.Length-1]);  // last

            int[,] array2D = new int[5, 5];  // 5x5 grid
            // 2nd row and 3rd column
            // 2nd row has index 1, 3rd column has index 2
            Console.WriteLine(array2D[1,2]);

            int[,,] array3D = new int[5, 5, 5]; // cube
            // row3 col4 height 5
            Console.WriteLine(array3D[2,3,4]);

```

### static vs instance variables

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_55_revision
{
    class Program
    {
        static void Main(string[] args)
        {
            // create object which is called 'instance'
            var d1 = new Dog();
            d1.Bark();
            d1.Age = 5;
            // can't reach STATIC using d1 - use Dog!!!
            Console.WriteLine(Dog.numLegs);  //4 
            // dogfactory
            List<Dog> doglist = new List<Dog>();
            for (int i = 0; i < 100000; i++)
            {
                doglist.Add(new Dog());
                // or
                var d = new Dog();
                d.Age = -4;
                doglist.Add(d);
            }
        }
    }


    // class is a blueprint for creating dogs (objects which we call dog)
    class Dog
    {
        // field
        public int _private;
        // attached to DOG CLASS !!!  STATIC !!!!
        // access via Dog.numLegs
        public static readonly int numLegs = 4;
        // property
        public int PublicSomething { get; set; }
        // property with validation code
        public int Age {
            get {
                return Age;
            }
            set {
                if (Age > 0)
                {
                    this.Age = value;
                }
            }
        } // field // instance field
        public void Bark() { }  // instance method
    }
}

```

Summary
	
	Class => Instance with new() keyword
		var d = new Dog();

	but static variables are accessed 
		Class.myStaticField


# Events
	
	Old computing ==> script ==> events normally limited to people typing in text

	OOP => screen objects ==> button can 'listen' for events

			click
			dblclick
			hover
			keypress
			keydown
			keyup

	Typically an event look like this : screen events

		public static void Button01_Click(object Sender, eventArgs e){


		}

			object Sender ==> button
			eventArgs object is array of strings which can be sent with the event to provide information



```cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_56_event
{
    class Program
    {
        // delegate : says that our event can only trigger methods which
        // have a set pattern
        delegate void MyDelegate();   // pattern : method must be void ... ()  
        // event now uses this delegate
        static event MyDelegate myEvent;   // create event; when it triggers any methods must match this pattern


        static void Main(string[] args)
        {
            // goal : replace manually calling 3 methods with 1 event which triggers
            // these methods 
            MyMethod01();
            MyMethod02();
            MyMethod03();

            // attach methods to our event
            myEvent += MyMethod01;
            myEvent += MyMethod02;
            myEvent += MyMethod03;
            myEvent += MyMethod01;
            // call the event
            myEvent();
        }


        static void MyMethod01()
        {
            Console.WriteLine("Doing Something 01");
        }
        static void MyMethod02()
        {
            Console.WriteLine("Doing Something 02 ");
        }
        static void MyMethod03()
        {
            Console.WriteLine("Doing Something 03");
        }
    }
}

```

Events : Summary

	1) Delegate ==> pattern for methods 

			void MyDelegate();
			void MyDelegate(int x);
			string MyDelegate(int x);

	2) event MyDelegate MyEvent;          

	3) add methods  :    MyEvent += Method01; etc

	4) call event   :     MyEvent();








### Docker

Please create an account with 'Docker Desktop For Windows' then download and install Docker!

	https://hub.docker.com/editions/community/docker-ce-desktop-windows

Also download SQL Management Studio
	
	https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-2017

Docker can create a 'virtual space' which we call a container - it's like a mini-linux-operating system in only a few hundred MB compared to several GB for a typical OS install (either Windows or Linux)

	Install Docker

	Download and run a 'container' with built-in SQL server and Northwind already running

# ASP with Northwind

Let's work ahead of time and just show you quickly some of the capabilities of ASP.NET

Demo 

	Install ASP MVC website

	Connect Entity To ASP website

	Add in individual pages and 'scaffold' our website for us.


# Docker 

1. Reboot Laptop, Tap 'Escape' to enter BIOS and make changes -> Turn on Virtualisation

2. Windows - Control Panel, Add Windows Features ==> Turn on HyperV

3. Install Docker

4. Computer Management ==> Must add your user account to the Docker Users group

5. Run Docker Desktop

Docker is a command line tool

```bash
docker
docker -v
```

Docker is a command line tool which enables 'virtualisation' on a very small scale.

	Regular virtualisation

		HyperV
		ESX-i
		VirtualBox

			==> run complete operating systems eg Linux, Win10 etc, 
													Server2016
		Parallels (on Apple)

		Typical OS is huge : several GB in size

	Container virtualisation

		Container Instances, Unique, Shielded from each other
		Kernel   (core of operating system, shared)
		Hardware (shared)

		Typical container size is a few hundred MB

Lab : find on internet a pre-built 'container', download and run it 

	Connect to the SQL server on it using SQL Management Studio

1. Pull docker image

```bash
docker pull kcornwall/sqlnorthwind
```
Have you got a valid docker image yet?

```
docker ps -a
```

If not let's first create and run the image

```bash
docker run -d --name sql -p 1433:1433 kcornwall/sqlnorthwind
```

Is your image running?

```bash
# is image running?
docker ps
# list running and non-running images
docker ps -a  
```
Status of your docker container? Is it running?

```bash
docker ps 
```

Can start and stop image

```bash
docker start sql 
docker stop sql 
```

Next stage  : docker image is running : it's hosting an SQL server.  Let's connect to it.

Credentials

	Server 				localhost, 1433

	Authentication 		SQL Server

	User 				SA

	Password			Passw0rd2018


Now let's move on to the next phase

	1. Docker with SQL
	2. Connect with SSMS SQl Server Mgt Studio
	3. Connect with Visual Studio using raw SQL connection string


```cs
using System.Data.SqlClient;

@"Data Source=localhost;Initial Catalog=Northwind;Persist Security Info=True;User ID=SA;Password=Passw0rd2018"

```


# ASP websites

## Introduction

Most of the world build websites using regular

	HTML

	CSS

	Javascript

	However

		These operate inside a 'browser' to display to the user

The job of a 'web server' is to 

	Store fixed pages, images, scripts etc

	Generate dynamically computer-generated pages etc

		Question is - which language can we run on the server which will generate
		HTML to send back ?

		client                                       facebook

		10.11.12.13 	---> http request -->    	67.68.69.70

		                   << http response ---


			Many sites traditionally use PHP to generate HTML at the server

			Java can be used (but not so much now)

			Python, Ruby (RubyOnRails) can be used

			Google has 'Go'

			...

			Someone worked out how to run JAVASCRIPT on the server also.  They called it
			NODEJS and it has changed forever web devlopment

			    client : HTML CSS JS              server : NODE (Javascript) 
			                                               + HTML / CSS

			Microsoft servers run a special language called ASP.NET

				<html>....
					<asp:runat="server">....button...


				ASP Active Server Pages
				ASPX = newer XML version

	Traditional ASP has this format
	
		Display Page   .aspx    xml file

			Code-behind    .cs      cs  code behind the XML


							((Seen this in WPF already))

	Razor Page

	  .cshtml with both regular html on the page plus

		@{

			// put in here C# code 
		}			


	Visual Studio we can build several different types of Web App

		1. Blank
		2. ASP Web Form
		3. ASP MVC Model View Controller
		4. API 

	First demo ==> Regular ASP (not MVC)

		Flat file structure, Each page has .aspx and .cs file to make it		

	Second demo ==> ASP MVC site

		M   Model  			Data

		V   View  			What the user sees

								.cshtml pages

		C   Controller  	Sorts out your request, decides which page you want to see,
							gets the data from the model and sends it to the view
							for display


							http://mysite.com/Controller/Action

							http://mysite.com/api/Customers/            all customers

							                     /Customers/ALFKI       one customer

							                    /Home                   controller

							                    /Home/About      Home controller, About
							                    				Action which retrieves
							                    				the About View

Controller : deciding which View to use

	Home 

		Index       DEFAULT 

			Returns View page and look for page called Index.cshtml


Pass data from Controller to View

	We have seen the default ViewBag/ViewData but let's add to this

	var string01 = "..."
	return View("Index",string01);





## SQLite

SQLite is the most used database engine in the world because it's used on
mobile devices and tablets

Open source

Download and extract

```sql
sqlite3
```

GUI tool : SQLite Studio 

	https://sqlitestudio.pl/index.rvt

### Summary of commands

.databases   show all
.open my.db  
??? attach database 'my.db' as 'alias'
sqlite3 my.db  ==> attach and open
.tables	     show all
create table myTable(
	id integer primary key,
	name varchar(50)
);
insert into myTable values ("bob");
.output file.txt
.exit   exit   (Ctl-C)

```
// Create and/or connect
./sqlite3 my.db
```

```
.open my.db
```

```
// show any tables
.tables
```

add data
```
insert into mytable values ('bob');
```

.quit   ==> EXIT
.exit   


// from powershell
./sqlite3 test.db

// from inside sqlite
.open test.db


### SQLite With Northwind

Download .sql script specifically for SQLite for Northwind

Import with

```bash
./sqlite3 Northwind.db < InstallNorthwind.sql
```


## .NET Core

.NET core is a stripped-down version of .NET

Useful as it's cross-platform and now open source

.NET Framework is huge (4.2GB) and Windows only
.NET Core is Windows/Linux/MAC

### Adding Entity to .Net Core

Let's add these packages

```
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.SQLite
```

### Working with Nuget console

Nuget : graphic utility
Improve as programmer ==> efficient with command line

### See what's installed

Get-Package


### Find packages on internet

Find-Package EntityFramework

### Install 

Install-package Microsoft.EntityFrameworkCore.SqlServer -ProjectName lab_77_entity_core


### Build code

Now we have to build our code - but this time from raw!!!  Quite a lot of work!!!

GitHub : Philanderson888 : c-sharp : Entity_10_Core_Northwind

Products

	Categories  (related table)

	One product will belong to one category

[Above Certain Columns : add Description or Type or Change of Name]

### Relationships

Table relationships expressed with

class Category {
	// properties


	// end : relationship
    public virtual ICollection<Product> Products { get; set; }
}

### Configure The Database

class Northwind : DbContext{
	
	public DbSet<Category> Categories {get;set;}          // CREATE TABLE 

}


FluentApi is name given to overridden method which sets database constraints






## Overnight Lab : Build Your Own ToDo Application In WPF

Goal 

	Users    'UserID'  'UserName'     'Bob', 'Bill', 'Fred'

	Categories   'CategoryID'  'CategoryName'    Home', 'Work', 'Family'

	Tasks   'TaskID' 'TaskName' 'DateCreated' 'DateDone' 'Done' 'CategoryID' 'UserID'

Build an app which

	Populated from manually run script (either SQL or C# Code-First)

	Populates database with initial data

	Correctly relates tables : One task has one user and one category

	Minimum : List/Add/Remove Tasks
	Maximum : Full CRUD ie List/Add/Remove/Update   Tasks+Users+Categories


### Trainer Help : SQL Script

```sql  (not SQLite)
use Northwind;
drop database ToDo
go
create database ToDo 
go 
use ToDo
go 
CREATE TABLE Categories(
	CategoryID INT NOT NULL IDENTITY PRIMARY KEY,
	CategoryName NVARCHAR(50) NULL
);
CREATE TABLE Users(
	UserID INT NOT NULL IDENTITY PRIMARY KEY,
	UserName NVARCHAR(50) NOT NULL
);
CREATE TABLE tasks(
	TaskID INT NOT NULL IDENTITY PRIMARY KEY,
	TaskDescription NVARCHAR(50) NULL,
	Done Bit NULL,
	DateStarted Date NULL,
	DateCompleted Date NULL,
	CategoryID INT NULL FOREIGN KEY REFERENCES Categories(CategoryID),
	UserID INT NULL FOREIGN KEY REFERENCES Users(UserID)
);
```

// Add data

```sql
INSERT INTO Categories ..  Users ... Tasks ...    // SAMPLE DATA .
```

# SOLID Programming Principles

Theoretical principles of good programming

S 		Single Responsibility
O  		Open / Closed
L 		LISKOV substitution
I 		Interface segregation
D 		Dependency Inversion




S 		Single Responsibility

	Classes should only deal with one object

		Maintenance of your code becomes much easier when individual classes
		/modules/methods etc deal only with one function or 'reason for existence'

		Update your code ==> only one single place for this to happen

		 				     only affect one module


			Monolith 

				Full application with libraries, databases, attached to an operating system
				- very big and bulky but also if you want to change it, there can be problems
				with affecting rest of code.

			Container

				Small workspace in which we can put an application and all of
				its dependencies so that we can publish it to the 'cloud' and 
				it will not break when moved from development into production

				App 				App               App
 				Libraries           Libraries         Libraries

 				======= host : shared operating system 'kernel' ============


			DevOps :  TDD tests then build code to pass tests (RED tests fail, GREEN tests pass, REFACTOR efficient).  Once tests pass then push to production straight away

				CI-CD  Continuous Integration, Continuous Deployment

					Team of 50 : continually 1) tests 2) pass 3) push to production 4) everyone
									else pull down changes 


			Microservices Architecture  : large application built from many single decoupled elements

			Decoupling : code not dependent on other code (valid unit tests by itself) 

		Single Responsiblity : Code should be MODULAR and TESTABLE by itself (UNIT TESTS)


O  		Open / Closed

	Open for extension       : DERIVED (CHILD) classes : OK to inherit from parent and override 
									behaviour etc

	Closed for modification  : BASE (PARENT) class : finished (not modified)

		Illustration : Visual Studio (parent)
							NUGET    (plug-ins to modify behaviour)


    Open / Closed ==> classes open for extension rather than modify root class



L 		LISKOV substitution

			Replace Parent with Child instances : in some situations


I 		Interface segregation

			Keep interfaces with a single responsibility 

				In practice means ONE METHOD PER INTERFACE

						IDisposable ==> Dispose()
						IComparable ==> CompareTo()


D 		Dependency Inversion

			Create your code structure with Abstract classes at the top and inherit down with real
			(concrete) classes below this level

S Single Responsibility
O Open for extension
L LISKOV : parent/child substitution
I Interfaces : one method only
D Depend on abstract classes at top level






# ASP Web Core Project 

Today we are going to build an ASP Core website from scratch.

We are not going to do a lot of theory, but just build the website!

Theory and detail will come later.

Goal

1) ASP Website (not MVC)

2) Flat file structure

3) Razor page 

4) Use Model (puts data on page)


### Build project (New ASP Core Web)

### Folder Structure

wwwroot
	js   Javascript
	css
	images

				FIXED FILES WITH NO SECURITY : COMPLETELY VISIBLE
				ALL FILES, FULL PATH LOADED WITH SITE

Pages/Shared/ _ Layout is our file shared across all pages

Startup.cs

	Services

		==> Run our database from here!

		AddMvc()  

AppSettings.json

	Can have database connection string sometimes


Default page is 'Index'   (can be Default.htm)

Page

	Phil.cshtml     this is 'Razor' page

		Phil.cshtml.cs    this is 'C#' code-behind page (real C#)


### Passing data through from our C# code-behind to .cshtml View page

We can create 'properties' in the C# page by using the 'class' it declares

	class MyPage : PageModel {

		public string Property01 {get;set;}

	}


### Code from 3 cshtml pages

```html

@page
@model lab_80_asp_core_web.Pages.PhilModel
@*
    COMMENT
*@

@{
    // code
    // two ways of storing trivial strings : viewdata and viewbag
    ViewData["Value"] = "Here is some data";
    ViewBag.Value2 = "And some more data here - Viewbag";
}

<i>
    <b>
        <u>

            We don't really use Bold Italic Underline any more

        </u>
    </b>
</i>

<p style="font-weight:bold">@ViewData["Value"]</p>

<p style="font-style:italic">@ViewBag.Value2</p>

<p>
    We can also use 'em' for emphasis italic
    <span><em>@ViewBag.Value</em></span>
</p>

<p>
    We can also use 'strong' for emphasis bold
    <span><strong>@ViewBag.Value</strong></span>
</p>

<p>'p' always starts a new line BLOCK ELEMENT <p>@ViewBag.Value</p></p>

<p>So does H1 Header <h1>@ViewBag.Value</h1></p>

<p>So does DIV I think!!!! <div>@ViewBag.Value</div></p>

<p>
    Finally to underline we use
    <span style="text-decoration:underline">text-decoration:underline</span>
</p>

<h1>This is my amazing test web page</h1>

<p>Some text</p>

<h1>Using Razor</h1>

<h2>The 'at' symbol can be used to write C# code raw on top of HTML</h2>

<h3>@DateTime.Now</h3>

@{
    var d = DateTime.Now;
    d = d.AddDays(2);
}

<h4>The date in 2 days time is @d.ToShortDateString()</h4>


<ul>
    <li>first</li>
    <li>second</li>
    <li>third</li>
</ul>

<ol>
    <li>first</li>
    <li>second</li>
    <li>third</li>
</ol>

<ul>
    @for (int i = 1; i <= 10; i++)
    {
        // notice that inside C# block we can intelligently use HTML as well
        <li>Your item has number @i</li>
    }
</ul>



<h2>This is also Bootstrap</h2>

<button class="btn btn-success">Click Here</button>
<button class="btn btn-danger">Click Here</button>
<button class="btn btn-default">Click Here</button>
<button class="btn btn-info">Click Here</button>
<button class="btn btn-primary">Click Here</button>

<h2>HTML table looks a bit 'rubbish'!</h2>

<style type="text/css">
    .tg {
        border-collapse: collapse;
        border-spacing: 0;
    }

        .tg td {
            font-family: Arial, sans-serif;
            font-size: 14px;
            padding: 10px 5px;
            border-style: solid;
            border-width: 1px;
            overflow: hidden;
            word-break: normal;
            border-color: black;
        }

        .tg th {
            font-family: Arial, sans-serif;
            font-size: 14px;
            font-weight: normal;
            padding: 10px 5px;
            border-style: solid;
            border-width: 1px;
            overflow: hidden;
            word-break: normal;
            border-color: black;
        }

        .tg .tg-13pz {
            font-size: 18px;
            text-align: center;
            vertical-align: top
        }
</style>
<table class="tg">
    <tr>
        <th class="tg-13pz">some</th>
        <th class="tg-13pz">text</th>
        <th class="tg-13pz">here</th>
        <th class="tg-13pz">in </th>
        <th class="tg-13pz">this </th>
        <th class="tg-13pz">table</th>
    </tr>
    <tr>
        <td class="tg-13pz">also</td>
        <td class="tg-13pz">here</td>
        <td class="tg-13pz">.</td>
        <td class="tg-13pz">.</td>
        <td class="tg-13pz">.</td>
        <td class="tg-13pz">.</td>
    </tr>
    <tr>
        <td class="tg-13pz"></td>
        <td class="tg-13pz"></td>
        <td class="tg-13pz"></td>
        <td class="tg-13pz"></td>
        <td class="tg-13pz"></td>
        <td class="tg-13pz"></td>
    </tr>
    <tr>
        <td class="tg-13pz"></td>
        <td class="tg-13pz"></td>
        <td class="tg-13pz"></td>
        <td class="tg-13pz"></td>
        <td class="tg-13pz"></td>
        <td class="tg-13pz"></td>
    </tr>
    <tr>
        <td class="tg-13pz"></td>
        <td class="tg-13pz"></td>
        <td class="tg-13pz"></td>
        <td class="tg-13pz"></td>
        <td class="tg-13pz"></td>
        <td class="tg-13pz"></td>
    </tr>
    <tr>
        <td class="tg-13pz">on</td>
        <td class="tg-13pz">the</td>
        <td class="tg-13pz">bottom</td>
        <td class="tg-13pz">row</td>
        <td class="tg-13pz"></td>
        <td class="tg-13pz"></td>
    </tr>
</table>


<h2>Bootstrap Table</h2>

<table class="table table-hover table-bordered table-striped">
    <tr>
        <th>header</th>
        <th>goes</th>
        <th>here</th>
        <th></th>
        <th></th>
    </tr>
    <tr>
        <td>also</td>
        <td>here</td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td></td>
        <td>is</td>
        <td>some</td>
        <td>detail</td>
    </tr>
</table>

```


```cshtml
@page
@model lab_80_asp_core_web.Pages.UsingAModelModel
@*
    For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860
*@

<hr />
<hr />
<hr />

<style>
    div.block{
        width:70%;  /* note that can use 50vw as well */
        padding: 8vh 9vw;   /*  top right bottom left   */
        background-color:green;
        text-align:center;
        font-size:1.3em;  /* one 'em' means standard size text */
      /*  margin-left:15vw;  */
        margin:auto;
        margin-top:5vh;
    }
</style>

<div class="block">
    @Model.Property01
</div>

<div class="block">
    @Model.Property01
</div>

<div class="block">
    @Model.Property01
</div>

<div class="block">
    @Model.Property01
</div>

<div class="block">
    @Model.Property01
</div>



```


```cshtml
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab_80_asp_core_web.Pages
{
    public class ListsModel : PageModel
    {
        public List<String> items = new List<string>();
        public void OnGet()
        {
            items.Add("first");
            items.Add("second");
            items.Add("FiFteenth");
            items.Add("fourth");
            items.Add("odd one out");
        }
    }
}

```



Homework

Can you research and add to your page

1) A Flexbox div, centered, 100 pixels square

2) Can you import Microsoft.EntityFrameworkCore v2.1.8 into your project?

3) Also  Microsoft.EntityFrameworkCore.SqlServer 

4) Can you add a folder 'Models' to your project

5) In it add two classes

a) Customer

b) Northwind : DbContext

(trainer will give you files for 5a and 5b)

6) using MyProject.Models;  at top

7) using (var db = new Northwind()){  
	  // create a list of customers and display them!
   }

8) Add code to Services method of Startup.cs









# ASP and ASP Core

Homework overnight will be to create a fresh website ASP Core of your choice.

It should just use the standard Bootstrap menu but other than that feel free to customise as you wish.

Build 3 pages

Create a table

Use a flexbox with perhaps 2 or 3 divs containing images in order to place them centrally on the page

ASP does have a 'carousel' with rotating images (create optionally)


As a warm-up to this, I want to re-create the TODO app using 
	1) ASP
	2) ASP Core

In order to give you a base for adding in a custom database table into your app.  Perhaps 1, maybe 2 linked tables.

### Reminder Of Differences Core vs Framework

	.NET     			ASP   			Entity Framework 6  (EF6)

	.NET Core    		ASP Core 		Entity Core

		Difference betweeen Core and Non-Core?

			Core
				Cross-platform : MAC, Linux, Windows
				Small
				Light
				New, fresh technologies
				Cannot use WPF
				Can't link to many 'heavy' native Windows libraries
			Framework
				.NET is big (4GB)  !!!


### Azure / AWS 'DEVOPS'
	
	ASP Web app => can deploy to Azure
	ASP Core web app ==> smaller, nimble ==> easier to port to Azure or AWS for hosting

	DEVOPS :   Build=>Test=>Move Database To Cloud=>Push Code to Cloud for hosting

		Can link to GitHub with automatic push to Azure 

### ToDo via ASP MVC using Entity Framework (EF6 for short)

ASP MVC ==> Import Entity => Scaffold pages ==> DONE  !!!


### Migrating A Database

Let's play around with a database.

Before we do, we want to be sure we have captured old data before we make changes.

First thing to be aware of is the location of the database!

	MDF = Microsoft Database File



```sql


USE [Todo]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


DROP TABLE IF EXISTS [dbo].[Tasks];
GO
DROP TABLE IF EXISTS [dbo].[Categories];
GO
DROP TABLE if EXISTS [dbo].[Users];
GO


CREATE TABLE [dbo].[Categories] (
    [CategoryID]   INT           IDENTITY (1, 1) NOT NULL,
    [CategoryName] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([CategoryID] ASC)
);

CREATE TABLE [dbo].[Users] (
    [UserID]   INT           IDENTITY (1, 1) NOT NULL,
    [UserName] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([UserID] ASC)
);

CREATE TABLE [dbo].[Tasks] (
    [TaskID]          INT           NOT NULL,
    [TaskDescription] NVARCHAR (50) NULL,
    [Done]            BIT           NULL,
    [DateStarted]     DATE          NULL,
    [DateCompleted]   DATE          NULL,
    [Category]        INT           NULL,
    [UserID]          INT           NULL,
    PRIMARY KEY CLUSTERED ([TaskID] ASC),
    FOREIGN KEY ([Category]) REFERENCES [dbo].[Categories] ([CategoryID]),
    FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users] ([UserID])
);

Go


SET IDENTITY_INSERT [dbo].[Categories] ON
INSERT INTO [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (1, N'Family')
INSERT INTO [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (2, N'Work')
INSERT INTO [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (3, N'Personal')
INSERT INTO [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (4, N'Admin')
INSERT INTO [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (5, N'Leisure')
SET IDENTITY_INSERT [dbo].[Categories] OFF


SET IDENTITY_INSERT [dbo].[Users] ON
INSERT INTO [dbo].[Users] ([UserID], [UserName]) VALUES (1, N'Bob')
INSERT INTO [dbo].[Users] ([UserID], [UserName]) VALUES (2, N'Bill')
INSERT INTO [dbo].[Users] ([UserID], [UserName]) VALUES (3, N'Ben')
SET IDENTITY_INSERT [dbo].[Users] OFF


INSERT INTO [dbo].[Tasks] ([TaskID], [TaskDescription], [Done], [DateStarted], [DateCompleted], [Category], [UserID]) VALUES (1, N'test', 1, N'2018-12-12', NULL, 1, 1)
INSERT INTO [dbo].[Tasks] ([TaskID], [TaskDescription], [Done], [DateStarted], [DateCompleted], [Category], [UserID]) VALUES (2, N'test', 0, N'2018-01-01', NULL, 2, 2)






```



### Updating Your Code

In VS 2017 the Model automatically can update (as it should) 

In VS 2019 the Model is not updating so you can manually add/remove fields from the model.

Save changes to the .edmx file.

Delete the relevant controller and re-add it again, it overwrites the Views with the new ones.


### If problems with database update

Delete both .tt files and run the 'Add Code Generation Item'.  

Click on the .edmx file and click 'save'

Delete the controller.

Recreate the controller, with views.

### If still not working

If this fails, just completely delete .edmx file and re-add Entity.

Delete then re-add the controller, with views.







### LINQ

Let's revisit LINQ and go through some more advanced features

In Recap : 

LINQ is Microsoft's way of talking to SQL database without the hassle of using raw SQL connection strings etc

### select

var customers = 
	from c in db.customers
	select c;

### where

var customers = 
	from c in db.customers
	where c.City == "Rome"
	select c;

### find

// works on primary key
var customer = db.Customers.Find("ALFKI");

### orderby

var customers = 
	from c in db.customers
	where c.City == "Rome"
	orderby c.City ascending/descending
	select c;

### custom object

var customers = 
	from c in db.customers
	select new 
	{
		Name = c.ContactName,
		City = c.City,
		CompanyName               // single valued item
	}


### custom object with class

var customers = 
	from c in db.customers
	select new Custom
	{
		Name = c.ContactName,
		City = c.City,
		CompanyName               // single valued item
	}

class Custom{
	public string Name {get;set;}
	public string City {get;set;}
	public string CompanyName {get;set;}
}

### GroupBy

Can count stats per item eg Customers Per City.
Have to 'GroupBy City' to make this work

var customersByCity = 
	from c in db.Customers
	group c by c.City into cities
	select new 
	{
		City = cities.key,
		Count = cities.Count()
	}


### Lab

1) OrderBy

2) Custom Object 

3) GroupBy

==> Create 3 pages to display, use Northwind with ASP Core

















### join

### IQueryable

### IEnumerable












### firstordefault

var customers = (db.Customers)















## ASP Core Entity : Refresh

Part 1 : Read Northwind
Part 2 : Add To Northwind

## Part 1 : Refresh : Read From Northwind

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lab_83_asp_core_add_records.Models;

namespace lab_83_asp_core_add_records.Pages
{
    public class NorthwindCustomersModel : PageModel
    {
        public List<Customer> customers;
        
        public void OnGet()
        {
            using (var db = new Northwind())
            {
                customers = db.Customers.Skip(10).Take(10).ToList();  // 11-20  
            }
        }
    }
}
```


```html
@page
@model lab_83_asp_core_add_records.Pages.NorthwindCustomersModel
@{
    ViewData["Title"] = "NorthwindCustomers";
}

<h2>NorthwindCustomers</h2>

<table class="table table-bordered table-striped table-hover">
    <tr>
        <th>Company Name</th>
        <th>Contact Name</th>
    </tr>
    @foreach (var c in Model.customers)
    {
        <tr>
            <td>@c.CompanyName</td>
            <td>@c.ContactName</td>
        </tr>
    }
</table>
```


### Injected Customers

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lab_83_asp_core_add_records.Models;

namespace lab_83_asp_core_add_records.Pages
{
    public class InjectedCustomersModel : PageModel
    {

        private Northwind db;
        public List<Customer> customers;

        // Constructor to instantiate this db
        // Instantiate Northwind just once : use for Get() and Post()
        public InjectedCustomersModel(Northwind injectedContext)
        {
            db = injectedContext;
        }

        public void OnGet()
        {
            customers = db.Customers.Skip(20).Take(10).ToList();
        }
    }
}
```

```html
@page
@model lab_83_asp_core_add_records.Pages.InjectedCustomersModel
@{
    ViewData["Title"] = "InjectedCustomers";
}

<h2>InjectedCustomers</h2>

<table class="table table-bordered table-striped table-hover">
    <tr>
        <th>Company Name</th>
        <th>Contact Name</th>
    </tr>
    @foreach (var c in Model.customers)
    {
        <tr>
            <td>@c.CompanyName</td>
            <td>@c.ContactName</td>
        </tr>
    }
</table>
```



### Add Customers 

1. Add customer object to CS page

```cs
// Bind Property is required for the POSTING of data from FORM
        [BindProperty]
        public Customer customer { get; set; }
```

2. Create form

With a form there are two ways to submit it

	1) GET

		SUBMIT ==> Form and the data get sent COMPLETELY VISIBLE IN THE URL

			www.mysite.com/path?name=Bob&company=sparta

	2) POST

		SUBMIT ==> Form data is sent as part of the PAGE BODY in JSON format
			(key/value pair)

<div class="row">
    <p>Add a new customer</p>
    <form method="POST">

    </form>
</div>


3. Update Post() method to accept data



































### Revision During Games Week : Top-Up Tech !!!

Methods
Overload : same name different parameters
Override : Virtual in parent, override in child
Override : same name different code implementation
	
		Class BaseParent{
			virtual DoThis(){  // some code}
		}

		Class DerivedChild{
			override DoThis(){  // different code }
		}

Polymorphism : Different implementations at runtime

Abstract
	abstract class GreatIdea{
		abstract void TravelPlans();
	}

	class RealHoliday:GreatIdea{
		override void TravelPlans(){  // real code}
	}

Testing : 3 types
	MSTest : native Visual Studio
	NUnit  : **
	XUnit : latest

		Create our project and have class/method accessible ==> we can test

Polymorphism 
	BaseParent : virtual DoThis(){}
	DerivedChild : override DoThis(){}


4 Pillars Of Object Oriented Code

	Abstraction   : code is hidden behind (encpsulated) but user can interact with it using
					PUBLIC PROPERTIES  

		Both encapsulate (hide) key code but also reveal or expose desired 'Properties'
		Properties ==> {get;set;}  ==> allows public access

			CAR : engine inner workings are encapsulated (hidden)
			      steering, clutch, accelerator are PUBLIC PROPERTIES ACCESSIBLY BY END USER


	Encapsulation  

		hide code which does not need to be revealed to outside world

			CAR ENGINE : deep inner workings hidden from general user

			CODE : private keyword for this

				4 options with keywords are called 'ACCESS MODIFIERS'

				ACCESS MODIFIERS 
					private 		encapsulates (hides) code from outside
									access : code ONLY IN THIS CLASS ONLY!!!
					public 			accessible from any code
					protected 		access : from code in THIS CLASS AND ALL DERIVED CHILD
																 CLASSES ALSO
					internal 		access : from any code inside the compiled .exe or .dll
									file which is produced for this project ('Assembly')

	Polymorphism : poly = many, morph = type: polymorphism : can have one 'master' instruction but in the child classes, each child (derived) class may have its own implementation

			FAMILY : PARENT : Each child has own idea of how to throw a party!

	Inheritance

		Parent (Base) Class

			Child (Derived) Class


Sparkhire : video interview : standardise : objective 
	
	pause : INDEFINITELY
	CLICK
		30 seconds to READ
		60 seconds to REPLY
		no going back!
	pause INDEFINITELY ..

Tips : 
	Use mobile phone
	Use friend
	Work in pairs in class
	Be able to articulate simple tech concepts

Tell us about yourself
Why did you join Sparta?
Why did you choose tech?
How do you see yourself in group?
Talk about successes / problems & give example
What do other people say about you?

Agile : basics
Waterfall : all-in-one
Agile: DELIVER VALUE FOR MONEY (WORKING CODE) IN INCREMENTS (SPRINT)
Sprint : dev team + product owner (talk to customer) + scrum master (runs 'scrum/sprints' : enabler : servant leader)
backlog = list of features which we are going to build
user stories : 'humanise' tech features which we're going to build 'Joe clicks on 'users' , 'new' , enter new user and submit
sprint backlog = mini-list of features just for this sprint
SQL : basics
C# : all core features  : data types, if.. , switch, loops (for, foreach, while, do.while)
OOP meaning
4 pillars of OOP
class
method
overload
override
virtual
abstract class
abstract method
sealed class : has no child classes (useful for security)
static keyword : attached to class
collection
array (fixed) vs collection(resize)
list 
queue : enqueue dequeue
stack : push pop 
stack memory (fast) 
Note : Stack<int> is a place to store integers
	 : Stack memory is a fast place in our computer where we store running programs
heap memory (larger)
value type : int char bool
reference type : string array list  
char[] array is same as string



## Wed : Revision (break from SQL)

50 terms??

constructor

class Dog{
	public int Height {get;set}	
	public Dog(){}
	public Dog(int Height){
		this.Height=Height;
	}
	    			       overload : same method different 
						input paramaters
}

  var dog = new Dog();
  var dog2 = new Dog(100);       // creating a new instance

Inheritance

	public class Parent{}
	public class Child : Parent{}

Encapsulation

	private fields and methods are completely hidden from outside world

Access Modifiers

	private : this class
	public : any class
	protected : can see from this class and all child derived classes 
	internal : can see from any code inside final compiled 'exe' or
				'dll' ASSEMBLY
	protected internal = protected plus internal scope

### Revision : Polymorphism
	
Each child overrides parent code

	Parent : virtual
	Child : override

```cs
    class Parent {
        public virtual void HaveParty() { Console.WriteLine("parent fun"); }
    }

    class Child1 : Parent {
        public override void HaveParty() { Console.WriteLine("child1 fun"); }
    }
    class Child2 : Parent {
        public override void HaveParty() { Console.WriteLine("child2 fun"); }
    }
    class Child3 : Parent {
        public override void HaveParty() { Console.WriteLine("child3 fun"); }
    }
```

int
int16  short
int32  int
int64  long
uint32 unsigned

4 pillars of OOP
	encapsulation : hiding private code
	polymorphism : unique ways to override parent code in child class
	inheritance : fields from parent also in child
	abstraction : hiding (encapsulation) private fields         hidden engine
			      exposing               public PROPERTIES      revealed clutch, accelerator



### Revision : Thursday : Morning review

4 Pillars Of OOP : APIE !!!!
Encapsulation : hiding private data  eg date of birth ((use 'private' keyword))
Abstraction : both hide private data and expose public properties eg car : gear shift 
	Create and design correct methods to allow user interaction in the correct manner
Inheritance : Features (properties and methods) inherited by DERIVED CLASS FROM BASE CLASS
Polymorphism : Parent method is OVERRIDDEN by the Child method
				Parent : virtual DoThis(){}
				Child  : override DoThis(){}  optional
	Polymorphism : action in child is similar but not necessarily exactly the same as parent base class 
What is scripting? Code run 'line by line' in order from top to bottom
Compiled code ==> create (build) .exe (.dll) then run it
Interpreted code : Powershell with individual lines run one by one, in turn
	CMD old fashioned command line
	BASH linux
	POWERSHELL
	ZSH advanced linux
What is OOP?  Object Oriented
	Old computers : program start line 1 and run to end
	GUI : screen objects eg button, list, label also internal objects from database like
		array, dictionary.
	OOP ==> attach code to OBJECTS EG button_click() method  hover()...  
		array.sort()
	Code is called as required : EVENTS initiate the process (eg button click)

	Object {}
		int inherits from object

High Level : Slower to run on computer because there's lots of extra code in there
			 to make it easier for human to understand!
	CIL : intermediate 
Low Level  : raw syntax/commands sent directly into computer for processing
	ASSEMBLY LANGUAGE

High level : Java, C#, Python, Javascript
Low level : Assembly language

Agile : build incrementally from simple to more complex
	Goal : each increment is unit of 'WORKING CODE' which adds value to customer
	Good for real world where requirements can change in 3 months
	Can be hard to control 'big picture' and costs
		SPRINTS : focused blocks of work
		LIST OF REQUIREMENTS : BACKLOG
			SPRINT : SPRINT BACKLOG : mini-list for just this sprint

Waterfall : traditional : ANALYSE DESIGN BUILD TEST IMPLEMENT in order
	Not good for flexible projects 

SQL
Order by
Select distinct
... as ...
LIKE
LIKE '%a'    ends a
LIKE 'a%'    starts a
LIKE '%a%'   contains a
IN(a,b)   both a and b
count(field)
sum
avg
min/max
between
substring(string,startIndex,numCharacters)
charIndex('char',string)          ('a','abc') ==> 1
			                      ('b','abc') ==> 2
LTRIM
RTRIM
null
is null
is not null
field1 + field2 as title
LEN(string)
UPPER
LOWER
REPLACE(string,remove,insert)    ('abc','a','z')  => zbc
[Order Details]
% operator   :  modulus : remainder
100/8   (integer) ==> 12
100%8                 4
	100 is  8 x 12   +   4





### 20 minutes flash review

4 pillars
Inheritance : Base to Derived class
	YES Inherit public/protected/internal 
			FIELDS, PROPERTIES, METHODS
	NO Don't inherit constructor ==> always create    .... Base()  refer to base constructor
Constructor : used with new... keyword 
Instantiate :   var p = new Parent();
const SOMETHING_LIKE_THIS_NEVER_CHANGE
READ ONLY

```cs
        static void Main(string[] args)
        {
            var d = new Dog();
            var d1 = new Dog(10);
            var s = new Spaniel(10);
            //var s1 = new Spaniel(10);   // CONSTRUCTOR IS NOT INHERITED
            d.Grow();
            s.Grow();    // METHOD IS INHERITED 
            const int DONT_CHANGE_ME= 500;
            // DONT_CHANGE_ME = 600;
            //d.NumLegs = 5;
            Console.WriteLine(EngineeringConstants.Constant01);
        }

        void DoThis(int a, int b, int c,int zebra, int cobra) {
            // deal with a PRIVATELY IN HERE
        }
    }

    public class Dog {
        public int Age { get; set; }
        public readonly int NumLegs = 4;
        // constructor
        public Dog(int Age)
        {
            this.Age = Age;
        }
        public Dog() { }
        public void Grow() { Age++; }  // yes this is inherited
    }
    class Spaniel : Dog {
        // Constructor must be made here also
        public Spaniel(int anyvariable) {
            this.Age = anyvariable;
        }

    }

    public static class EngineeringConstants
    {
        public static readonly double Constant01 = 2.45793;
    }

```

Static keyword

Regular class : can instantiate


Static class : cannot be instantiated

	eg Math.floor

	Static field

	Static method  : attached to class


static class Luton{
	static method SayHi(){}
}

Main(){
	Luton.SayHi();
}





Sparkhire Prep

	Press 'go'
		Question : 30 secs display 
		Answer   : 60 secs no repeat
	Everlasting pause until you press 'go' again 

Secrets of answering a question well

1. Get a blank sheet of paper

2. From scratch, your own mind, write down all you can remember about the key questions and the answers you will have to give.

3. Repeat again from scratch 2, 3, perhaps 4 times until you feel a flow in your own mind exactly what you want to say, so let the phrases flow.











Verbal Prep

Tell me a little bit about yourself in 60 seconds
What degree do you have and why did you choose it?
In a team setting what part do you play?  How do you see yourself?
Do you have any work experience?  What have you done in the area of paid work?
Before Sparta talk about 2 challenges that you have overcome
What have been your biggest challenges here at Sparta?

60 second questions

Struct : mini class with fully public fields

	struct Point{
		public int X;
		public int Y;
		public Point(int x, int y){
			this.X=x;
			this.Y=y;
		}
	}

		var p01 = new Point(10,20);

	Struct is a VALUE TYPE like an INT : very fast

Memory types
	STACK : FAST : int, bool,char and STRUCT!!!!
	HEAP  : SLOWER : classes, collection, array, strings

Sealed class

	class Parent{}
	class Child:Parent{}
	sealed class GrandChild:Child{}   // cannot derive below this point

		sealed class : good for IT security : can't inherit and create vulnerabilities

Overload  :  Methods have SAME NAME with DIFFERENT PARAMETERS
				DoThis(int x)
				DoThis(string y)

Override  :  Base Parent class has a method with code; Child derived class
				has same method with different code

					Override : Same method but different code (in derived 
										child class)

		virtual DoThis(){}      parent
		override DoThis(){}     child

Override vs New
	Override : replaces
	New : just 'hides' parent so can still call with 'base' keyword

Abstract class

	abstract class Parent{
		abstract void DoThis();      // missing 'code implementation'
	}	

	class Child : Parent{
		override void DoThis(){  // code }
	}


Polymorphism :   virtual in parent, override in child (optional)

Abstract     :   abstract in parent, override in child (mandatory)

class MyClass{
	private int _ field01;           // FIELD  UNDERSCORE, LOWER CASE
	int _ field02;                   // PRIVATE BY DEFAULT
	public int SomeDataItem{get;set;}        // PROPERTY PascalCase 
	public void DoSomething(){}
}

class Person{
	private int _ age;               // encapsulate hidden field
	// public GETTER to GET _ age
	public int GetAge(){             // abstraction : reveal with get/
		return _ age;                // set what we want
	}
	public void SetAge(int Age){
		this._ age=Age;
	}
}

ref    pass in integer into method; stays global in that method

			int x=100;
			void DoThis(ref int x){
				x++; // affect global x
			}

objects, collections, arrays, classes are already treated as 'reference' type which updates the global reference anyway

	        int[] array = {1,2,3}
	        void DoThis(int[] array){
	        	// update array
	        }

REFERENCE TYPE  stored in HEAP memory  (shortcut in STACK memory )
										(COPY : just copy the shortcut)

VALUE TYPE      stored in STACK memory

class Dog{
	
}

	INSTANTIATE : var dog = new Dog();

class Dog{
	public int Age{get;set;}
	public Dog(int Age){
		this.Age=Age;
	}
}
	INSTANTIATE : var dog = new Dog(10);

class Dog{
	static int NumLegs=4;
}

	ACCESS STATIC VARIABLE : Dog.NumLegs;  

		Static BELONGS TO THE CLASS 

Array
	int[] array = new int[10];
	int[] array = new int{1,2,3};
	var ....
List
	var l = new List<char>();
		Add('c')
		Remove()
Stack
	var s = new Stack<int>();
		Push(10)
		Pop()
Queue
	var q = new Queue<string>();
		Enqueue('hi');
		Dequeue();

Dictionary<int,string>()    int = index (unique)

   foreach(var (key,value) in mydict.keys){}

4 Access Modifiers  : encapsulate (hide) code 
	public
	private
	protected  :  class and children
	internal   :  inside final compiled .exe (assembly)


### Interface

3 levels of class inheritance

	1.   Regular class   Parent ==> Child

			Polymorphism works here  

						virtual in Parent .... override in Child

						class Parent{
							virtual void DoThis(){}
						}
						class Child:Parent{
							override void DoThis(){}
						}

	2.   Abstract class  Parent ==> Child

			Abstract parent has to have a child class.

					abstract class Parent{
						abstract void DoThis();
						void AlsoDoThis(){} // ok
						void AndThis(){} // ok
					}

				    class Child:Parent{
				    	override void DoThis(){}  // code 
				    }


			Note that abstract classes must have at least one abstract method but may
			contain any number of regular methods.


    3.   Interfaces

    	Problem with classes is that we can only inherit from 1 class

    		Think natural family : you can only belong to one family 

    	Interface is a structure that allows us to 'use' code from more than one place

    		Think garden shed : tools which we can 'implement' or 'use'

    		Class ==> Inherit 			ONE
    		Interface ==> Implement  	MANY 

    	interface IUseThisTool01{
    		// no fields
    		// yes properties
    		int number01{get;set}    // ASSUMED PUBLIC 
    		// yes methods
    		void DoThis(){}          // ASSUMED PUBLIC
    	}

    	class MyClass : IUseThisTool01{
    		public int number01{get;set;}
    		public void DoThis(){}  
    	}
    				


Class 

	Picture : Class is like the architectural blueprint which an architect creates
		as a plan for a building.  It's not a building but a builder can turn the plan
		into a real object.

	Computing : Class is a template for creating real objects

		Class Parent{}

							var p = new Parent();    p is real object INSTANCE created from
														class template


Class : blueprint or template from which we create real objects using `new` keyword (this is called instantiation)

	Class : template
	new   : instantiate real object







4 Pillars Of OOP

	Encapsulation : Hiding private fields/methods
	Abstraction : Hide private fields and Reveal public properties
	Inheritance : Base Parent => Derived Child
	Polymorphism : poly=many, morph=type
		Polymorphism allows many 'types' to exist
				Parent ==> method
				Child  ==> overide that method with its unique code

				Multiple children ==> poly (many) unique implementations


















Comment on:

Class

Struct mini class, stored as a fast 'value' type on the stack memory so is a very fast item

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_62_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            var p01 = new Point();   // default constructor
            p01.X = 10;
            p01.Y = 11;
            var p02 = new Point(10, 11);   // with constructor
            var p03 = new Point(11, 12);
        }
    }

    class Parent {
        public int height { get; set; }
    }

    // Points on line : want very fast, not much detail inside (X,Y)
    struct Point
    {
        public int X;  // public fields no hiding
        public int Y;
        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}

```
Enum

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_63_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fruit.banana);
            // use the numeric value also
            Console.WriteLine((int)Fruit.banana);
            // even add a count 
            Console.WriteLine($"There are {(int)Fruit.count} types of fruit");
            // add an invalid type with -1
            // Common example is days of week & months of year
            var d = DateTime.Now;
            Console.WriteLine(d.Month);
            Console.WriteLine(d.Day);
            Console.WriteLine((int)d.DayOfWeek);
            d = d.AddDays(-2);
            Console.WriteLine((int)d.DayOfWeek);
            d = d.AddDays(-1);
            Console.WriteLine((int)d.DayOfWeek);

            var fruityfruit = Fruit.plum;
    }

    // Enum is a structure to hold values which are not expected to 
    // change , ever
    // days of week or months of year or staff codes in a company
    enum Fruit
    {
        invalid=-1,banana,apple=1,pear=2,plum,peach,grape,count
    }
}

```

OOP
4 Pillars
Waterfall
Agile
Scrum
Product Owner
Scrum Master


Dev Team


Kanban : think non-stop factory : production never ceases.  

		backlog(todo)   selected    in development    for review     done


		                            max 5 items


	Kanban : from Toyota : 'just-in-time' model where want to deliver items on time continuously - get the 'flow' right.  At any one time we LIMIT AMOUNT OF ITEMS
	WE ARE WORKING ON.  Think bath plug - water leaves better if you limit amount of 'stuff' trying to escape the plughole


Scrum : start-stop : discrete stages 'iterations' of a product

Kanban : continuous flow of work, limiting active items at any one time








XP Extreme Programming / Pair Programming
Sprint
SDL Software Dev Lifecycle stages

Risk is chance % possibility that something will happen * impact if it did take place
	
	20% possiblity this week my shoe laces come loose ==> no impact ....

	0.0000001 of asteroid causing damage ....


	10% chance project delayed 2 months     £10,000 penalty



Mitigation of risk

	Ways to reduce risk

		Avoid...do something else
		Insure (Transfer)
		Do nothing (Accept)
		Mitigate (spend money to reduce risk)  ((think potholes on roads))


Abstract class
Virtual keyword
Override keyword
Overload

### .Base() in method

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_64_base
{
    class Program
    {
        static void Main(string[] args)
        {
            // parent : dothis
            var p1 = new Parent();
            p1.DoThis();
            // child : dothis
            var c1 = new Child();
            c1.DoThis();
        }
    }


    class Parent {
        public virtual void DoThis() {
            Console.WriteLine("I'm in the parent");
        }
    }
    class Child : Parent {
        public override void DoThis()
        {
            base.DoThis();
            Console.WriteLine("I'm in the child");
        }
    }
}


```


### base keyword in Constructor

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_64_base
{
    class Program
    {
        static void Main(string[] args)
        {
            // parent : dothis
            var p1 = new Parent();
            p1.DoThis();
            // child : dothis
            var c1 = new Child();
            c1.DoThis();
        }
    }


    class Parent {
        public virtual void DoThis() {
            Console.WriteLine("I'm in the parent");
        }
    }
    class Child : Parent {
        public override void DoThis()
        {
            base.DoThis();
            Console.WriteLine("I'm in the child");
        }
    }
}

```


While vs Do..While()
Collection
Faster - Array or collection?
x++;
break;
continue;






	What is a method return type?
	What is a method parameter?
	What is Pascal Case?
	What is Camel Case
	What is Snake Case?
	What is Kebab Case?
	What is an 'out' parameter
	What does 'passing by reference' mean?
	What is a reference type?
	What is a value type
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
	Give some examples of exceptions

	Can you create a github repo?  Write down about 10 things that you would do in order to create a master branch, then a dev branch, then push to the dev branch, then create a pull request to pull the dev branch into the master branch

	How would  you view all your commits on a local system?

	What does git reset do?  hard? soft?

	What is HTTPS SSL?
	What is SSH?

	What does SQL distinct do?
	what does SQL LIKE search for?
	What would SQL LIKE %a% find?   a%  ?         %a    ?


### Weekend Homework

Try and build this application again from scratch

WPF

Read Customers, Orders, Get OrderDetails and from this display the ProductName
Read Employees
Read Products
Read Suppliers

Can you select one Employee to display the Employee Name (in a text box) and edit it and update the database (Press a button to save changes)

	employee=(Employee)ListBox.SelectedItem

	TextBox01.Content = "Fred"

	ButtonUpdate.Click(){
		employee.FirstName=TextBox01.Content;
		db.SaveChanges();
	}

Can you select one Employee and delete it?

	employee=(Employee)ListBox.SelectedItem

	ButtonDelete.Click(){
		db.Remove(employee);
		db.SaveChanges();
	}

Can you add a new employee?
	employee = new Employee(){
	FirstName = "fred",
}
Reminder : we have done all this in the CONSOLE ALREADY SO FIND THE CONSOLE CODE AND USE THE SAME CODE BUT JUST HAVE TO ADD WPF DISPLAY ITEMS IN.



### Review

checked : throws an exception if your number gets too big or small

	unchecked : turns off again (default)

dynamic : turns off type checking at compile time

	dynamic x = 10;  // int
	x = true;        // bool

	((Note : Javascript does this by default))

Dynamic language : loose checking of types : even at runtime the type can possibly change as is the case with Javascript and also C# with 'dynamic' keyword.

Statically typed / strongly typed language : types are strictly defined at compile time.

	var keyword : type is still strictly inferred at compile time

Javascript - loose type checking

	Typescript - plug-in to Javascript where types are more strictly controlled

	using strict;  is Javascript in 'strict' mode also prevents switching type

	var x = 10;


## Tasks

Synchronous code runs line by line

	A long task causes the program to 'hang' which is not good for the user experience

Asynchronous code looks like this in C#

	async void/<Task> DoThis(){
		await ReadFileAsync("bigdatabasefile.txt")
			  Http call to remote item 
			  Network call to item on LAN network
			  Database read
			  Call to memory location 
			  Task which is going to take a while
	}

1	Main(){
2		Task t = DoThis();
3		Console.WriteLine("hi");
4		Console.ReadLine();
        // run task t
	}

			Code will run 1, 2, 3 and then will pause at line 4.
			While paused the async method will return and we could action it

	Critical thing is that code does not STOP!!!!  Keeps going!!!!  Async task
	returns whenever it wants to.



### Tasks under the hood

Main() thread ==> main process which is 'service' (user does not see) or application (user does see)

Service : 24/7 in background : at startup : eg DNS name lookup on internet

Application : foreground : at logon (user logs in) eg Outlook

Main Thread

	==> want to do a task which takes a long time

		C# : Create 'Task' object and run it.

			Operating system will control this task and its resources ie
			memory and CPU allocated to it.

Task manager
	main 
		sub-threads

Terminology

	service  24/7
	
	application at logon eg Outlook

	process - running .exe file which takes up Operating System resources on computer
						CPU
						RAM
						DISK
						NETWORK
	
	task
		separate process but linked to main process


	thread
		single block of code sent directly to CPU for execution now ie it's a single unit of code
		being executed

		ONE PROCESS
			MANY THREADS

	idle  
		CPU is idle most of the time!



## Practical Coding

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace lab_78_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            var s = new Stopwatch();
            s.Start();
            var t = new Task(
                () => {
                    Console.WriteLine("Starting Task Now at time " + s.ElapsedTicks);
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine($"Finishing task at time {s.ElapsedTicks}");
                }
            );

            t.Start();
     //       Thread.Sleep(700);
            Console.WriteLine($"Program has finished at time {s.ElapsedTicks}");
            Console.ReadLine();
            // run this program with line 28 and then run it without line 28 - is there a difference?
            // can you explain?

            // declare and start with the Run() command
            var t02 = Task.Run(
                // this thing is a 'delegate' which is a 'placeholder' for a method
                ()=> {
                    Console.WriteLine($"Running Task t02 at time {s.ElapsedTicks}");
                }
            );

            // older ways of declaring this

            // Action Delegate
            var t03 = Task.Run(

                new Action(Method01)

                );

            // another older way : explicitly using the 'delegate' keyword
            // anonymous delegate with the 'delegate' keyword
            var t04 = Task.Run(
                delegate
                {
                    Console.WriteLine($"In task t04 with anon delegate at {s.ElapsedTicks}");
                }
            );

            // last older way : Task.Factory

            var t05 = Task.Factory.StartNew(() => { Console.WriteLine($"In task 05");   });
        }

        static void Method01() {
            Console.WriteLine("In Method01");
        }

    }
}



```


### Task.Wait, WaitAny, WaitAll

We can pause our code until one or all of our tasks are complete


```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace lab_79_task_wait
{
    class Program
    {
        static void Main(string[] args)
        {
            // Real life : array of tasks simulate batch jobs processed
            // during night
            var s = new Stopwatch();
            s.Start();

            var taskArray = new Task[3];
            taskArray[0] = Task.Run(() => {
                Thread.Sleep(500);
                Console.WriteLine($"Task 01 finishing at {s.ElapsedTicks}");
            });
            taskArray[1] = Task.Run(() => {
                Thread.Sleep(1500);
                Console.WriteLine($"Task 02 finishing at {s.ElapsedTicks}");
            });
            taskArray[2] = Task.Run(() => {
                Thread.Sleep(2500);
                Console.WriteLine($"Task 03 finishing at {s.ElapsedTicks}");
            });

            var singleTask = Task.Run(() => {
                Thread.Sleep(5000);
                Console.WriteLine($"Single task is finishing at {s.ElapsedTicks}");
            });
           // Task.WaitAny(taskArray);  // wait until at least one task has completed
            Task.WaitAll(taskArray);   
            singleTask.Wait();
            Console.WriteLine($"Program finished at {s.ElapsedTicks}");
            Console.ReadLine();
     
        }
    }
}
```



### Interview Prep

Loops
Conditional if..else..
Exception try..catch..finally
String manipulate



Pantheon
	Equity -> Investment in a company which can take several forms, the most common of which
			is buying shares  3567uik6
	Shares : Public (traded on Stock Exchange)
	       : Private 




























### Random

RESTful API 

	REST Representational State Transfer

	HTTP REST API

		Data is sent to the client in JSON format

		{

			"key":"value",
			"key2":"value2"
		}

	Regular website : data is sent from server to client in HTTP format

		<html>... website

	Microsoft website : data is sent from ASP / ASPX web server to client as HTTP

	REST API : data is sent from server to client as text data in JSON { ... data ... }
				format

			EG Postcode.io  API

			   Northwind ASP API  where we used POSTMAN to inspect the data 

		Note : in order to deliver multiple records we use an array

		[
			{ "key1" : "value1", "name":"fred","age":2 },    first
			{ "key2" : "value2", "name":"bob","age":15 }     second
		]


AJAX

	Asynchronous Javascript And XML

	Ajax is very useful to put dynamic content onto a static web page

		Page does not refresh but data does refresh behind the scenes.




## Tuples

When we declare a method we can only return one type as the output

C#7 has created an easy way to return an anonymous type of whatever structure we want, with multiple fields inside it.

  (int, string) MyMethod(){

  	return 

}





## Review

Inheritance : Base to Derived
Members Which Are Inherited : Properties, Methods, Public/Protected/Internal Fields, 
Access Modifiers : public private internal protected
internal   in .exe  'Assembly'
protected  Parent to Child 
Abstract class   :   cannot instantiate, contains 1 or more abstract methods
Regular method             int DoThis(string y){  // code }
Abstract methods :         int DoThis(string y);
Code body 'implementation'  is code inside braces  { // code }
Instantiate : create object with 'new'
Concrete class   :   can instantiate

null coalescing operator
??
?.

Interface       Fully public, fully abstract. Can't have FIELDS.  


	IUseThisToolSet{
		Tool01();
		Tool02();
		Tool03();
	}  

	Class RealClass : IUseThisToolSet{
		Tool01(){}
		Tool02(){}
		Tool03(){}
	}

	IDisposable   enforce  Dispose()
	IComparable            CompareTo()
	IEnumerable            GetEnumerator()     // count over array

SOLID 
I : Interfaces single responsibility 

Abstract Class  Mixture of real and abstract methods



