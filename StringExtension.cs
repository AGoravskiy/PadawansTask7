using System;
using System.Linq;
using System.Collections;

namespace PadawansTask7
{
    public class StringExtension
    {
        public static void OrderStringsByLength(string[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }
            if (array.Length == 0)
            {
                throw new ArgumentException();
            }

            string temp = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].Length > array[j + 1].Length)
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            //Array.Sort(array, new comp());
            // return array.OrderBy(x => x.Length).ToArray();
        }


        //public class comp:IComparer
        //{
        //    public int Compare(object a, object b)
        //    {
        //        if (a.ToString().Length > b.ToString().Length)
        //            return 1;
        //        else if (a.ToString().Length == b.ToString().Length)
        //            return 0;
        //        return -1;

        //    }
        //}
    }
}
