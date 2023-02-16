using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        public delegate void MyDelagate(); // void döndüren ve parametre almayana delegelik yapar 
        public delegate void MyDelagate2(string text); // void döndüren ve parametre almayana delegelik yapar 

        static void Main(string[] args)
        {

            Cagrilar cagrilar= new Cagrilar();
            MyDelagate myDelagate = cagrilar.SendMessage; //mesaj gönderen delege
            myDelagate += cagrilar.ShowAlert;// uyarı yapan delege
            myDelagate();//oluşturulan delege çalıştırıldı.

            MyDelagate2 myDelagate2 = cagrilar.GetMessage;
            myDelagate2("Okey sir . I am be carreully.");
            Console.ReadLine();

        }

      public class Cagrilar
        {
            public void SendMessage()
            {
                Console.WriteLine("Hello.");

            }
            public void ShowAlert()
            {
                Console.WriteLine("Be carefull..!");

            }

            public void GetMessage(string text)
            {
                Console.WriteLine(text);

            }


        }

    }
}
