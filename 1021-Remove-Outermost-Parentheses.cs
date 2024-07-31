public class Solution {
            public string RemoveOuterParentheses(string s)
        {
            StringBuilder sb = new StringBuilder();
            int ParenthesesCounter = 0;
            foreach (char c in s)
            {
                if (c == '(')
                {
                    //ParenthesesCounter == 0 means its the outer '('
                    if (ParenthesesCounter > 0)
                    {
                        
                        sb.Append('(');
                    }
                    ParenthesesCounter++;
                }
                if (c == ')')
                {
                    //ParenthesesCounter == 1 means its the outer ')'
                    if (ParenthesesCounter > 1)
                    {
                        sb.Append(')');
                    }
                    ParenthesesCounter--;

                }
            }

            return sb.ToString();
        }

}

