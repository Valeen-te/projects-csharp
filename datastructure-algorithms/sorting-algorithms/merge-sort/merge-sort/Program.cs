int[] array = { 4, 6, 9, 1, 7, 5, 3, 0, 2, 8 };

MergeSort(array, 0, array.Length);

static void MergeSort(int[] arr, int min, int max)
{
    int cut = max / 2;

    if (cut < min)
    {
        MergeSort(arr, min, cut);
    }
}