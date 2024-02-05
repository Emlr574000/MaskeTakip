

//DRY Uyumsuz
using Business.Concrete;
using Entities.Concrete;

Console.WriteLine("Merhaba");
Console.WriteLine("Merhaba");
Console.WriteLine("Merhaba");
Console.WriteLine("Merhaba");
Console.WriteLine("Merhaba");
Console.WriteLine("Merhaba");
static void Degiskenler()
{
    //DRY prensibi çiğnenmeden kullanım
    double tutar = 100000;//Bu değer db den gelmektedir.
    int sayi = 100;
    bool girisYapmisMi = false;
    Vatandas vatandas = new Vatandas();

    
    Console.WriteLine(tutar * 1.18);
    Console.WriteLine(tutar * 1.18);

   

    Console.ReadLine();
}


static void SelamVer(string isim="isimsiz") {
    Console.WriteLine($"Hoşgeldin {isim}");
}

static int Topla(int sayi1=5,int sayi2=10) {
    int sonuc=sayi1 + sayi2;
    Console.WriteLine($"Toplam : {sonuc}");
    return sonuc;
   
}



//Degiskenler();
Vatandas vatandas = new Vatandas();

SelamVer("Şule");
SelamVer("Ahmet");
SelamVer();
int toplam = Topla(50);

//Diziler-Referans Tipler
string ogrenci1 = "Engin";
string ogrenci2 = "Kerem";
string ogrenci3 = "Berkay";
string[] ogrenciler = new string[3];
ogrenciler[0] = "Engin";
ogrenciler[1] = "Kerem";
ogrenciler[2] = "Berkay";
ogrenciler = new string[4];//ogrenciler Array'i yeni referans numarası tutuyor o yüzden 3 numaralı array ve içerisindekiler çöp oldu. 
ogrenciler[3] = "İlker";
string[] sehirler1 = { "İstanbul", "Ankara", "Konya" };
string[] sehirler2 = { "Bursa", "Kastamonu", "Diyarbakır" };
sehirler1 = sehirler2;
sehirler1[1] = "Antalya";  
//Generic collections varken günlük hayatta klasik arraylari "[]" kullanmıyoruz.
List<string> yenisehirler = new List<string> (){ "İstanbul 1", "Ankara 1", "Konya 1" };
yenisehirler.Add("Adana 1");


//List Mantığı şu şekilde; 1 tane araba listesi olsun;
string[] arabalar1 =new string[3];
arabalar1[0] = "Porsche";
arabalar1[1] = "Nissan";
arabalar1[2] = "Ferrari";
//list<string> arabalar1=new List<string>(){"Porsche,"Nissan","Ferrari""} =>  Şuan yukarıdaki buna karşılık geliyor.
//arabalar1[4] = "Toyota";    =>   Bu listenin dışına çıktın hatası verecektir.
arabalar1 = new string[4];
arabalar1[0] = "Porsche";
arabalar1[1] = "Nissan";
arabalar1[2] = "Ferrari";
arabalar1[3] = "Toyota";
//arabalar1.add("Toyota") => Yukarıdaki kod Generic yapıda arabalar1.add("Toyota") kodunun arraydaki halidir.




for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

//Foreach mantığı;
//for (int i = 0; i < sehirler1.Length;i++)
//{
//    string sehir = sehirler1[i];//sehir takma ismiyle sehirler içindeki i. değeri döndü.
//    Console.WriteLine(sehir);
//}




Person person1 = new Person();
person1.FirstName = "EMİRHAN";
person1.LastName = "ŞENTÜRK";
person1.DateOfBirthYear = 2003;
person1.NationalIdentity = 123;
Person person2 = new Person();
person2.FirstName = "Murat";

foreach (string sehir in yenisehirler)
{
    Console.WriteLine(sehir);
}

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);




Console.ReadLine();
public class Vatandas
{//Ek bilgi : değişkenler adları değişken public ise Pascal Case yazılır.
    //Property yani getter setter kullanarak özellik tanımlamak için prop kısayolunu kullan.
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set;}
    public long TcNo { get;set;}
    
}
