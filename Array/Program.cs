using System;

class Program
{
    static void Main()
    {
        // 1 - 10 adet tam sayı verisi alacak bir dizi tanımlayınız.
        int[] Numbers = new int[10];

        Random random = new Random();


        // 2 - Bu dizinin elemanlarını bir for döngüsü ile doldurup, foreach döngüsü ile tekrar ekrana yazınız.
        for (int i = 0; i < Numbers.Length; i++)
            Numbers[i] = random.Next(1, 101);

        Console.WriteLine("Dizideki rastgele sayılar:");
        foreach (int Number in Numbers)
            Console.WriteLine(Number);


        // 3 - Bu diziye kullanıcıdan alınan yeni bir değeri ekleyiniz (11. eleman olarak)
        Console.Write("Lütfen bir tam sayı giriniz: ");
        var userNumber = int.Parse(Console.ReadLine()!);
        Console.WriteLine();


        // Diziyi genişletip, kullanıcıdan alınan değeri ekliyoruz.
        int[] numbers = new int[11];
        Numbers.CopyTo(numbers, 0);
        numbers[10] = userNumber;


        // 4 - Bu diziyi büyükten küçüğe ekrana yazdırınız.
        Array.Sort(numbers); // Dizi elemanlarını küçükten büyüğe sıralar
        Array.Reverse(numbers); // Sıralamayı tersine çevirir, böylece büyükten küçüğe sıralanır

        Console.WriteLine("Dizinin büyükten küçüğe sıralanmış hali:");
        foreach (int number in numbers)
            Console.WriteLine(number);
    }
}
