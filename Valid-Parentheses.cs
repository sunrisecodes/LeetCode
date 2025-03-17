    public class Solution
    {
        private static readonly Dictionary<char, char> pairsDict = new Dictionary<char, char>
        {
            {')', '('},
            {']', '['},
            {'}', '{'}
        };
        private static readonly HashSet<char> openingPranthes = new HashSet<char>()
        {
            '(', '[','{'
        };
        public bool IsValid(string s)
        {
          
            Stack<char> stack = new Stack<char>();

           //using foreach instead of while as we dont have to intialie manual index
            foreach (var item in s)
            {
                if (openingPranthes.Contains(item))
                    stack.Push(item);
                else
                {
                    if (stack.Count == 0|| stack.Pop() != pairsDict[item])
                        return false;
                }
           
            }

            return stack.Count == 0;
        }
    }
