namespace BlazorWasm.Pages
{
    public partial class Counter
    {
        public int currentCount = 0;

        public void IncrementCount()
        {
            try
            {
                throw new Exception("This is a test exception.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            currentCount++;
        }
    }
}
