namespace f_basic_coding;

public class LeapYears
{
    public void RunPrintNext20LeapYears()
    {
        var next20LeapYears = CalculateNext20LeapYears(DateTime.Today.Year);
        Messages.PrintNext20LeapYears(next20LeapYears);
    }

    private int[] CalculateNext20LeapYears(int currentYear)
    {
        var next20LeapYears = new int[20];
        var leapYearCounter = 0;
        for (var i = currentYear; leapYearCounter < 20; i++)
        {
            if (i % 4 == 0)
            {
                next20LeapYears[leapYearCounter] = i;
                leapYearCounter++;
            }
        }

        return next20LeapYears;
    }
}