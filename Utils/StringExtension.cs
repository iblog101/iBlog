using NHunspell;
using System;
using System.Collections.Generic;
using System.IO;
using System.Configuration;

namespace UtilsExtension
{
    public static class StringExtension
    {
        public static bool SearchByEnglishDictionary(this string wordToCheck)
        {
            NetSpell.SpellChecker.Dictionary.WordDictionary EnglishDictionary = new NetSpell.SpellChecker.Dictionary.WordDictionary();

            string LocalPath = Environment.CurrentDirectory;
            //string newPath = Path.GetFullPath(Path.Combine(LocalPath, ".."));
            string test = Directory.GetParent(Environment.CurrentDirectory).ToString();
            string correctPath = $"{test}\\Utils\\en-US.dic";
            //bool vale = test1.Equals("C:\\Users\\z8410\\Desktop\\iBlog\\Utils\\en-US.dic");
  
            EnglishDictionary.DictionaryFile = ConfigurationManager.AppSettings["DictonaryPath"]; //dictionary file location, if I replace path with correctPath, file not found errror for no reason.
            EnglishDictionary.Initialize();
            NetSpell.SpellChecker.Spelling spellingChecker = new NetSpell.SpellChecker.Spelling();

            spellingChecker.Dictionary = EnglishDictionary;
            if (!spellingChecker.TestWord(wordToCheck))
            {
                //Word does not exist in dictionary
                Console.WriteLine("Not a dictionary word");
                return false;
            }
            else
            {
                Console.WriteLine("Dictionary word");
                return true;
            }

          //another appoarch
          //  using (Hunspell hunspell = new Hunspell("en_us.aff", "en_us.dic"))
          //  {

          //      bool WordChecker = hunspell.Spell(wordToCheck);
          //      return WordChecker;

          //  }
          }

    }
}
