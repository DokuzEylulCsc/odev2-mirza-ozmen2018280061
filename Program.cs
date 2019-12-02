using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ödev_2
{

    class Program
    {
        // static string romanToDecimal(string str);

        static void Main(string[] args)
        {

            Console.Write("sayıyı roman rakamanı çevirmek için 1 yazınız  / roman rakamını  sayıya çevirmek için 2 yazınız ");
            int hangiİşlem;
            hangiİşlem = Convert.ToInt32(Console.ReadLine());
           
            

            if (hangiİşlem == 1)
            {   
                sayıdanRomana();

            }
            else if(hangiİşlem==2)
            {
                romandanSayiyaCevirme();
               
             
            }
            
            void sayıdanRomana()
            {
                int yuzlerBasamagı = 0, onlarBasamagı = 0, birlerbasamagı = 0, girilen;
                int binlerBasamagı = 0;

                string sonuc = "";


                Console.Write("sayıyı giriniz>>> ");

                girilen = Convert.ToInt32(Console.ReadLine());

                if (girilen <= 0 || girilen >= 4000)
                {
                    Console.WriteLine("Lütfen 0 ile 4000 arasında bir sayı giriniz");
                }

                if (girilen > 999)
                {
                    binlerBasamagı = girilen / 1000;
                    if (girilen - (binlerBasamagı * 1000) == 0)
                    {
                        goto ifSonu;
                    }
                    yuzlerBasamagı = (girilen - (binlerBasamagı * 1000)) / 100;
                    onlarBasamagı = (girilen - ((binlerBasamagı * 1000) + (yuzlerBasamagı * 100))) / 10;
                    birlerbasamagı = girilen - ((binlerBasamagı * 1000) + (yuzlerBasamagı * 100) + (onlarBasamagı * 10));
                }



                else if (girilen > 99)
                {
                    yuzlerBasamagı = girilen / 100;



                    onlarBasamagı = (girilen - (yuzlerBasamagı * 100)) / 10;

                    birlerbasamagı = girilen - ((yuzlerBasamagı * 100) + (onlarBasamagı * 10));
                }
                else if (girilen > 9)
                {
                    onlarBasamagı = girilen / 10;

                    birlerbasamagı = girilen - (onlarBasamagı * 10);
                }
                else
                {
                    birlerbasamagı = girilen;
                }


            ifSonu:


                if (binlerBasamagı > 0 && binlerBasamagı<4)
                {
                    switch (binlerBasamagı)
                    {
                        case 1:
                            sonuc = "M";
                            break;
                        case 2:
                            sonuc = "MM";
                            break;
                        case 3:
                            sonuc = "MMM";
                            break;

                    }
                }

                if (yuzlerBasamagı > 0)
                {
                    switch (yuzlerBasamagı)
                    {
                        case 1:
                            sonuc = sonuc + "C";
                            break;

                        case 2:
                            sonuc = sonuc + "CC";
                            break;

                        case 3:
                            sonuc = sonuc + "CCC";
                            break;

                        case 4:
                            sonuc = sonuc + "CD";
                            break;

                        case 5:
                            sonuc = sonuc + "D";
                            break;

                        case 6:
                            sonuc = sonuc + "DC";
                            break;

                        case 7:
                            sonuc = sonuc + "DCC";
                            break;

                        case 8:
                            sonuc = sonuc + "DCC";
                            break;

                        case 9:
                            sonuc = sonuc + "CM";
                            break;
                    }
                }
                if (onlarBasamagı > 0)
                {
                    switch (onlarBasamagı)
                    {
                        case 1:
                            sonuc = sonuc + "X";
                            break;

                        case 2:
                            sonuc = sonuc + "XX";
                            break;

                        case 3:
                            sonuc = sonuc + "XXX";
                            break;

                        case 4:
                            sonuc = sonuc + "XL";
                            break;

                        case 5:
                            sonuc = sonuc + "L";
                            break;

                        case 6:
                            sonuc = sonuc + "LX";
                            break;

                        case 7:
                            sonuc = sonuc + "LXX";
                            break;

                        case 8:
                            sonuc = sonuc + "LXXX";
                            break;

                        case 9:
                            sonuc = sonuc + "XC";
                            break;
                    }
                }

                if (birlerbasamagı > 0)
                {
                    switch (birlerbasamagı)
                    {
                        case 1:
                            sonuc = sonuc + "I";
                            break;

                        case 2:
                            sonuc = sonuc + "II";
                            break;

                        case 3:
                            sonuc = sonuc + "III";
                            break;

                        case 4:
                            sonuc = sonuc + "IV";
                            break;

                        case 5:
                            sonuc = sonuc + "V";
                            break;

                        case 6:
                            sonuc = sonuc + "VI";
                            break;

                        case 7:
                            sonuc = sonuc + "VII";
                            break;

                        case 8:
                            sonuc = sonuc + "VIII";
                            break;

                        case 9:
                            sonuc = sonuc + "IX";
                            break;
                    }
                }


                Console.WriteLine(sonuc.ToString());
                Console.ReadKey();
            }

        }

        private static Dictionary<char, int> romanlar = new Dictionary<char, int>()
        {
            {'I', 1} , {'V', 5} , {'X', 10} , {'L', 50} , {'C', 100} , {'D', 500} , {'M', 1000}
        };

        public static void romandanSayiyaCevirme()
        {
            string roman;
            Console.WriteLine("Roma rakamını giriniz lütfen >>>> ");
            roman = Console.ReadLine();
            int sayi = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                if (i + 1 < roman.Length && romanlar[roman[i]] < romanlar[roman[i + 1]])
                {
                    sayi -= romanlar[roman[i]];
                }
                else
                {
                    sayi += romanlar[roman[i]];
                }
            }
            Console.WriteLine(sayi);
        }

        //www.geeksforgeeks.org
        //https://www.yazilimbilisim.net/c-sharp/c-console-ile-girilen-sayiyi-roma-rakamina-cevirme/ burdan yararlanarak 1-3999 arasına entegre ettim 
        //www.youtube.com 

        // <<<<<<<<<<<<<<<<<<<<<<<<<Mirza Özmen  >>>>>>>>>>>>>><<<<<<<<<<<<<<2018280061>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

    }










}
    


