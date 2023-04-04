static int Binary(int[] mas, int number)
{
    int low = 0;
    int high = mas.Length - 1;
    while (low <= high)
    {
        var mid = (low + high) / 2;
        var guess = mas[mid];
        if (guess == number) return mid;
        if (guess > number) high = mid - 1;
        if (guess < number) low = mid + 1;
    }
    return -1;
}

var res = Binary(new int[] { 0, 2, 6, 11, 11, 19, 24, 29, 80, 88, 104, 110}, 104);
int c = 0;
