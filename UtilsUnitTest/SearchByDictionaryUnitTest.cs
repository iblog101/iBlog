using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utils;

namespace UtilsUnitTest
{
    [TestClass]
    public class SearchByDictionaryUnitTest
    {

        [TestMethod]
        public void SearchByDictionaryWordTest()
        {


            Assert.IsTrue(SearchByDictionaryWord.SearchByEnglishDictionary("hello"));
            Assert.IsTrue(SearchByDictionaryWord.SearchByEnglishDictionary("apple"));
            Assert.IsTrue(SearchByDictionaryWord.SearchByEnglishDictionary("cat"));
            Assert.IsTrue(SearchByDictionaryWord.SearchByEnglishDictionary("Cat"));
            Assert.IsTrue(SearchByDictionaryWord.SearchByEnglishDictionary("cAt"));
            Assert.IsTrue(SearchByDictionaryWord.SearchByEnglishDictionary("caT"));
            Assert.IsTrue(SearchByDictionaryWord.SearchByEnglishDictionary("CAT"));
            Assert.IsTrue(SearchByDictionaryWord.SearchByEnglishDictionary("pineapple"));
            Assert.IsTrue(SearchByDictionaryWord.SearchByEnglishDictionary("a"));


            Assert.IsFalse(SearchByDictionaryWord.SearchByEnglishDictionary("hello12"));
            Assert.IsFalse(SearchByDictionaryWord.SearchByEnglishDictionary("appl"));
            Assert.IsFalse(SearchByDictionaryWord.SearchByEnglishDictionary("catt"));



        }
    }
}
