using System;

static float GetAverageScore(int[] marks)
{
    float average = 0;

    for (int i = 0; i < marks.Length; i++)
    { average += marks[i];
    }

    average /= marks.Length;

    return average;
}

static int GetMinMark(int[] marks)
{
    int minNumber = marks[0];
    for (int i = 0; i < marks.Length; i++)
    {
        if (marks[i] < minNumber)
        {
            minNumber = marks[i];
        }

    }
    return minNumber;
}

static int GetMaxMark(int[] marks)
{
    int maxNumber = marks[0];
    for (int i = 0; i < marks.Length; i++)
    {
        if (marks[i] > maxNumber)
        {
            maxNumber = marks[i];
        }
    }
    return maxNumber;
}

int[] AlexMarks = { 6, 7, 6, 9, 10, 9, 2, 10, 9, 8 };

float alexaverage = GetAverageScore(AlexMarks);
int alexminmark = GetMinMark(AlexMarks);
int alexmaxmark = GetMaxMark(AlexMarks);
Console.WriteLine("Среднее арифметическое Alex");
Console.WriteLine(alexaverage);
Console.WriteLine("Минимальная отметка Alex");
Console.WriteLine(alexminmark);
Console.WriteLine("Максимальная отметка Alex");
Console.WriteLine(alexmaxmark);

int[] IvanMarks = {7, 9, 10, 9, 10, 10, 9, 8, 8, 8 };

float ivanaverage = GetAverageScore(IvanMarks);
int ivanminmark = GetMinMark(IvanMarks);
int ivanmaxmark = GetMaxMark(IvanMarks);
Console.WriteLine("Среднее арифметическое Ivan");
Console.WriteLine(ivanaverage);
Console.WriteLine("Минимальная отметка Ivan");
Console.WriteLine(ivanminmark);
Console.WriteLine("Максимальная отметка Ivan");
Console.WriteLine(ivanmaxmark);

int[] MariMarks = {9, 6, 8, 7, 8, 9, 10, 10, 6, 8 };

float mariaverage = GetAverageScore(MariMarks);
int mariminmark = GetMinMark(MariMarks);
int marimaxmark = GetMaxMark(MariMarks);
Console.WriteLine("Среднее арифметическое Mari");
Console.WriteLine(mariaverage);
Console.WriteLine("Минимальная отметка Mari");
Console.WriteLine(mariminmark);
Console.WriteLine("Максимальная отметка Mari");
Console.WriteLine(marimaxmark);

int[] NikMarks = {8, 7, 8, 7, 9, 10, 10, 3, 9, 10 };

float nikaverage = GetAverageScore(NikMarks);
int nikminmark = GetMinMark(NikMarks);
int nikmaxmark = GetMaxMark(NikMarks);
Console.WriteLine("Среднее арифметическое Nik");
Console.WriteLine(nikaverage);
Console.WriteLine("Минимальная отметка Nik");
Console.WriteLine(nikminmark);
Console.WriteLine("Максимальная отметка Nik");
Console.WriteLine(nikmaxmark);

int[] EgorMarks = {10, 9, 8, 7, 6, 8, 9, 10, 10, 10 };

float egoraverage = GetAverageScore(EgorMarks);
int egorminmark = GetMinMark(EgorMarks);
int egormaxmark = GetMaxMark(EgorMarks);
Console.WriteLine("Среднее арифметическое Egor");
Console.WriteLine(egoraverage);
Console.WriteLine("Минимальная отметка Egor");
Console.WriteLine(egorminmark);
Console.WriteLine("Максимальная отметка Egor");
Console.WriteLine(egormaxmark);

