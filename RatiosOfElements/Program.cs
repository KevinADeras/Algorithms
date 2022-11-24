
 int n = Convert.ToInt32(Console.ReadLine().Trim());

List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

Result.plusMinus(arr);


class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        float countPositive = 0;
        float countNegative = 0;
        float countZero = 0;
        float size = arr.Count;
        
        foreach (int element in arr){
            if (element>0){
                countPositive++;
            }
            else if(element < 0){
                countNegative++;
            }
            else{
                countZero++;
            }
        }
        
        
        Console.WriteLine((countPositive/size).ToString("F6"));
        Console.WriteLine((countNegative/size).ToString("F6"));
        Console.WriteLine((countZero/size).ToString("F6"));
        
  
    }

}

/*class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}*/