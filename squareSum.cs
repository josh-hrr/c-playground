using System; 

public static class Kata
{
  public static int SquareSum(int[] numbers){
        int result = 0;
        for(int i = 0; i<numbers.Length; i++){
            result = result +  Convert.ToInt32((Math.Pow(numbers[i], 2)));
        }
        return result;
    }
}
