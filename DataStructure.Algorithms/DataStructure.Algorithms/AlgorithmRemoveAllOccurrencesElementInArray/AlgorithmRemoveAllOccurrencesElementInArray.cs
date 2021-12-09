namespace DataStructure.Algorithms.AlgorithmRemoveAllOccurrencesElementInArray
{
    public class AlgorithmRemoveAllOccurrencesElementInArray
    {
        public int Execute(int[] array, int removingNumber)
        {
            if (array == null || array.Length == 0)
                return 0;

            var nextIndexNotRemovingElement = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] != removingNumber)
                {
                    array[nextIndexNotRemovingElement] = array[i];
                    nextIndexNotRemovingElement++;
                }
            }

            return nextIndexNotRemovingElement;
        }
    }
}
