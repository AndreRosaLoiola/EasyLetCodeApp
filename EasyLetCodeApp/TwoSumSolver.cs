namespace TwoSumApp;

public class TwoSumSolver
{
    private readonly int[] _numbers;
    private readonly int _target;

    public TwoSumSolver(int[] numbers, int target)
    {
        _numbers = numbers ?? throw new ArgumentNullException(nameof(numbers));
        _target = target;
    }

    public int[] FindIndices()
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < _numbers.Length; i++)
        {
            int complement = _target - _numbers[i];
            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }

            if (!map.ContainsKey(_numbers[i]))
            {
                map[_numbers[i]] = i;
            }
        }

        throw new InvalidOperationException("Nenhuma combinação encontrada.");
    }
}