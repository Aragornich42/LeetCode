namespace LeetCode.EasyProblems;

public class Problem13
{
    public int RomanToInt(string s)
    {
        var compares = new Dictionary<char, int>
        {
            ['I'] = 1,
            ['V'] = 5,
            ['X'] = 10,
            ['L'] = 50,
            ['C'] = 100,
            ['D'] = 500,
            ['M'] = 1000
        };
        var exclusions = new Dictionary<string, int>
        {
            ["IV"] = 4,
            ["IX"] = 9,
            ["XL"] = 40,
            ["XC"] = 90,
            ["CD"] = 400,
            ["CM"] = 900,
        };
        var result = 0;
        var i = 0;
        
        while (i < s.Length)
        {
            if (i != s.Length - 1 && exclusions.TryGetValue(string.Concat(s[i], s[i + 1]), out int value))
            {
                result += value;
                i += 2;
            }
            else
                result += compares[s[i++]];
        }

        return result;
    }
    
    
    
    private static int CalcScale(char c, char a1, char a2) {
        return (c == a1 || c == a2) ? -1 : 1;
    }
    
    public int RomanToIntTheBest(string s)
    {
        int result = 0;
        
        for (int n = 0; n < s.Length; n++) {
            char nextChar = (n + 1 < s.Length) ? s[n + 1] : '\0';
            
            switch (s[n]) {
                case 'M': result += 1000; break;
                case 'D': result += 500; break;
                case 'C': result += 100 * CalcScale(nextChar, 'M', 'D'); break;
                case 'L': result += 50; break;
                case 'X': result += 10 * CalcScale(nextChar, 'C', 'L'); break;
                case 'V': result += 5; break;
                case 'I': result += 1 * CalcScale(nextChar, 'X', 'V'); break;
            }
        }
        return result;
    }
}