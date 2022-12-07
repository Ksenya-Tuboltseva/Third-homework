Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int FirstDigit = number / 10000;
int SecondDigit = number / 1000 % 10;
int ThirdDigit = number / 100 % 10;
int FourthDigit = number / 10 % 10;
int FifthDigit = number % 10;
if (FirstDigit == FifthDigit && SecondDigit == FourthDigit)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
};