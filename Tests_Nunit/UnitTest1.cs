using NUnit.Framework;
using lab_42_testme;
using lab_102_homework;
using lab_103_hw_classes;
using lab_104_hw_Stopwatch;
using lab_105_hw_Polymorphism;
using lab_hw_106_interview_prep;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;



namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Lab_42_TestMe_Test01()
        {
            // arrange
            var instance01 = new TestMe();
            var expected = 14.0;

            // act
            var actual = instance01.BIDMAS01(10, 20, 5);

            // assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(10,20,5,14.0)]
        [TestCase(20,30,6,25.0)]
        [TestCase(30,50,10,35)]
        public void Lab_42_TestMe_Test01(int a, int b, int c, double expected)
        {
            // arrange
            var instance01 = new TestMe();
            // act
            var actual = instance01.BIDMAS01(a, b, c);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1,2,3,4,5,-11)]
        public void Lab102_Collections_Test01(int a, int b, int c, int d, int e, int expected)
        {
            // arrange

            // act 
            var actual = Collections.UseCollections(a, b, c, d, e);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-1,-1,-1,-1)]
        public void Lab_103_hw_Classes_Test(int initialAge, int initialHeight,
            int finalAge, int FinalHeight)
        {
            // arrange
            var expected = -1;
            var instance = new Dog();

            // assert
            var actual = instance.Grow(out int finalheight);

            // act
            Assert.AreEqual(expected, actual);  // age
            Assert.AreEqual(expected, actual);  // height
        }

        // repeat this model for labs 104 and 105, passing in the right parameters 
        // and testing the right data is output.  
        // Create at least 3 tests per lab

        [TestCase("hello",3,108)]
        
        
        public void Lab_hw_106_ASCII_Tests(string input, int index, int expected)
        {
            // arrange
            var instance = new lab_hw_106_interview_prep.ASCII();
            // act
            var actual = instance.ASCII_Return_Index_Of_String(input, index);
            // assert
            Assert.AreEqual(expected, actual);       
        }
        [TestCase(1,1,1)]
        
        public void Lab_hw_106_Exception_Tests(int x, int y, int expected)
        {
            var instance = new lab_hw_106_interview_prep.ThrowException();
            var actual = instance.Throw_Exception_Test(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(400000000, 400000000)]
        public void Lab_hw_106_Exception_Tests_Throw_Exception(int x, int y)
        {
            var instance = new lab_hw_106_interview_prep.ThrowException();
            Assert.Throws<OverflowException>(() => {
                instance.Throw_Exception_Test(x, y);
            });
        }



    }
}