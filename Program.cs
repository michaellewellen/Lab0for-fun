using System.Diagnostics;
internal class Program
{
    private static void Main(string[] args)
    {
        Debug.Assert(isPallendromic("mom") == true, "mom is Pallendromic");
        Debug.Assert(isPallendromic("madam")== true, "madam is Pallendromic");
        Debug.Assert(isPallendromic("bill")==false, "bill is Not Pallendromic");
        Debug.Assert(isPallendromic("Mom")==true, "Mom is pallendromic");
        Debug.Assert(isPallendromic("Madam I'm Adam")== true, "Madam I'm Adam is pallendromic");
        Debug.Assert(isPallendromic("A man, a plan, a canal: Panama")==true);
        static bool isPallendromic(string s)
        {
            s = s.ToLower();
            string[] temp = s.Split(" ");
            s = String.Join("",temp);               
            string reverse="";
            List<char> charArray= new List<char>();
            for(int i = 0; i< s.Length; i++)
            {
                if(s[i] >= 97 && s[i] <= 122)
                 {
                    reverse = s[i] + reverse;
                    charArray.Add(s[i]);
                 }

            }
            s = new string(charArray.ToArray());
            
            Console.Write($"{s} {reverse}");
            Console.WriteLine();
            if (s == reverse)
            {
                //Console.WriteLine($"{s} is pallendromic");
                return true;
            }
            else 
            {
                //Console.WriteLine($"{s} is not pallendromic");
                return false;
            }
        }
    }   
}