namespace Helpers
{
    public static class InputHelper
    {
        public static int[] ParseToIntArray(string? input)
        {
            if(input is null)
                throw new ArgumentNullException(nameof(input));

            var inputs = input.Split(',');
            var result = new int[inputs.Length];
            int value;
            for (int i = 0; i < inputs.Length; i++)
            {
                if (!int.TryParse(inputs[i], out value))
                    throw new Exception($"Input string {inputs[i]} has non integer symbols");
                result[i] = value;
            }
            return result;
        }
    }
}