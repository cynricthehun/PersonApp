using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using DAL;

namespace BLLUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PeopleList_Provided()
        {
            // Arrange
            List<Person> actual = PersonRepository.createPersonRepo();
            List<Person> expected = new List<Person>();

            // Act
            expected.Add(new Person("Mahesh", "Chand", 35, "Male", "July 5"));

            // Assert
            Assert.AreEqual(actual[0].FirstName, expected[0].FirstName);
        }

        [TestMethod]
        public void PeopleList_RemovePerson()
        {
            // Arrange
            List<Person> actual = PersonRepository.createPersonRepo();
            var expectedCount = 5; // five entries are in by default.
            var actualCount = 0;

            // Act
            actual.Remove(actual[0]);
            actualCount = actual.Count;

            // Assert
            Assert.AreNotEqual(actualCount, expectedCount);
        }
    }
}
