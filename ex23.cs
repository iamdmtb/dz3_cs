Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int cube = 0;
for (int i = N; i >= 1; i--){
    cube = Convert.ToInt32(Math.Pow(i, 3));
    Console.WriteLine(cube);
}