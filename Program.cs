// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void ShowQarter(int x1, int y1, int z1, int x2, int y2, int z2)
{
    Console.Write($"Растояние между двумя точками: {Math.Pow((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) *1.0), 0.5)}" );
}
int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int x1 = GetInput("Введите координату точки A: ");
int y1 = GetInput("Введите координату точки A: ");
int z1 = GetInput("Введите координату точки A: ");
int x2 = GetInput("Введите координату точки B: ");
int y2 = GetInput("Введите координату точки B: ");
int z2 = GetInput("Введите координату точки B: ");
ShowQarter(x1, y1, z1, x2, y2, z2);