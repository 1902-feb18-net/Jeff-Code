using System;
using Xunit;

namespace CollectionTesting.Tests

//Testing files are used to make sure that the codes does what we expect it to do.
//instead of testing manually by putting in values one by one, this can be used to
//automatically do it.
//We must write certain instructions for the test and then what we expect the result to be.
//This helps debug much quicker.
    //Unit Testing: 
    //We test small pieces at a time so that we can know more specifically
    //where the bug is.

    //Integration Testing:
    //Test the code all at once.
{
    public class MyStringCollectionTests
    {
        [Fact]
        // What is the actucal behavior I am testing?... Keep this in mind
        public void AddShouldNotThrowException()
        {
            //Arange
            var collection = new MyStringCollection();

            //Act
            collection.Add("abc");

            //Assert
            Assert.True(result);
        }
        [Fact]
        public void ContainsShouldBeTrueForContained()
        {
            var collection = new MyStringCollection();

            collection.Contains("asdf");

            Assert.True(result);
        }
    }
}
