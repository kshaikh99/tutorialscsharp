using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhadijaTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 2, 3, 4, 7, 8, 9, 10 };
            var array1 = new int[] { 2, 3, 4, 7, 8, 9, 10, 11 };
            var result1 = GetMedian(array);
             var result = GetMedian(array1);
        }

        static float GetMedian(int [] m)
        {
            if (m.Length % 2 != 0 )
            {
                // odd
                var mid = m.Length / 2;
                return m[mid];
            }
            else
            {
                // even
                var mid1 = m.Length / 2;
                var mid2 = mid1 - 1;
                return ((float)m[mid1] + (float)m[mid2]) / 2;
            }
        }

        static float GetMedian(List<int> array)
        {
            return GetMedian(array.ToArray());
        }

        static float GetMedian(string[] array)
        {
            var list = new List<int>();
            foreach(var i in array)
            {
                list.Add(i.Length);
            }

            return GetMedian(list);
        }
    }
}
