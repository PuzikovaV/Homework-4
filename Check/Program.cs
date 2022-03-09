using Check;

int[] a = {15, 99, -205, 63, 0, -503};
int aMin = HomeworkArray.FindMinOfArray(a);
int aMax = HomeworkArray.FindMaxOfArray(a);
Console.WriteLine($"Минимальный элемент массива - {aMin}, максимальный элемент массива - {aMax}");

int aIndexOfMinElement = HomeworkArray.FindIndexOfMinElement(a);
int aIndexOfMaxElement = HomeworkArray.FindIndexOfMaxElement(a);
Console.WriteLine($"Индекс минимального элемента - {aIndexOfMinElement}, индекс максимального элемента - {aIndexOfMaxElement}");

int[] b = {1, 2, 3, 4, 5, 6, 7, 9};
int bCount = HomeworkArray.CountElementsWithOddIndex(b); ;
Console.WriteLine($"Сумма элементов с нечетными индексами = {bCount}");

int bCountOddElements = HomeworkArray.CountOddElements(b);
Console.WriteLine($"Количество нечетных элементов в массиве - {bCountOddElements}");

int[] aBubbleSortMax=HomeworkArray.MakeBubbleSortMax(a);
for (int i=0; i<aBubbleSortMax.Length; i++)
{
    Console.Write($"{aBubbleSortMax[i]} ");
}

Console.WriteLine();

int[] aSelectorSortMin = HomeworkArray.MakeSelectorSorttMin(a);
for (int i = 0; i < aSelectorSortMin.Length; i++)
{
    Console.Write($"{aSelectorSortMin[i]} ");
}

Console.WriteLine();

/*int[] bReversOfArray = HomeworkArray.MakeReversOfArray(b);
for (int i=0; i<bReversOfArray.Length; i++)
{
    Console.Write($"{bReversOfArray[i]} ");
}*/

int[,] c = {{ 1, 15, -100 }, {99, 32, -14}};
int cFindMin2DArray = TwoDimesionalArray.FindMin(c);
Console.Write($"Минимальный элемент массива = {cFindMin2DArray}");

Console.WriteLine();

int cFindMax2DArray=TwoDimesionalArray.FindMax(c);
Console.Write($"Максимальный элемент массива = {cFindMax2DArray}");

Console.WriteLine();

