
static int BinarySearch(int[] array, int searchedValue, int left, int right)
{
    while (left <= right)
    {
        var middle = (left + right) / 2;

        if (searchedValue == array[middle])
        {
            return middle;
        }
        else if (searchedValue < array[middle])
        {
            right = middle - 1;
        }
        else
        {
            left = middle + 1;
        }
    }
    return -1;
}
var array = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
var n = int.Parse(Console.ReadLine());
Console.WriteLine($"index = {BinarySearch(array, n, 0, array.Length-1)}");