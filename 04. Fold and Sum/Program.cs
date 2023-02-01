using System.Diagnostics.Metrics;

int[] mainArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] leftHalfMain = new int[mainArr.Length / 2];
int[] rightHalfMain = new int[mainArr.Length / 2];
int[] resultLeft = new int [leftHalfMain.Length / 2];
int[] resultRight = new int [rightHalfMain.Length / 2];
int middleMain = mainArr.Length / 2;

for (int i = 0; i < middleMain; i++)
{
    leftHalfMain[i] = mainArr[i];
    rightHalfMain[i] = mainArr[i + middleMain];
}

int lastIndex = leftHalfMain.Length - 1;

for (int i = 0; i < leftHalfMain.Length / 2; i++)
{
    resultLeft[i] = leftHalfMain[i] + leftHalfMain[lastIndex];
    resultRight[i] = rightHalfMain[i] + rightHalfMain[lastIndex];
    lastIndex--;
}

Array.Reverse(resultLeft);

Console.Write(string.Join(" ", resultLeft));
Console.Write(" ");
Console.Write(string.Join(" ", resultRight));

