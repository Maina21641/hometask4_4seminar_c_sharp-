// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.
// 7-=28
// 4-=10
// 8-=36

// 1 вариант
// int num = Convert.ToInt32(Console.ReadLine());

// int GetSum (int n){
//     int sum = 0;

//     int i = 1;
//     while (i <=n){
//         sum += i;
//         i++;
//     }
//     return sum;
// }
// System.Console.WriteLine(GetSum(num));

//2 вариант
System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int GetSum (int n){
    int sum = 0;

    for (int i = 1; i <=n; i++){
        sum += i;
    }
    return sum;
}
System.Console.WriteLine(GetSum(num));