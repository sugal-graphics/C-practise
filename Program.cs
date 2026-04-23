int[] arr = new int[5] { 1, 2, 4, 5, 6 };

int[] newArr = new int[arr.Length + 1];
for (int i = 0; i < 2; i++)
{
    newArr[i] = arr[i];
}
newArr[2] = 3;
for (int i = 2; i < arr.Length; i++)
{
    newArr[i + 1] = arr[i];
}

foreach (int x in newArr)
{
    Console.WriteLine(x);
}