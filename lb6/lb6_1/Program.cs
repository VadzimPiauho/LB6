using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Вот дом, Который построил Джек. А это пшеница, Которая в темном чулане хранится В доме, Который построил Джек. А это веселая птица-синица, Которая часто ворует пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";
            List<string> wordCount = new List<string>();
            Dictionary<int,string> finalResult = new Dictionary<int,string>(); 
            int i;
            int k = 1;            
            string[] split = text.Split(' ', '.', ',', '!', '\'');
            foreach (string s in split)
            {
                if (s != "")
                {
                    //Console.WriteLine(s);
                    
                    wordCount.Add(s);
                }
            }
            //ICollection<int> keys = wordCount.Keys;
            //Console.WriteLine("Всего слов -> {0}", i);
            //foreach (int j in keys)
            //{
            //    Console.WriteLine("{2}.\t{1}\t\t{0}", j, wordCount[j], k);
            //    k++;
            //}
            for (i = 0; i < wordCount.Count; i++)
            {
                k = 0;
                for (int j = 0; j < wordCount.Count; j++)
                {     
                    if (wordCount[i]== wordCount[j])
                    {
                        k++;
                    }
                }
                finalResult.Add(k, wordCount[i]);
            }     


            Console.WriteLine("\t\t\t{0}\t\t{1}", "Слово:","Кол-во:");
            foreach (KeyValuePair<int, string> keyValue in finalResult)
            {                
                Console.WriteLine("{2}.\t{1}\t\t{0}", keyValue.Key, keyValue.Value.PadLeft(20), k);
                k++;
            }
            Console.WriteLine("Всего слов: {0} из них уникальных:", finalResult.Count);

        }

    }
}
