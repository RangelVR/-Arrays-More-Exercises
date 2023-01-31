int n = int.Parse(Console.ReadLine());

int[] result = new int[n];

for (int k = 0; k < n; k++)
{
    string input = Console.ReadLine();
    int sum = 0;

    for (int i = 0; i < input.Length; i++)
    {
        char ch = (char)input[i];

        if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U' ||
            ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
        {
            sum += input[i] * input.Length;
        }
        else
        {
            sum += input[i] / input.Length;
        }
    }
    result[k] = sum;
}

foreach (var item in result.OrderBy(x => x))
{
    Console.WriteLine(item);
}



//int n  = int.Parse(Console.ReadLine());

//int[] result = new int[n];

//for (int i = 0; i < n; i++)
//{
//    int sum = 0;
//    string input = Console.ReadLine();

//    foreach (var item in input)
//    {
//        switch (item)
//        {
//            case 'a':
//            case 'e':
//            case 'i':
//            case 'o':
//            case 'u':
//            case 'A':
//            case 'E':
//            case 'I':
//            case 'O':
//            case 'U':
//                sum += item * input.Length;
//                break;

//            default:
//                sum += item / input.Length;
//                break;
//        }
//    }
//    result[i] = sum;
//}

//foreach (var item in result.OrderBy(x => x))
//{
//    Console.WriteLine(item);
//}
