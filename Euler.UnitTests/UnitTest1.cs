using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Eulers.EulerOne;

namespace Euler.UnitTests
{
    [TestFixture]
    public class Euler1
    {
        [Test]
        public void ListOfMultiples_WhenParametersGiven_ReturnsListOfMultiples()
        {
            //Arrange
            int multiple = 3;
            int max = 10;

            //Act
            var result = new ListOfMultiples(multiple, max);

            //Assert
            Assert.That(result, Is.Not.Empty);

            Assert.That(result.Count, Is.EqualTo(3));

            Assert.That(result, Does.Contain(3));
            Assert.That(result, Does.Contain(6));
            Assert.That(result, Does.Contain(9));

            Assert.That(result, Is.EquivalentTo(new[] { 3, 6, 9 }));

            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique);
        }
    }
}
