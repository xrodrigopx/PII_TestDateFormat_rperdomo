using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TestDateFormat;

namespace Library.Tests
{
    public class DateFormatterTests
    {
        [Test]
        public void TestCorrectFormat()
        {
            string input = "10/11/1997";
            string expectedOutput = "1997-11-10";
            Assert.AreEqual(expectedOutput, DateFormatter.ChangeFormat(input));
        }

        [Test]
        public void TestIncorrectFormat()
        {
            string input = "10/11/1997/2000";
            string expectedOutput = string.Empty;
            Assert.AreEqual(expectedOutput, DateFormatter.ChangeFormat(input));
        }

        [Test]
        public void TestEmptyDate()
        {
            string input = string.Empty;
            string expectedOutput = string.Empty;
            Assert.AreEqual(expectedOutput, DateFormatter.ChangeFormat(input));
        }
    }
}
