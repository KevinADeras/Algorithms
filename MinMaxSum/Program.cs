
List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

Result.miniMaxSum(arr);

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        ulong sum = 0;
        int? min = null;
        int? max = null;
        
        foreach (int element in arr)
        {
            sum += (ulong)element;
            if(element < min || min == null){
                min = element;
            }
            if(element > max || max == null){
                max = element;
            }
        }
        
        Console.WriteLine((sum - (ulong)max) + " " + (sum - (ulong)min));
    }

}
