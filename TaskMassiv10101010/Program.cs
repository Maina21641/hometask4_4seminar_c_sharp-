//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

void FillArray(int[] collection) // в качестве аргумента какая-то коллекция
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next (0, 2); // обращаемся к аргументу collection на позицию Index и положить туда новое случайное целое число из диапазона 0-1
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
 }

int[] array = new int[8]; //создай новый массив в котором будет 8 элементов

FillArray(array); // метод заполнения массива числами
PrintArray(array); // метод печати массива на экран/консоль