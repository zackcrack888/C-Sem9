﻿// Миша уже научился хорошо фотографировать и недавно увлекся программированием. Первая программа, 
// которую он написал, позволяет формировать негатив бинарного черно-белого изображения.
// Бинарное черно-белое изображение – это прямоугольник, состоящий из пикселей, каждый из которых 
// может быть либо черным, либо белым. Негатив такого изображения получается путем замены каждого 
// черного пикселя на белый, а каждого белого пикселя – на черный.
// Миша, как начинающий программист, написал свою программу с ошибкой, поэтому в результате ее 
// исполнения мог получаться некорректный негатив. Для того чтобы оценить уровень несоответствия 
// получаемого негатива исходному изображению, Миша начал тестировать свою программу.
// В качестве входных данных он использовал исходные изображения. Сформированные программой негативы
//  он начал тщательно анализировать, каждый раз определяя число пикселей негатива, которые получены
//   с ошибкой.
// Требуется написать программу, которая в качестве входных данных использует исходное бинарное 
// черно-белое изображение и полученный Мишиной программой негатив, и на основе этого определяет 
// количество пикселей, в которых допущена ошибка.

void InputMatrixFirst(int[,] matrixFirst)
{
    for (int i = 0; i < matrixFirst.GetLength(0); i++)
    {
        string? input = Convert.ToString(Console.ReadLine());
        for (int j = 0; j < input.Length; j++)
        {
            matrixFirst[i, j] = input[j];
        }
    }
}
 
 
void InputMatrixSecond(int[,] matrixSecond)
{
    for (int i = 0; i < matrixSecond.GetLength(0); i++)
    {
        string? input = Console.ReadLine();
        for (int j = 0; j < input.Length; j++)
        {
            matrixSecond[i, j] = input[j];
        }
    }
}
 
 
void ReleaseMatrix(int[,] matrixFirst, int[,] matrixSecond)
{
    int count = 0;
    for (int i = 0; i < matrixSecond.GetLength(0); i++)
    {
        for (int j = 0; j < matrixSecond.GetLength(1); j++)
        {
            if (matrixFirst[i, j] == matrixSecond[i, j])
                count++;
        }
    }
    Console.WriteLine($"{count}");
}
 
 
Console.Clear();
Console.Write("Введите кол-во строк и столбцов: ");
string[] num = Console.ReadLine().Split(' '); // ввод двух чисел в одну строку
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int[,] matrixFirst = new int[n, m];
int[,] matrixSecond = new int[n, m];
InputMatrixFirst(matrixFirst);
Console.WriteLine();
InputMatrixSecond(matrixSecond);
	ReleaseMatrix(matrixFirst, matrixSecond);