void FillDoubleArr(double[] arr, int minValue, int maxValue)
{
Random rnd = new Random();
// int deviation = 10;
for (int i = 0; i < arr.Length; i++)
// arr[i] = Math.Round((rnd.NextDouble() - 0.5) * 2 * deviation)
// arr[i] = Math.Round(rnd.NextDouble()+ rnd.Next(minValue, maxValue), 2);
arr[i] = Math.Round(rnd.NextDouble() * (maxValue - minValue) + minValue, 2);
// [0, 1] [0, 5] [2, 7] // 2-7
}


void ReverseArray(double[] arr)
{
for(int i = 0; i < arr.Length / 2; i++)
{
// 1 2 3 4 5 i = 0 k = arr.Length - 1 - i k = 4
// temp = 5 arr[k] = 1 arr[i] = 5 -> 52341
// i = 1 k = 3 arr[1] = 2 arr[3] = 4
// temp = 4 arr[k] = 2 arr[i] = 4 -> 54321
double temp = arr[arr.Length - 1 - i];
arr[arr.Length - 1 - i] = arr[i];
arr[i] = temp;
// (arr[arr.Length - 1 - i], arr[i]) = (arr[i], arr[arr.Length - 1 - i]);
// 5 и 2 -> 5 + 2 = 7 7 - 2 = 5 7 -5 =2
// arr[arr.Length - 1 - i] = arr[arr.Length - 1 - i] + arr[i];
// arr[i] = arr[arr.Length - 1 - i] - arr[i];
// arr[arr.Length - 1 - i] = arr[arr.Length - 1 - i] - arr[i];
}
}
