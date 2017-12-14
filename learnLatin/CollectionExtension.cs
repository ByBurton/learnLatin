//-------------------------------------------------------------------------------------------------
//Author: Maederer
//Company: page one GmbH
//Created: December, 14th, 2017
//File: CollectionExtension.cs
//Short Description: static class to get a random item from a list
//-------------------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;

namespace learnLatin
{
    public static class CollectionExtension
    {
        private static Random rng = new Random();

        public static T RandomElement<T>(this IList<T> list)
        {
            System.Threading.Thread.Sleep(rng.Next(250, 1000));
            return list[rng.Next(list.Count)];
        }

        /*public static T RandomElement<T>(this T[] array)
        {
            return array[rng.Next(array.Length)];
        } */
    }
}
