namespace Day1Homework
{
    public interface IDataSource<T> where T : struct
    {
        int[] GetSum(int groupNum);
    }
}