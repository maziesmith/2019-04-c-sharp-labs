using NUnit.Framework;
using lab_42_testme;
using lab_102_homework;

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



    }
}