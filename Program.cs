using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52DersFieldPropertyAutoImplementedProperty
{
    class Program
    {

        class Insan
        {
            private string isim; //field-alan
            private int yas;     //field-alan

            public string Isim   //property-mülk (Propert sayesinde get ve set metotlarını burada kurabiliyoruz.)
            {
                get { return isim; }
                set { isim = value; }
            }

            public int Yas
            {
                get { return yas; }
                set { if (value >= 0) yas = value; } //Property icerisinde kosul ifadeleri de kullanabiliyoruz.
            }

            
            public string Cinsiyet { get; set; }  //Auto-Implemented Property *** Tek satirda hem property hem de field (gizli string cinsiyet ifadesi) olusturmus oluyoruz.          
            //public string Cinsiyet { get; private set; } //read-only
            //public string Cinsiyet { private get; set; } //write-only



        }
        static void Main(string[] args)
        {
            Insan i1 = new Insan();
            i1.Isim = "Muhammet Murat Pala";
            i1.Yas = -10;
            i1.Cinsiyet = "Erkek";
            Console.WriteLine(i1.Isim + " " + i1.Yas + " " + i1.Cinsiyet);
            Console.ReadLine();

        }
    }
}
