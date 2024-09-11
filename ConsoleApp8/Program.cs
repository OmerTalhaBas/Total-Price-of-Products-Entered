using System;

class Program
{
    static void Main()
    {
        int urunSayi;
        string sayi;
        do
        {
            Console.Write("Lütfen Kaç Adet Ürün Gireceğinizi Yazınız : ");
            sayi = Console.ReadLine();
        } while (!int.TryParse(sayi, out urunSayi) || urunSayi <= 0);
        int toplam = 0;
        int urunSira = 1;
        do
        {
            Console.Write($"{urunSira}'ıncı Ürünün Fiyatını Tam Sayı Cinsinden Giriniz : ");
            sayi = Console.ReadLine();

            if (int.TryParse(sayi, out int fiyat) && fiyat >= 0)
            {
                toplam += fiyat;
                urunSira++;
            }
            else
            {
                Console.WriteLine("Hata! Lütfen Geçerli Bir Fiyat Giriniz.");
            }
        } while (urunSira <= urunSayi);

        Console.WriteLine($"Ürünlerin Toplam Fiyatı : {toplam}");
    }
}