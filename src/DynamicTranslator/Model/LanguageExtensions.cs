﻿using System.Collections.Generic;
using System.Linq;

namespace DynamicTranslator.Core.Model
{
    public static class LanguageExtensions
    {
        public static IList<Language> ToLanguages(this IDictionary<string, string> languageDictionary)
        {
            return languageDictionary.Select(pair => new Language(pair.Key, pair.Value)).ToList();
        }
    }
}