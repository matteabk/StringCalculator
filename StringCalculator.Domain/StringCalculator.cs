namespace StringCalculator.Domain
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if(string.IsNullOrEmpty(numbers))
            {
                return 0;
            }
            
            var parts = numbers.Split(',');

            if (parts.Length > 2 || parts.Any(string.IsNullOrWhiteSpace) || parts.Any(x => !int.TryParse(x, out _)))
            {
                throw new ArgumentException();
            }

            int sum = parts.Sum(x => Convert.ToInt32(x));

            return sum;
        }
    }
}