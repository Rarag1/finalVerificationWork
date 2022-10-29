string[] array1 = { "hello", "2", "world", ":-)", "Ха", "ХаХа" };
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };

IfStringOfArray(array1);
IfStringOfArray(array2);
IfStringOfArray(array3);

string[] IfStringOfArray(string[] _array)
{
    string[] tempArray = new string[_array.Length];
    int j = 0;
    for (int i = 0; i < _array.Length; i++)
    {
        if (_array[i].Length <= 3)
        {
            tempArray[j] = _array[i];
            j++;
        }
    }
    string[] resultArray = new string[j];

    for (int i = 0; i < j; i++)
        resultArray[i] = tempArray[i];

    Console.Write($"[");
    foreach (var n in _array)
        Console.Write($"'{n}' ");
    Console.Write($"]  --->  [");

    foreach (var n in tempArray)
        Console.Write($"'{n}' ");
    Console.Write($"]  --->  [");

    foreach (var n in resultArray)
        Console.Write($"'{n}' ");
    Console.WriteLine($"]\n ");

    return resultArray;
}