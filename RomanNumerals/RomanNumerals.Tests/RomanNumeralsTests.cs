using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals.Tests
{
    [TestFixture]
    public class RomanNumeralsTests
    {

        [TestCase("I",1)]
        [TestCase("III", 3)]
        public void Convert_GivenANumberLessThan4_ShouldReturnItsRomanNumeral(string expected , int number)
        {
            //---------------Arrange-------------------
            var sut = new RomanNumerals();
            //---------------Act ----------------------
            var actual = sut.Convert(number);
            //---------------Assert -----------------------
            Assert.AreEqual(expected, actual);
        }

        [TestCase("IV", 4)]
        public void Convert_Given4_ShouldReturnItsRomanNumeral(string expected, int number)
        {
            //---------------Arrange-------------------
            var sut = new RomanNumerals();
            //---------------Act ----------------------
            var actual = sut.Convert(number);
            //---------------Assert -----------------------
            Assert.AreEqual(expected, actual);
        }


        [TestCase("V", 5)]
        [TestCase("VIII", 8)]
        public void Convert_GivenANumberMoreThan4ButLessThan9_ShouldReturnItsRomanNumeral(string expected, int number)
        {
            //---------------Arrange-------------------
            var sut = new RomanNumerals();
            //---------------Act ----------------------
            var actual = sut.Convert(number);
            //---------------Assert -----------------------
            Assert.AreEqual(expected, actual);
        }


        [TestCase("IX", 9)]
        //[TestCase("VIII", 8)]
        public void Convert_Given9_ShouldReturnItsRomanNumeral(string expected, int number)
        {
            //---------------Arrange-------------------
            var sut = new RomanNumerals();
            //---------------Act ----------------------
            var actual = sut.Convert(number);
            //---------------Assert -----------------------
            Assert.AreEqual(expected, actual);
        }

        [TestCase("X", 10)]
        [TestCase("XI", 11)]
        [TestCase("XIX", 19)]
        [TestCase("XXI", 21)]
        [TestCase("XXV", 25)]
        [TestCase("XXXIX", 39)]
        public void Convert_GivenANumberMoreThan9ButLessThan40_ShouldReturnItsRomanNumeral(string expected, int number)
        {
            //---------------Arrange-------------------
            var sut = new RomanNumerals();
            //---------------Act ----------------------
            var actual = sut.Convert(number);
            //---------------Assert -----------------------
            Assert.AreEqual(expected, actual);
        }



    }
}
