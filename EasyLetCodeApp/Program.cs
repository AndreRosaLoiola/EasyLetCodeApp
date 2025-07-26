namespace TwoSumApp;

class Program
{
    static void Main()
    {
        Console.Clear();
        UserInterface.ShowWelcomeMessage();

        try
        {
            int[] numbers = UserInterface.ReadNumbers();
            int target = UserInterface.ReadTarget();

            var solver = new TwoSumSolver(numbers, target);
            int[] result = solver.FindIndices();

            UserInterface.ShowResult(result, numbers, target);
        }
        catch (Exception ex)
        {
            UserInterface.ShowError(ex.Message);
        }

        UserInterface.WaitBeforeExit();
    }
}
