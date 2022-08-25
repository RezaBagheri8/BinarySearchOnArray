using BinarySearchInArray;
int key;
do
{
    key = int.Parse(Console.ReadLine());
    int[] array = { 0, 1, 2, 3, 4, 12, 45, 127, 544 };

    //BinarySearch binarySearch = new BinarySearch(array);
    //var result = binarySearch.Search(key);

    //Console.WriteLine(result);

    RecursiveBinarySearch binarySearch = new RecursiveBinarySearch(array);
    binarySearch.Search(key, 0, array.Length - 1);
}
while (key != -50);


