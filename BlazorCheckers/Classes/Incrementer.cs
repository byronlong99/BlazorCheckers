namespace WebApplication1.Classes
{
    public static class Incrementer
    {
        public static int CurrentCount = 0;

        public static void IncrementCount()
        {
            CurrentCount++;
        }
    }
}