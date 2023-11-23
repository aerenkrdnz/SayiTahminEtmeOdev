int rastgele;
int sayac = 3;
Random rnd = new Random();
rastgele = rnd.Next(1, 10);
Console.WriteLine("Bu oyunda sadece 3 can hakkınız var.");
Console.WriteLine("Tahmin edeceğiniz sayı 1 ve 10 arasında olmalı. (1 sayısı dahildir.)");

int tahmin = Convert.ToInt32(Console.ReadLine());

if ( sayac != 1)
{
    if (tahmin == rastgele)
    {
        
        Console.WriteLine("Tebriklerr!");
    }
    else if (tahmin != rastgele)
    {
        sayac--;
        Console.WriteLine("Doğru bilemediniz. "+ sayac +" hakkınız kaldı. Bol şanslar.");
    }
}
int tahmin1 = Convert.ToInt32(Console.ReadLine());
if (sayac != 1)
{
    if (tahmin1 == rastgele)
    {

        Console.WriteLine("Tebriklerr!");
    }
    else if (tahmin1 != rastgele)
    {
        sayac--;
        Console.WriteLine("Doğru bilemediniz. " + sayac + " hakkınız kaldı. Bol şanslar.");
    } 
}
int tahmin2 = Convert.ToInt32(Console.ReadLine());
if (sayac != 1)
{
    if (tahmin2 == rastgele)
    {

        Console.WriteLine("Tebriklerr!");
    }
    else if (tahmin2 != rastgele)
    {
        sayac--;
        Console.WriteLine("Doğru bilemediniz. " + sayac + " hakkınız kaldı. Bol şanslar.");
    }
    else
    {
       
        Console.WriteLine("Oyunu kaybettiniz:(");

    }
}
