using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastanede_bulunan_kişileri_yaşlarına_göre_sıralama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool hata = false;
            Console.Write("Hasta sayısını giriniz: ");

            int hasta_sayisi = Convert.ToInt32(Console.ReadLine());

            string[] hastalar = new string[hasta_sayisi];

            int[] hasta_yasi = new int[hasta_sayisi];
            int[] hasta_yasi2 = new int[hasta_sayisi];

            string[] hasta_adi = new string[hasta_sayisi];
            string[] hasta_adi2 = new string[hasta_sayisi];

            for (int i = 0; i < hastalar.Length; i++)
            {
                Console.Write("{0}. hastanın yaşını giriniz: ",i+1);
                hasta_yasi[i] = Convert.ToInt32(Console.ReadLine());
                hasta_yasi2[i] = hasta_yasi[i];

                Console.Write("{0}. hastanın adını giriniz: ",i+1);
                hasta_adi[i] = Console.ReadLine();
                hasta_adi2[i] = hasta_adi[i];

            }

            do
            {
                Console.Write("Kişileri yaşlarına göre nasıl sıralamak istersiniz? (artan/azalan): ");
                string siralama_turu = Console.ReadLine();

                if (siralama_turu == "artan")
                {
                    KucuktenBuyugeSiralama(hastalar, hasta_sayisi, hasta_yasi, hasta_yasi2, hasta_adi, hasta_adi2);
                    hata = false;
                }

                else if (siralama_turu == "azalan")
                {
                    BuyuktenKucugeSiralama(hastalar, hasta_sayisi, hasta_yasi, hasta_yasi2, hasta_adi, hasta_adi2);
                    hata = false;
                }
                else
                {
                    Console.WriteLine("------------------------------HATA!!!!------------------------------");
                    hata = true;
                }
            } while (hata);

            Console.ReadLine();
        }

        static void BuyuktenKucugeSiralama(string[] hastalar,int hasta_sayisi,int[] hasta_yasi,int[] hasta_yasi2,string[] hasta_adi,string[] hasta_adi2)
        {
            for (int i = 0; i < hastalar.Length; i++)
            {
                for (int j = 0; j < hastalar.Length - 1; j++)
                {
                    if (hasta_yasi[j + 1] > hasta_yasi[j])
                    {
                        hasta_yasi[j + 1] = hasta_yasi[j];
                        hasta_yasi[j] = hasta_yasi2[j + 1];
                        hasta_adi[j + 1] = hasta_adi[j];
                        hasta_adi[j] = hasta_adi2[j + 1];
                    }
                }
            }

            for (int i = 0; i < hasta_sayisi; i++)
            {
                Console.Write("{0}. Hastanın adı: {1} ====> Hastanın yaşı: {2} \n", i + 1, hasta_adi[i], hasta_yasi[i]);
            }
        }

        static void KucuktenBuyugeSiralama(string[] hastalar, int hasta_sayisi, int[] hasta_yasi, int[] hasta_yasi2, string[] hasta_adi, string[] hasta_adi2)
        {
            for (int i = 0; i < hastalar.Length; i++)
            {
                for (int j = 0; j < hastalar.Length - 1; j++)
                {
                    if (hasta_yasi[j + 1] < hasta_yasi[j])
                    {
                        hasta_yasi[j + 1] = hasta_yasi[j];
                        hasta_yasi[j] = hasta_yasi2[j + 1];
                        hasta_adi[j + 1] = hasta_adi[j];
                        hasta_adi[j] = hasta_adi2[j + 1];
                    }
                }
            }

            for (int i = 0; i < hasta_sayisi; i++)
            {
                Console.Write("{0}. Hastanın adı: {1} ====> Hastanın yaşı: {2} \n", i + 1, hasta_adi[i], hasta_yasi[i]);
            }
        }
    }
}
