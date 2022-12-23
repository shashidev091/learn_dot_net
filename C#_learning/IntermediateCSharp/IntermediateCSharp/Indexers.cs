﻿using System;
namespace IntermediateCSharp
{
    public class Indexers
    {
        private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();

        public string this[string key]
        {
            get { return this._dictionary[key]; }
            set { this._dictionary[key] = value; }
        }
    }
}

