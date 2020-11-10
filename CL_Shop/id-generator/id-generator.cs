using CL_Shop.IdGenerator;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CL_Shop
{
   public class Generator
    {
        static List<IndexPair> IndStorage = new List<IndexPair>();

        public static void registerIndexType(IndexPair arg)
        {
            Generator.IndStorage.Add(arg);
        }

        public static int getId(string type)
        {
            int ind = Generator.IndStorage.FindIndex(item => item.type == type);

            return Generator.IndStorage[ind].index++;
        }

        public static void createIndexForType(string t, int i)
        {

            IndexPair obj = new IndexPair(t, i);

            Generator.registerIndexType(obj);
        }
    }
}

