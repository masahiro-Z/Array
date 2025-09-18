using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        namespace array
    {
        using System.Linq;

        internal class Program
        {



            static void Main(string[] args)
            { // ①
              // 宣言
                string[] list = { "aaa", "bbb", "ccc", "ddd", "abc" };

                // 条件分岐
                if (list.Contains("aaa"))
                { Console.WriteLine("含んでいます"); }

                else { Console.WriteLine("含んでいません"); }



                // ②



                // 宣言
                List<string> bird = new List<string> { "crow", "sparrow", "swallow", "pigeon" };
                bird.Remove("sparrow"); // 「sparrow」を削除
                bird.RemoveRange(1, 1); // 1番目のデータを削除


                foreach (string type in bird)
                { Console.Write(type + ","); }//出力
            }
        }
    }

