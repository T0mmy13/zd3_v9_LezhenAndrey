using Microsoft.VisualStudio.TestTools.UnitTesting;
using qwerty;
using System;

namespace qwerty_test
{
    [TestClass]
    public class TestsQwerty
    {
        [TestMethod]
        public void TestMethodStoreAllValuesRight()
        {
            Store store = new Store();
            string text1 = "5";
            string text2 = "10.5";
            bool result = store.CheckValues(text1, text2);
            Assert.IsTrue(result);
        }
        public void TestMethodStoreText2ValuesRight()
        {
            Store store = new Store();
            string text1 = "invalid";
            string text2 = "10.5";
            bool result = store.CheckValues(text1, text2);
            Assert.IsFalse(result);
        }
        public void TestMethodStoreText1ValueRight()
        {
            Store store = new Store();
            string text1 = "5";
            string text2 = "invalid";
            bool result = store.CheckValues(text1, text2);
            Assert.IsFalse(result);
        }
        public void TestMethodStoreAllValuesWrong()
        {
            Store store = new Store();
            string text1 = "invalid";
            string text2 = "invalid";
            bool result = store.CheckValues(text1, text2);
            Assert.IsFalse(result);
        }
        public void TestMethodExtendedStoreAllValuesRight()
        {
            ExtendedStore extendedStore = new ExtendedStore();
            string text1 = "5";
            string text2 = "10.5";
            string text3 = "12";
            bool result = extendedStore.CheckValues(text1, text2, text3);
            Assert.IsTrue(result);
        }
        public void TestMethodExtendedStoreText1ValueRight()
        {
            ExtendedStore extendedStore = new ExtendedStore();
            string text1 = "5";
            string text2 = "invalid";
            string text3 = "invalid";
            bool result = extendedStore.CheckValues(text1, text2, text3);
            Assert.IsFalse(result);
        }
        public void TestMethodExtendedStoreText1Text2ValueRight()
        {
            ExtendedStore extendedStore = new ExtendedStore();
            string text1 = "5";
            string text2 = "10.5";
            string text3 = "invalid";
            bool result = extendedStore.CheckValues(text1, text2, text3);
            Assert.IsFalse(result);
        }
        public void TestMethodExtendedStoreAllValuesWrong()
        {
            ExtendedStore extendedStore = new ExtendedStore();
            string text1 = "invalid";
            string text2 = "invalid";
            string text3 = "invalid";
            bool result = extendedStore.CheckValues(text1, text2, text3);
            Assert.IsFalse(result);
        }
    }
}
