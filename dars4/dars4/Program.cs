namespace dars4;

internal class Program
{
    private static void Main(string[] args)
    {
        // 1.4.0 1
        // Console.WriteLine(Add(40,4));
        //string res = String.Empty;

        // 1.4.0 2
        //Console.WriteLine(Swap("xboxy"));

        // 1.4.0 3
        // Console.WriteLine(CountLowerCase("Hello World"));

        // 1.4.0 4
        // Console.WriteLine(GetNumber(10,20));

        // 1.4.0 5
        /*var n = int.Parse(Console.ReadLine());
        var res = CountRoom(n);
        Console.WriteLine(res);*/

        // 1.4.0 6
        // Console.WriteLine(isDigit("s1122"));

        // 1.4.0 7
        // Console.WriteLine(isPrime(17));

        // 1.4.0 8
        // Console.WriteLine(Reverse("hello"));

        // 1.4.0 9
        // Console.WriteLine(CountTheSpace("Hello World "));

        // 1.4.0 10
        // Console.WriteLine(IsPalindrome("kiyik"));

        // 1.4.0 11
        // Console.WriteLine(isDigit("s3244"));

        // 1.4.0 12
        // Console.WriteLine(CountNums("Akmal 77 Hello 17"));

        // 1.4.0 13
        // Console.WriteLine(CountUpperCase("Hello World"));

        // 1.4.0 14
        // Console.WriteLine(isUpper("HELLO"));
        // Console.WriteLine(isUpper("privET"));

        // 1.4.0 15
        // Console.WriteLine(isLower("salom"));
        // Console.WriteLine(isLower("salom274"));

        // 1.4.0 16
        // Console.WriteLine(ToUpperCase("akmal"));

        // 1.4.0 17
        // Console.WriteLine(CountOk("Akmal ok kk ko ok"));

        // 1.4.0 18
        // Console.WriteLine(Replace("akmal "));
        
        // 1.4.0 19
        // Console.WriteLine(ReplaceUpperToLower("AKMAL zor"));
        
        // 1.4.0 20
        // Console.WriteLine(ReplaceLowerToUpper("AKMAL ZOR"));
        
        // 1.4.0 21
        // Console.WriteLine(CountAt("ak@mal@"));
    }

    // 1.4.0 1
    //static int Add(int a, int b)
    //{
    //  return a + b;
    //}

    // 1.4.0 2
    /*static string Swap(string str)
    {
        str = str.Replace('y', 'z');
        str = str.Replace('x', 'y');

        return str;
    }*/

    // 1.4.0 3
    /*static int CountLowerCase(string str)
    {
        int count = 0;
        foreach (char c in str)
        {
            if (char.IsLower(c))
            {
                count++;
            }
        }
        return count;
    }*/

    /*static int GetNumber(int a, int b)
    {
        int counter = 0;
        for (int i = a; i < b; i++)
        {
            if (i % 2 == 0)
            {
                counter++;
            }
        }
        return counter;
    }*/

    // 1.4.0 5
    /*static int CountRoom(int n)
    {
        var counter = 0;
        while (n != 0)
        {
            n = n / 10;
            counter++;
        }

        return counter;
    }*/

    // 1.4.0 6
    /*static bool isDigit(string str)
    {
        foreach (var c in str)
        {
            if (char.IsDigit(c))
            {
                return true;
            }
        }
        return false;
    }*/

    // 1.4.0 7
    /*static bool isPrime(int num)
    {
        if (num < 2)
        {
            return false;
        }

        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }*/

    // 1.4.0 8
    /*static string Reverse(string s)
    {
        var res = string.Empty;
        for (var i = 0; i < s.Length; i++)
        {
            res = s[i] + res;
        }
        return res;
    }*/

    // 1.4.0 9
    /*static int CountTheSpace(string s)
    {
        var count = 0;

        foreach (var c in s)
        {
            if (c == ' ')
                count++;
        }
        return count;
    }*/

    // 1.4.0 10
    /*static bool IsPalindrome(string str)
    {
        var res = string.Empty;

        for (var i = str.Length - 1; i >= 0; i--)
        {
            res = res + str[i];
        }

        return str == res;
    }*/

    // 1.4.0 11
    /*static bool isDigit(string str)
    {
        foreach (char c in str)
        {
            if (!char.IsDigit(c))
                return false;
        }
        return true;
    }*/

    // 1.4.0 12
    /*static int CountNums(string s)
    {
        int counter = 0;

        foreach (char c in s)
        {
            if (char.IsNumber(c))
            {
                counter++;
            }
        }
        return counter;
    }*/

    // 1.4.0 13
    /*static int CountUpperCase(string s)
    {
        int counter = 0;

        foreach (char c in s)
        {
            if (char.IsUpper(c))
            {
                counter++;
            }
        }
        return counter;
    }*/

    // 1.4.0 14
    /*static bool isUpper(string s)
    {
        foreach (var c in s)
        {
            if (!char.IsUpper(c))
                return false;
        }
        return true;
    }*/

    // 1.4.0 15
    /*static bool isLower(string str)
    {
        foreach (char c in str)
        {
            if (!char.IsLower(c))
            {
                return false;
            }
        }
        return true;
    }*/

    // 1.4.0 16
    /*static string ToUpperCase(string s)
    {
        string res = string.Empty;

        foreach (char c in s)
        {
            if (char.IsLower(c))
            {
                res += char.ToUpper(c);
            }
            else res += c;
        }

        return res;
    }*/

    // 1.4.0 17
    /*static int CountOk(string str)
    {
        int count = 0;
        for (var i = 0; i < str.Length - 1; i++)
        {
            if (str[i] == 'o' && str[i + 1] == 'k')
            {
                count++;
            }
        }
        return count;
    }*/

    // 1.4.0 18
    /*static string Replace(string str)
    {
        var res = string.Empty;

        foreach (char c in str)
        {
            if (char.IsLower(c))
            {
                res += '*';
            }
            else
            {
                res += c;
            }
        }
        return res;
    }*/
    
    // 1.4.0 19
    /*static string ReplaceUpperToLower(string str)
    {
        string res = string.Empty;
        foreach (char c in str)
        {
            if (char.IsUpper(c))
            {
                res+=char.ToLower(c);
            }
            else
            {
                res += c;
            }
        }
        return res;
    }*/

    // 1.4.0 20
    /*static string ReplaceLowerToUpper(string str)
    {
        string res= string.Empty;
        foreach (char c in str)
        {
            if (char.IsLower(c))
            {
                res+=char.ToUpper(c);
            }
            else
            {
                res += c;
            }
        }
        return res;
    }*/
    
    // 1.4.0 21
    /*static int CountAt(string str)
    {
        int count = 0;
        foreach (char c in str)
        {
            if (c == '@')
            {
                count++;
            }
        }
        return count;
    }*/
}