// See https://aka.ms/new-console-template for more information

using System;

int[] marksArray = new int[10];
marksArray[0] = 7;
marksArray[1] = 8;
marksArray[2] = 10;
marksArray[3] = 9;
marksArray[4] = 2;
marksArray[5] = 5;
marksArray[6] = 8;
marksArray[7] = 10;
marksArray[8] = 8;
marksArray[9] = 9;

int summ = 0;

for (int i = 0; i < 10; i++)
{
    summ = summ + marksArray[i];

}
double avg = (double)summ / marksArray.Length;
Console.WriteLine("Cреднее арифметическое:");
Console.WriteLine(avg);

int minNumber = marksArray[0];
int maxNumber = marksArray[0];

for (int i = 0; i < marksArray.Length; i++)
{
    if (marksArray[i] < minNumber)
    {
        minNumber = marksArray[i];
    }

    if (marksArray[i] > maxNumber)
    {
        maxNumber = marksArray[i];
    }
}
Console.WriteLine("Минимальное значение:");
Console.WriteLine(minNumber);
Console.WriteLine("Максимальное значение:");
Console.WriteLine(maxNumber);