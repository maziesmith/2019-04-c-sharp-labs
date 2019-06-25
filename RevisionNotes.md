
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
                    private         encapsulates (hides) code from outside
                                    access : code ONLY IN THIS CLASS ONLY!!!
                    public          accessible from any code
                    protected       access : from code in THIS CLASS AND ALL DERIVED CHILD
                                                                 CLASSES ALSO
                    internal        access : from any code inside the compiled .exe or .dll
                                    file which is produced for this project ('Assembly')

    Polymorphism : poly = many, morph = type: polymorphism : can have one 'master' instruction but in the child classes, each child (derived) class may have its own implementation

            FAMILY : PARENT : Each child has own idea of how to throw a party!

    Inheritance

        Parent (Base) Class

            Child (Derived) Class





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

            Class ==> Inherit           ONE
            Interface ==> Implement     MANY 

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




















Class



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






