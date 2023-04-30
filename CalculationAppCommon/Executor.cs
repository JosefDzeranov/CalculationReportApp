namespace CalculationAppCommon
{
    public class Executor
    {
        public string Name;

        public int RKK_Count;

        public int AppealsCount;

        public int TotalCount;

        public Executor(string name, int rKK_Count, int appealsCount, int totalCount)
        {
            Name = name;
            RKK_Count = rKK_Count;
            AppealsCount = appealsCount;
            TotalCount = totalCount;
        }
    }
}
