
int fibunacciNum = int.Parse(Console.ReadLine());
long[] result = new long[50];
result[0] = 1;
result[1] = 1;

for (int i = 2; i < fibunacciNum; i++)
{
    result[i] = result[i - 1] + result[i - 2];
}
Console.WriteLine(result[fibunacciNum - 1]);


//int n = int.Parse(Console.ReadLine());
//int[] arr = new int[50];
//arr[0] = 1;
//arr[1] = 1;

//for (int i = 0; i < n - 2; i++)
//{
//    arr[i + 2] = arr[i] + arr[i + 1];
//}

//Console.WriteLine(arr[n - 1]);
