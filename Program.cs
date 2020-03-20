using System;

namespace MOHAMMED
{


    /****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2019-2020 BAHAR DÖNEMİ
**
** ÖDEV NUMARASI : 1
** ÖĞRENCİ ADI :MOHAMMED SAMI BA HAMID
** ÖĞRENCİ NUMARASI : B171200558
** DERSİN ALINDIĞI GRUP : A
****************************************************************************/
    class Program
    {
        static void Main(string[] args)
        {

            int sel;

            // Ueser should select from 1 to 3 
        Be: do
            {
                Console.WriteLine("Please selecet from 1 to 3\n" +
                       "1-Create a contact . \n" +
                       "2-Show me The contacts .\n" +
                       "3-Exet .");
                sel = int.Parse(Console.ReadLine());
            } while (sel > 3);
            int i, n, e, add;

          //Switch gonna compare which number user have entered

            switch (sel)
            {
                case 1:
                nok: Console.WriteLine("How many contacts you want to create ?");
                    add = int.Parse(Console.ReadLine());
                    string[] liste = new string[add];

                    for (n = 0; n < add; n++)
                    {
                        Console.Write(1 + n + ". Enter first name please : ");
                        string name = Console.ReadLine();
                        Console.Write(1 + n + ". Enter last name please : ");
                        string las = Console.ReadLine();
                        Console.Write(1 + n + ". Enter the adress please : ");
                        string adress = Console.ReadLine();
                        Console.Write(1 + n + ". Enter the phone number please : ");
                        string phone = Console.ReadLine();
                        Console.Write("------------------------------\n");
                        string all = name + " " + las + "\n" + adress + "\n" + phone;

                        liste[n] = all;
                    }

                    //Here we have question if user sure the program continue

                    Console.Write("Are you sure ?\n1-Yes 2-No ");
                    int r = int.Parse(Console.ReadLine());
                    if (r == 2)
                    {
                        goto nok;
                    }


                    Console.WriteLine("Do you wanna see contacts ?\n1-Yes\t2-No");
                    e = int.Parse(Console.ReadLine());
                    if (e == 1)
                    {
                        for (i = 0; i < add; i++)
                        {
                            Console.WriteLine("\n" + liste[i] + "\n==============");
                        }
                    }


                    break;
                case 2:
                    Console.Write("Sorry you didn't create any contact");
                    Console.WriteLine("\nDo you want to back ?\n1-Yes\t2-No Thanks");
                    int dd = int.Parse(Console.ReadLine());
                    if (dd == 1)
                    {

                        goto Be;
                    }

                    break;


                case 3:

                    Console.WriteLine("Have a nice day");
                    break;

            }






            Console.ReadKey();

            





        }
    }
}
