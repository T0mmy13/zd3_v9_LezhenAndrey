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
            string text2 = "10,5";
            string text3 = "Четвёрочка";
            bool result = store.CheckValues(text1, text2, text3);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestMethodStoreText2ValuesRight()
        {
            Store store = new Store();
            string text1 = "invalid";
            string text2 = "10,5";
            string text3 = "Четвёрочка";
            bool result = store.CheckValues(text1, text2, text3);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TestMethodStoreText1ValueRight()
        {
            Store store = new Store();
            string text1 = "5";
            string text2 = "invalid";
            string text3 = "Четвёрочка";
            bool result = store.CheckValues(text1, text2, text3);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TestMethodStoreAllValuesWrong()
        {
            Store store = new Store();
            string text1 = "invalid";
            string text2 = "invalid";
            string text3 = "Четвёрочка";
            bool result = store.CheckValues(text1, text2, text3);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TestMethodExtendedStoreAllValuesRight()
        {
            ExtendedStore extendedStore = new ExtendedStore();
            string text1 = "5";
            string text2 = "10,5";
            string text3 = "Четвёрочка";
            string text4 = "20";
            string text5 = "Россия";
            string text6 = "ул. Пушкина, д. Колотушкина";
            bool result = extendedStore.CheckValues(text1, text2, text3, text4, text5, text6);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestMethodExtendedStoreText1ValueRight()
        {
            ExtendedStore extendedStore = new ExtendedStore();
            string text1 = "5";
            string text2 = "invalid";
            string text3 = "Четвёрочка";
            string text4 = "invalid";
            string text5 = "Россия";
            string text6 = "ул. Пушкина, д. Колотушкина";
            bool result = extendedStore.CheckValues(text1, text2, text3, text4, text5, text6);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TestMethodExtendedStoreText1Text2ValueRight()
        {
            ExtendedStore extendedStore = new ExtendedStore();
            string text1 = "5";
            string text2 = "10,5";
            string text3 = "Четвёрочка";
            string text4 = "invalid";
            string text5 = "Россия";
            string text6 = "ул. Пушкина, д. Колотушкина";
            bool result = extendedStore.CheckValues(text1, text2, text3, text4, text5, text6);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TestMethodExtendedStoreAllValuesWrong()
        {
            ExtendedStore extendedStore = new ExtendedStore();
            string text1 = "invalid";
            string text2 = "invalid";
            string text3 = "Четвёрочка";
            string text4 = "invalid";
            string text5 = "Россия";
            string text6 = "ул. Пушкина, д. Колотушкина";
            bool result = extendedStore.CheckValues(text1, text2, text3, text4, text5, text6);
            Assert.IsFalse(result);
        }
    }
}
