// Написать программу, которая из имебщегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа.

string[] MyArray = new string[] {"hello", "2", "world", ":-)"};

string[] SelectThreeSymbolElements(string[] array, int m)
{
    string[] newArray = new string[array.Length];

    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= m) 
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}
