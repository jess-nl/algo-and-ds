namespace Practice.Helper
{
    public static class Print
    {
        public static void PrintIntArray(this int[] array)
        {
            Console.WriteLine(string.Join(", ", array.Select(x => x.ToString())));
        }
    }
}
