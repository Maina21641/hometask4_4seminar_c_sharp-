// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int GetSum (int n){
    int sum = 1;

    for (int i = 1; i <=n; i++){
        sum *= i;
    }
    return sum;
}
System.Console.WriteLine(GetSum(num));