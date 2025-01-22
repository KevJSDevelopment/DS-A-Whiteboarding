public class ReverseOnlyLetters {
    public string ReverseLetters(string s) {
        char[] reversedChars = s.ToCharArray(); // Initialize with original string
        
        int i = 0;
        int j = s.Length - 1;
        
        while(i < j)
        {  
            if(char.IsLetter(s[i]) && char.IsLetter(s[j]))
            {
                reversedChars[i] = s[j];
                reversedChars[j] = s[i];
                i++;
                j--;
            }
            else if (char.IsLetter(s[i]) && !char.IsLetter(s[j]))
            {
                j--;
            }
            else if (!char.IsLetter(s[i]) && char.IsLetter(s[j]))
            {
                i++;
            }
            else
            {
                i++;
                j--;
            }
        }

        return new string(reversedChars);
    }
}