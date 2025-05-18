/*1 - Aşağıdaki çıktıyı yazan bir program.
Merhaba
Nasılsın ?
İyiyim
Sen nasılsın ? */

static void Welcome()
{
    Console.WriteLine("Merhaba\nNasılsın?\nİyiyim\nSen nasılsın?");
}

Welcome();

//2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için
//2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.


string text;
int number;

text = "Merhaba";
number = 23;

Console.WriteLine(text + " " + number);

//3 - Rastgele bir sayı üretip , ekrana yazdırınız.

Random rnd = new Random();//Random metodunu kullanıyorum.
int number2 = rnd.Next(1,1001); // 1 ile 1000 arasında rastgele bir sayı ürettirip number 2 değişkeninde tutuyorum.
Console.WriteLine(number2);//rastgele sayıyı yazdırıyorum.

//4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.

Random random = new Random(); //Random metodunu kullanıyorum.
int number3 = random.Next();//rastgele sayı üretip sayıyı nummber 3 değişkeninde tutuyorum.
int bolumundenKalan = number % 3;
Console.WriteLine(bolumundenKalan);

//5 Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.

Console.Write("Lütfen yaşınızı giriniz.");
int age = Convert.ToInt32(Console.ReadLine());//kullanıcının girdiği string değeri int'e dönüştürüp age değişkeninde tutuyorum.
if (age >= 18)
{
    Console.WriteLine("+");
}
else
    Console.WriteLine("-");

//6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}

//7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.

Console.Write("Lütfen bir sanatçı ismi giriniz.");
string text1 = Console.ReadLine();
Console.Write("Lütfen başka bir sanatçı ismi giriniz.");
string text2 = Console.ReadLine();
string newText = text2 + " " + text1;
Console.WriteLine(newText);

//8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız.
//Ekrana "Ben değer döndürmem , benim bir karşılığım yok , bana değişkene atamaya çalışma" yazsın.

static void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , bana değişkene atamaya çalışma.");
}

BenDegerDondurmem();

//9-İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.

int SumNumbers(int a, int b)
{
    return a + b;
}
int toplam = SumNumbers(4, 45);
Console.WriteLine(toplam);


//10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.

static string Control(bool devamMi)
{
    if (devamMi)
    {
        return "işlem başlatılıyor.";
    }
    else
        return "geçersiz giriş";
}

Console.WriteLine(Control(true));

// 11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.

static int EnYasli(int a, int b, int c)
{
    int max = Math.Max(a, b);
    int max2 = Math.Max(max, c);
    return max2;
}
Console.WriteLine(EnYasli(20,87,71));

//12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.

static int EnBuyukSayi()
{
    Console.WriteLine("Sayıları tek tek girin. Bitirmek için 'q' yazın.");

    bool ilkSayiMi = true;
    int enBuyuk = 0;

    while (true)
    {
        Console.Write("Bir sayı giriniz: ");
        string giris = Console.ReadLine();

        if (giris.ToLower() == "q")
        {
            break;
        }
            
        int sayi;
        bool sayiMi = int.TryParse(giris, out sayi);

        if (sayiMi)
        {
            if(ilkSayiMi)
            {
                enBuyuk = sayi;
                ilkSayiMi = false;
            }
            else if (sayi > enBuyuk)
            {
                enBuyuk = sayi;
            }

        }
        else
            Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
    }
    Console.WriteLine("En büyük sayı: " + enBuyuk);
    return enBuyuk;
}

//13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.

static void changeNames()
{
    Console.Write("Bir isim giriniz: ");
    string name1 = Console.ReadLine();
    Console.Write("Başka bir isim giriniz: ");
    string name2 = Console.ReadLine();
    string name3 = name2 + " " + name1;
    Console.WriteLine(name3);
}
changeNames();



//14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.

static bool TekMi()
{
    Console.Write("Lütfen bir sayı giriniz: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number % 2 != 0; 
}
TekMi();


// 15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.

static void GidilenYol()
{
    Console.WriteLine("hızı girin.");
    int speed = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("süreyi girin.");
    int time = Convert.ToInt32(Console.ReadLine());
    int journeyDistance = time * speed;
    Console.WriteLine(journeyDistance);
}


//16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.

static void CircleArea(int radius)
{
    double powerRadius = Math.Pow(radius, 2);
    double circleArea = Math.PI * powerRadius;
    Console.WriteLine(circleArea);
}

CircleArea(5);

//17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.

string text4 = "Zaman bir GeRi SayIm.";
Console.WriteLine(text4.ToUpper());
Console.WriteLine(text4.ToLower());

// 18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.

string textWelcome = "   Selamlar   ";
string trimmedText = textWelcome.Trim();
textWelcome = trimmedText;
Console.WriteLine(textWelcome);