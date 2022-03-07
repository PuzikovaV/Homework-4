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