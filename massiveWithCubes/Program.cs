Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N+1];
for (int i=1; i < N+1; i++)
{
    array[i] = i * i * i;
    Console.WriteLine(array[i]);
}