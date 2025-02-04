public class Parenthesis
{

    public bool CheckIfStringIsValidParenthesis(string s)
    {
        MyStack listNodes = new();

        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '{' || s[i] == '[' || s[i] == '(') listNodes.Append(new ListNode(){ val = s[i] });
            else 
            {
                switch(s[i])
                {
                    case '}':
                        if(listNodes.Peek().val != '{') return false;
                        else listNodes.Pop();
                        break;
                    case ']':
                        if(listNodes.Peek().val != '[') return false;
                        else listNodes.Pop();
                        break;
                    case ')':
                        if(listNodes.Peek().val != '(') return false;
                        else listNodes.Pop();
                        break;
                    default:
                        return false;
                }

            }
        }

        return true;
    }
}