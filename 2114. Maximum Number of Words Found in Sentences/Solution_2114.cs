namespace Leetcode._2114._Maximum_Number_of_Words_Found_in_Sentences
{
    public class Solution_2114
    {
        public int MostWordsFound(string[] sentences)
        {
            var length = 0;
            foreach (var sentence in sentences)
            {
                var l = sentence.Trim().Split(" ").Length;
                if (l > length)
                {
                    length = l;
                }
            }

            return length;
        }
    }
}