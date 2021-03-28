using System;
using System.Text;
using System.Collections.Generic;
namespace Prepare_Own
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> Ans = new List<string>();
            Solution f = new Solution();
            Ans= f.FullJustify(new string[] { "What", "is", "your", "Name", "?", "Please", "Tell", "me" }, 10 );
            foreach(string item in Ans)
            {
                Console.WriteLine(item);
            }
        }
    }
}
