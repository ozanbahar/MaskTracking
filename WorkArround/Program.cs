using Business.Concrete;
using Entities.Concrete;


//vatandas vatandas1 = new vatandas(); //instence denir.

//vatandas1.ad = "Mustafa";

//Console.WriteLine(vatandas1.ad);

//public class vatandas
//{

//    public string Ad { get; set; }
//    public string Soyad { get; set; }
//    public int DogumYili { get; set; }
//    public int Tcno { get; set; }


//}

//using System.Runtime.CompilerServices;

//static void SelamVer(string isim = "isimsiz")
//{
//    Console.WriteLine("Merhaba" + isim);
//}

//static int Topla(int sayi1,int sayi2)
//{
//    int sonuc=sayi1 + sayi2;
//    Console.WriteLine(sonuc);
//    return sonuc;
//}
//Topla(5, 10);


//string[] sehirler1 = new string[4];
//sehirler1[0] = "1";
//sehirler1[1] = "2";
//sehirler1[2] = "3";
//sehirler1[3] = "4";

//sehirler1 = new [] { "Bursa", "Antalya", "Diyarbakır","Kayseri" };



//List<string> yenisehirler1 = new List<string> { "Bursa", "Antalya", "Diyarbakır" };

//yenisehirler1.Add("Kayseri");

//foreach (string s in yenisehirler1)
//{
//    Console.WriteLine(s);
//}


//MyList<int> myList = new MyList<int>(1,3,4,5,6,7);

//myList.DeleteIndex(1);

//foreach (var item in myList.items)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine("boyut: "+myList.Lenth);

Person person1 = new Person();
person1.Id = 1;
person1.FirstName = "Mustafa";
person1.LastName = "Kemal";
person1.DateOfBirthYear = 1998;
person1.NationalIdentitiy = 123;


PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);