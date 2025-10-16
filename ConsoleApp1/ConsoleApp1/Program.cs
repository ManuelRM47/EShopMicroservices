// See https://aka.ms/new-console-template for more information
static int SumPositiveIntegers(string? csv)
{   
    return csv?.Split(',').Where(x => int.TryParse(x.Trim(), out int n) && n > 0).Sum(x => int.Parse(x.Trim())) ?? 0;
}

//static int SumPositiveIntegers(string? csv)
//{
//    string str = csv;
//    string temp;
//    List<string> numbers = [];
//    int sum = 0, realNumber;


//    if (str is null || str.Length == 0)
//    {
//        return 0;
//    }

//    // Split the string by commas and convert to a list
//    numbers = str.Split(',').ToList();

//    foreach (var number in numbers)
//    {
//        temp = number.Trim().ToLower();
//        if (int.TryParse(temp, out realNumber))
//        {
//            if (realNumber > 0)
//            {
//                sum += realNumber;
//            }
//        }
//    }

//    return sum;
//}

Console.WriteLine(SumPositiveIntegers("-9,3,6, 4   ,-99999999, 999999999999999999999999, 2, -3333333333333333333333333333333333, a,s,f,0,5")); // Output: 15