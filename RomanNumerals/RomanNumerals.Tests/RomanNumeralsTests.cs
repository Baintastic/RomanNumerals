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

        [TestCase("I", 1)]
        [TestCase("III", 3)]
        public void Convert_GivenANumberLessThan4_ShouldReturnItsRomanNumeral(string expected, int number)
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
        [TestCase("XXI", 21)]
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
        
        [TestCase("XL", 40)]
        [TestCase("XLIX", 49)]
        public void Convert_GivenANumberMoreThan39ButLessThan50_ShouldReturnItsRomanNumeral(string expected, int number)
        {
            //---------------Arrange-------------------
            var sut = new RomanNumerals();
            //---------------Act ----------------------
            var actual = sut.Convert(number);
            //---------------Assert -----------------------
            Assert.AreEqual(expected, actual);
        }

        [TestCase("L", 50)]
        [TestCase("LV", 55)]
        [TestCase("LXXXIX", 89)]
        public void Convert_GivenANumberMoreThan49ButLessThan90_ShouldReturnItsRomanNumeral(string expected, int number)
        {
            //---------------Arrange-------------------
            var sut = new RomanNumerals();
            //---------------Act ----------------------
            var actual = sut.Convert(number);
            //---------------Assert -----------------------
            Assert.AreEqual(expected, actual);
        }

        [TestCase("XC", 90)]
        [TestCase("XCIX", 99)]
        public void Convert_GivenANumberMoreThan89ButLessThan100_ShouldReturnItsRomanNumeral(string expected, int number)
        {
            //---------------Arrange-------------------
            var sut = new RomanNumerals();
            //---------------Act ----------------------
            var actual = sut.Convert(number);
            //---------------Assert -----------------------
            Assert.AreEqual(expected, actual);
        }

        [TestCase("C", 100)]
        [TestCase("CCI", 201)]
        [TestCase("CCCXCIX",  399)]
        public void Convert_GivenANumberMoreThan99ButLessThan400_ShouldReturnItsRomanNumeral(string expected, int number)
        {
            //---------------Arrange-------------------
            var sut = new RomanNumerals();
            //---------------Act ----------------------
            var actual = sut.Convert(number);
            //---------------Assert -----------------------
            Assert.AreEqual(expected, actual);
        }

        [TestCase("CD", 400)]
        [TestCase("CDXCIX", 499)]
        public void Convert_GivenANumberMoreThan399ButLessThan500_ShouldReturnItsRomanNumeral(string expected, int number)
        {
            //---------------Arrange-------------------
            var sut = new RomanNumerals();
            //---------------Act ----------------------
            var actual = sut.Convert(number);
            //---------------Assert -----------------------
            Assert.AreEqual(expected, actual);
        }

        [TestCase("D", 500)]
        [TestCase("DCCLXXVII", 777)]
        [TestCase("DCCCLXXV", 875)]
        public void Convert_Given500_ShouldReturnItsRomanNumeral(string expected, int number)
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
