namespace Exercise104.Utils
{
    // Step 1: Define the extension method
    public static class StringExtensions
    {
        public static string ReverseWords(this string str)
        {
            // Split the string into words, reverse the array, and join them back into a string
            return string.Join(" ", str.Split(' ').Reverse());
        }
    }
}
