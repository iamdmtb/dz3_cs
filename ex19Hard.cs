Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int[] digits = new int[1 + (int)Math.Log10(num)];
for (int i = digits.Length - 1; i >= 0; i--)
{
    int digit;
    num = Math.DivRem(num, 10, out digit);
    digits[i] = digit;
}
if (digits.Reverse().SequenceEqual(digits)){
    Console.WriteLine($"Введенное число палиндром");
}
else {
    Console.WriteLine($"Введенное число не является палиндромом");
}