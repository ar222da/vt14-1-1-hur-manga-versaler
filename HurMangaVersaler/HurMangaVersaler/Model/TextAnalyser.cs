using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HurMangaVersaler.Model
{
    public static class TextAnalyser
    {
        public static int GetNumberOfCapitals(string text)
        {
            int capitalLetters = 0;

            foreach (char i in text)
            {
                if (Char.IsUpper(i))
                {
                    capitalLetters++;
                }
            }
            return capitalLetters;
        }
    }
}