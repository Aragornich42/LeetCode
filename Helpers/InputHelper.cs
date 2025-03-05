namespace Helpers
{
    public static class InputHelper
    {
        public static int[] ParseToIntArray(string? input)
        {
            ArgumentNullException.ThrowIfNull(input);

            var inputs = input.Split(',');
            var result = new int[inputs.Length];
            for (int i = 0; i < inputs.Length; i++)
            {
                if (!int.TryParse(inputs[i], out var value))
                    throw new Exception($"Input string {inputs[i]} has non integer symbols");
                result[i] = value;
            }
            return result;
        }
    }
}