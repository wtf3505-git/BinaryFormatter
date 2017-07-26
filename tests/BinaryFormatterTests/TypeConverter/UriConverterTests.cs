﻿using System;
using Xunit;

namespace BinaryFormatterTests.TypeConverter
{
    public class UriConverterTests : ConverterTest<Uri>
    {
        public override Uri Value => new Uri("https://github.com/lukasz-pyrzyk/BinaryFormatter");

        [Fact]
        public void CanSerializeAndDeserialize()
        {
            RunTest();
        }
    }
}
