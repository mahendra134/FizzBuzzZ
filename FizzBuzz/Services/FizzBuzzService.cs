namespace FizzBuzz.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
       
        public string[] GetFizzBuzzArray(string[] values)
        {
            List<string> result = new List<string>();

            foreach (var value in values)
            {
                if (int.TryParse(value, out int intValue))
                {

                    if (intValue % 3 == 0 && intValue % 5 == 0)
                        result.Add("FizzBuzz");
                    else if (intValue % 3 == 0)
                        result.Add("Fizz");
                    else if (intValue % 5 == 0)
                        result.Add("Buzz");
                    else if (intValue % 3 != 0 && intValue % 5 !=0)
                        result.Add($"Divided {intValue} by 3");
                        result.Add($"Divided {intValue} by 5");
                    
                    
                }
                else
                {
                    result.Add("Invalid Item");
                }
            }

            return result.ToArray();
        }

    }
}

