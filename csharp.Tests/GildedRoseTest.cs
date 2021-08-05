// <copyright file="GildedRoseTest.cs">Copyright ©  2017</copyright>
using System;
using System.Collections.Generic;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using csharp;

namespace csharp.Tests
{
    /// <summary>This class contains parameterized unit tests for GildedRose</summary>
    [PexClass(typeof(GildedRose))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class GildedRoseTest
    {
        /// <summary>Test stub for .ctor(IList`1&lt;Item&gt;)</summary>
        [PexMethod]
        public GildedRose ConstructorTest(IList<Item> Items)
        {
            GildedRose target = new GildedRose(Items);
            return target;
            // TODO: add assertions to method GildedRoseTest.ConstructorTest(IList`1<Item>)
        }

        /// <summary>Test stub for UpdateQuality()</summary>
        [PexMethod]
        public void UpdateQualityTest([PexAssumeUnderTest]GildedRose target)
        {
            target.UpdateQuality();
            // TODO: add assertions to method GildedRoseTest.UpdateQualityTest(GildedRose)
        }
    }
}
