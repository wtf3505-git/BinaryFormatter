﻿using BinaryFormatter;
using Xunit;

namespace BinaryFormatterTests
{
    public class BinaryConverterTests
    {
        [Fact]
        public void CanSerializeObject()
        {
            Test test = new Test(5, 4, "Lorem ipsum");

            BinaryConverter p = new BinaryConverter();
            byte[] array = p.Parse(test);

            Assert.NotNull(array);
            Assert.NotEmpty(array);
        }

        internal class Test
        {
            public Test(int x, int y, string word)
            {
                X = x;
                Y = y;
                Word = word;
            }

            public int X { get; set; }
            public int Y { get; set; }
            public string Word { get; set; }
        }
    }
}