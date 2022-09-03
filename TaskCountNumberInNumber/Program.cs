// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
//1 вариант
// int GetSim (int num){
//     int i = 0;
//     while (num >0)
//     {
//         i++;
//         num/=10;
//     }
//     Console.WriteLine ("Количество цифр введенного числа: {0}", i);
//     Console.ReadKey();
//     return 0;
// }
// GetSim(456789);
//2 вариант
// int n = 123456789;
// int digitcount = (int)Math.Log10(n) + 1;
// Console.WriteLine(digitcount);

//3 вариант
int CountDigits2(int number){
return number.ToString().Length;
}
Console.WriteLine(CountDigits2(123456789));