namespace f_basic_coding;

public class LeapYears
{
    private int[] _next20LeapYears = new int[20];

    public void RunPrintNext20LeapYears()
    {
        CalculateNext20LeapYears();
        Messages.PrintNext20LeapYears(_next20LeapYears);
    }

    private void CalculateNext20LeapYears()
    {
        var currentYear = DateTime.Today.Year;
        var leapYearCounter = 0;
        for (var i = currentYear; leapYearCounter < 20; i++)
        {
            if (i % 4 == 0)
            {
                _next20LeapYears[leapYearCounter] = i;
                leapYearCounter++;
            }
        }
    }
}