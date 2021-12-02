namespace DataStructure.Algorithms.AlgorithmSwapVariablesWithoutTemporaryVariable
{
    public class AlgorithmSwapVariablesWithoutTemporaryVariable
    {
        public void Execute(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
    }
}
