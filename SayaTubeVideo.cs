using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpmod5_1302204026
{
    internal class SayaTubeVideo
    {
        private int id;
        private String title;
        private int PlayCount;
        public SayaTubeVideo(String title) 
        {
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            if (title == "")
                throw new NullReferenceException("title tidak boleh null");
            if (title.Length > 100)
                throw new Exception("panjang text maksimal 100");
            this.title = title;
            this.PlayCount = 0;
        }

        public void increasePlayCount(int a) { PlayCount++;}

        public void PrintVideoDetails() 
        {
            Console.WriteLine(this.id);
            Console.WriteLine(this.title);
            Console.WriteLine(this.PlayCount);
        }

    }
}
