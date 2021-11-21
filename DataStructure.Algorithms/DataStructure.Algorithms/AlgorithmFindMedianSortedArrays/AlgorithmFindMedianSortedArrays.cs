using System;

namespace DataStructure.Algorithms.AlgorithmFindMedianSortedArrays
{
    public class AlgorithmFindMedianSortedArrays
    {
        public double Execute(int[] array1, int[] array2)
        {
            int arrayLength1 = array1.Length;
            int arrayLength2 = array2.Length;
            if (arrayLength1 > arrayLength2) return Execute(array2, array1);

            int arrayMiddleLength = (arrayLength1 + arrayLength2 + 1) / 2;
            int left = 0;
            int right = arrayLength1;
            while (left < right)
            {
                var k1 = (right - left) / 2 + left;
                var k2 = arrayMiddleLength - k1;
                if (array1[k1] < array2[k2 - 1])
                {
                    left = k1 + 1;
                }
                else
                {
                    right = k1;
                }
            }

            var m1 = left;
            var m2 = arrayMiddleLength - left;

            var c1 = Math.Max((m1 <= 0 ? int.MinValue : array1[m1 - 1]), (m2 <= 0 ? int.MinValue : array2[m2 - 1]));

            if ((arrayLength1 + arrayLength2) % 2 == 1)
                return c1;

            var c2 = Math.Min((m1 >= arrayLength1 ? int.MaxValue : array1[m1]), (m2 >= arrayLength2 ? int.MaxValue : array2[m2]));

            return (c1 + c2) * 0.5;

        }
    }
}
