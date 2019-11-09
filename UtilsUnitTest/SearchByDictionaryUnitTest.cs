using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilsExtension;

namespace UtilsUnitTest
{
    [TestClass]
    public class SearchByDictionaryUnitTest
    {

        [TestMethod]
        public void SearchByDictionaryWordTest()
        {

            //good cases
            string test1 = "apple";
            string test2 = "cat";
            string test3 = "Cat";
            string test4 = "cAt";
            string test5 = "a";
            string test6 = "b";
            string test7 = "pineapple";
            //bad cases
            string test8 = "hello12";
            string test9 = "hello123";
            string test10 = "java12";
            string test11 = "lovee";
            string test12 = "catt";


            Assert.IsTrue(test1.SearchByEnglishDictionary());
            Assert.IsTrue(test2.SearchByEnglishDictionary());
            Assert.IsTrue(test3.SearchByEnglishDictionary());
            Assert.IsTrue(test4.SearchByEnglishDictionary());
            Assert.IsTrue(test5.SearchByEnglishDictionary());
            Assert.IsTrue(test6.SearchByEnglishDictionary());
            Assert.IsTrue(test7.SearchByEnglishDictionary());


            Assert.IsFalse(test8.SearchByEnglishDictionary());
            Assert.IsFalse(test9.SearchByEnglishDictionary());
            Assert.IsFalse(test10.SearchByEnglishDictionary());
            Assert.IsFalse(test11.SearchByEnglishDictionary());
            Assert.IsFalse(test12.SearchByEnglishDictionary());



        }
    }
}
