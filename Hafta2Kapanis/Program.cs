//Bu pratikte sizden aşağıdaki soruların cevaplarını tek bir kod sayfası olarak yüklemeniz isteniyor. Çözümleri ayrı ayrı yapıp test edip yorum satırı olarak bir sayfaya kopyalayıp yapıştırabilirsiniz. Bu uygulamanın çözümleri Live-Class'ta yapılacak. Örnekler Hafta 1 ve Hafta 2 'nin konularını bir arada içeriyor.

//++1 - Aşağıdaki çıktıyı yazan bir program.

//Merhaba
//Nasılsın ?
//İyiyim
//Sen nasılsın ?

//Console.WriteLine("Merhaba\nNasılsın\nİyiyim\nSen nasılsın?");


//++2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.

//string nameSurname = "Ceyda Türkdoğan";
//int age = 29;
//Console.WriteLine($"Adınız Soyadınız: {nameSurname} \nYaşınız: {age}");
//3++ - Rastgele bir sayı üretip , ekrana yazdırınız.

//Random rand = new Random();
//int rnd=rand.Next();
//Console.WriteLine(rnd);


//++4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
//Random rand = new Random();
//int rnd = rand.Next();
//rnd = rnd % 3;
//Console.WriteLine(rnd);

//++5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.

//Console.WriteLine("Merhaba lütfen yaşınızı giriniz");
//int age=Convert.ToInt32(Console.ReadLine());

//if(age>18) 
//    Console.WriteLine("+");
//else
//    Console.WriteLine("-");

// ++6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(" Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
//}


//++7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.

//void SwitchtoString(ref string firstString, ref string secondString)
//{
//    string temp = null;
//    temp = firstString;
//    firstString = secondString;
//    secondString = temp;
//    Console.WriteLine($"Yer değiştirdikten sonra ilk metin {firstString} ikinci metin {secondString}");

//}

//string firstString = "Gülse Birsel";
//string secondString = "Demet Evgar";
//SwitchtoString(ref firstString, ref secondString);

//+++8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.

//void BenDegerDondurmem()
//{
//    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
//}

//BenDegerDondurmem();


//++9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.

//int AddTwoNumbers(int firstNumber,int secondNumber)
//{
//    int toplam=firstNumber+secondNumber;
//    return toplam;
//}

//Console.WriteLine("Birinci sayıyı giriniz");
//int firstNumber=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("İkinci sayıyı giriniz");
//int secondNumber=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Toplam : {AddTwoNumbers(firstNumber, secondNumber)}");


////++10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
//string TrueFalse(bool firstBoolean)
//{
//    string outString = null;
//    if ((firstBoolean == true) )
//     outString = "Bool değeri true"; 
//    else
//        outString = "Bool değeri false";
//    return outString;
//}
//Console.WriteLine("True ya da false değer giriniz");
//bool booleanValue=Convert.ToBoolean(Console.ReadLine());
//Console.WriteLine(TrueFalse(booleanValue));

// ++11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.


//Console.WriteLine("İlk kişinin yaşını giriniz:");
//int firstPerson = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("İkinci kişinin yaşını giriniz:");
//int secondPerson = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Üçüncü kişinin yaşını giriniz:");
//int thirdPerson = Convert.ToInt32(Console.ReadLine());
//int FindOldestPerson(int firstPersonAge, int secondPersonAge, int thirdPersonAge)
//{
//    int oldestPersonAge = 0;
//    if((firstPersonAge > secondPersonAge) && (firstPersonAge>thirdPersonAge))
//        oldestPersonAge = firstPersonAge;
//    else if((secondPersonAge > firstPersonAge) && (secondPersonAge > thirdPersonAge))
//            oldestPersonAge = secondPersonAge;
//    else if ((thirdPersonAge > firstPersonAge) && (thirdPersonAge > secondPersonAge))
//            oldestPersonAge = thirdPersonAge;
//    return oldestPersonAge;
//}

//Console.WriteLine($"En büyük yaş {FindOldestPerson(firstPerson, secondPerson, thirdPerson)}");

//??12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.



//+++13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.

//Console.WriteLine("Bir isim giriniz");
//string firstName=Console.ReadLine();

//Console.WriteLine("Bir isim daha giriniz");
//string secondName=Console.ReadLine();

//string ChangeName(ref string firstName,ref string secondName)
//{
//    string temp=firstName;
//    firstName=secondName;
//    secondName=temp;
//    string changeName=firstName + secondName;
//    return changeName;
//}

//Console.WriteLine(ChangeName(ref firstName, ref secondName));

//+++14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.

//Console.WriteLine("Bir sayı giriniz");
//int number=Convert.ToInt32(Console.ReadLine());

//bool OddorEven(int number)
//{
//    bool condition;

//    if (number %2== 0)
//    {
//        condition = true; 
//    }
//    else 
//        condition = false;
//    return condition;
//}
//Console.WriteLine(OddorEven(number));

//+++15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.

//Console.WriteLine("Lütfen hızınızı giriniz(km olarak giriniz)");
//double speed=Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Lütfen gideceğiniz zamanı giriniz(saat olarak giriniz)");
//double time=Convert.ToDouble(Console.ReadLine());

//double RoadCalculation(double speed,double time)
//{
//    double road=speed*time;
//    return road;
//}

//double road=RoadCalculation(speed,time);
//Console.WriteLine($"Gideceğiniz yol {road}");

//+++16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.

//Console.WriteLine("Dairenin yarıçapını giriniz");
//double radius=Convert.ToDouble(Console.ReadLine());

//double AreaofCircle(double r)
//{
//    double circleArea = Math.Pow(r, 2) * Math.PI;
//    return circleArea;
//}

//double circleArea=AreaofCircle(radius);

//Console.WriteLine($"Yarıçapını girdiğiniz dairenin alanı: {circleArea}");

//+++17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.

//string sentence = "Zaman bir GeRi SayIm";
//Console.WriteLine(sentence);

//string lowerSentence = sentence.ToLower();
//Console.WriteLine(lowerSentence);

//string upperSentence = sentence.ToUpper();
//Console.WriteLine(upperSentence);

//Console.WriteLine();

//+++18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.

//string hello = "    Selamlar   ";

//string newHello= hello.Trim();
//Console.WriteLine(newHello);