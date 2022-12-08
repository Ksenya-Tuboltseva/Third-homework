Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int size = N + 1;
int[] numbers = new int[size];
void PrintArray (int[] numbers, int size)
{
    for (int i=1; i < size; i++)
    {
        numbers[i] = i * i * i;
        Console.Write(numbers [i] + " ");
    }
}

PrintArray (numbers, size);