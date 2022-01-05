using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbutOOP
{
    class Zar
    {
        public int Sayi { get; set; }  // property (1 , 6)
        Random rasgele = new Random(); // field

        string[] yuzler = new string[6]
        {
            "   \n * \n   ", //1
            "*  \n   \n  *", //2
            "*  \n * \n  *", //3
            "* *\n   \n* *", //4
            "* *\n * \n* *", //5
            "***\n   \n***", //6
        };

        public string ZarAt()  // behavior 
        {
            Sayi = rasgele.Next(1, 7);
            return yuzler[Sayi - 1];
        }

    }
}
