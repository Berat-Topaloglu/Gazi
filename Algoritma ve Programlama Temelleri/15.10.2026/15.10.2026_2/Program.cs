namespace _15._10._2026_2
{
    internal class Program
    {
        static int sayi = 100;//Program çalıştığı sürece bellekte kalır.
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //byte a;//Deşiken tanımlama
            //a = 30;//Değer atama
            //Console.WriteLine(a);

            //byte b = 50;
            //a = 60;
            //Console.WriteLine(a);

            //byte c = 30, d = 40;//Aynı trden 1'den fazla değişken tanımlama
            //Console.WriteLine(c + " " + d);//2 veriyi aynı anda tek bir method da yazdırabiliriz.

            //const byte sabit = 10;//Const kullanıldığı zaman tek bir saırda işlem halledilir,
            //                      //sonradan bu satuırı kağttığımız zaman ne değişken ne de değeri değiştirilebilir.
            //                      //sabit = 50; Bunu yapamayız çünkü başta dediğimiz gibi olduğu için kod hata verir.
            //                      //byte yas;
            //                      //Console.WriteLine(yas); Bu yapıldığı zmana değer atanılmadığı için bir şlemde kullanıılmasına müsade edilemez.

            //var value = 50;
            //var value1 = 2.5f;
            //var value2 = 2.5;
            //var value3 = 2.5m;
            //var value4 = true;
            //var value5 = 'A';
            //var value6 = "Ahmet";
            //Implicit tip belirleme: var ile yapılan ve veri tipinin açıkça belirtilmediği ya da yazılmadığı durumdur.
            //Explicit tip belirleme: Veri tipinin açıkca belirtildiği durumdur.
            //Örn: byte sayi;

            //string isim = "Ahmet";
            //string soyisim = "Hacıniyazioğlu";
            //Console.WriteLine(isim + soyisim);
            //Console.WriteLine("Hoş Geldin " + " " + isim + " " + soyisim);
            //Console.WriteLine("Hoş Geldin {0} {1}",isim,soyisim);
            //Console.WriteLine($"Hoş Geldin {isim} {soyisim} ");

            Console.Write("Lütfen e-mail girin:");
            string isim = Console.ReadLine();
            Console.Write("Lütfen şifrenizi girin:");
            string soyisim = Console.ReadLine();
            if (isim == "Berat" || isim == "berat" && soyisim == "12345")
            {
                Console.WriteLine("Giriş Başarılı...");
            }
            else
            {
                Console.WriteLine("Hatalı şifre veya mail, lütfen tekrar deneyin!!");
            }
        }
    }
}
//Değişkenler: Farklı tür ve boyyutlarda ki verileri bellekte geçici saklamak için kullanılan yapılardır.
//Bir parantez içersinde birden fazla aynı isimli depğişken tanılanamaz!! 
//Bir değişkene atanan en son değer geçerlidir.
//Void methodlar: işini yaptıktan sonra geri dönüş yapmayan yani bize bilgi vermeyen methodlardır.
