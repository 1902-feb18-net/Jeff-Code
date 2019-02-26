using NUnit.Framework;
using System;
using Xunit;


namespace Tests
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}