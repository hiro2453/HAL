using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace haiandro
{
    internal class Deck
    {
        List<string> deck = new List<string>();
        public int n { get; set; }
        public int o {get;set;}
        string Mark = "";
        string result = "";
        public void Shuffle()
        {
            Console.OutputEncoding = Encoding.UTF8;
            deck.Clear();

            for (int i = 0; i < Properties.Settings.Default.set; i++)
            {
                List<string> singleDeck = new List<string>();
                string[] suits = { "S", "H", "D", "C" };
                string[] ranks = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13" };

                foreach (var suit in suits)
                {
                    foreach (var rank in ranks)
                    {
                        singleDeck.Add($"{suit}{rank}");
                    }
                }

                deck.AddRange(singleDeck);
                Console.WriteLine($">> {i + 1}個目のデッキ完成");
                Console.WriteLine($">> {deck.Count}");
            }

            n = deck.Count - 1;
            o = deck.Count - 1;
            Console.WriteLine(n);

            for (int i = n; i > 0; i--)
            {
                int j = RandomNumberGenerator.GetInt32(0, i + 1);
                (deck[i], deck[j]) = (deck[j], deck[i]);
            }
        }

        public string Card_kure()
        {
            string card = deck[n];
            
            char[] test = card.ToCharArray();
            switch (test[0])
            {
                case 'S':
                    Mark = "spade";
                    break;
                case 'H':
                    Mark = "heart";
                    break;
                case 'D':
                    Mark = "diamond";
                    break;
                case 'C':
                    Mark = "club";
                    break;
            }

            //charをstringに変換
            string Card_info = new string(test);

            //１文字目以降を取得
            result = Card_info.Substring(1);

            n--;

            return $"card_{Mark}_{result}";
        }

        public string What_AllCard()
        {
            return (o-n).ToString();
        }

        public string What_Mark()
        {
            return Mark;
        }

        public string What_number()
        {
            return result;
        }
    }
}
