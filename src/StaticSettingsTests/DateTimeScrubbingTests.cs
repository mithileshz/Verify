public class DateTimeScrubbingTests :
    BaseTest
{
    public DateTimeScrubbingTests() =>
        VerifierSettings.ScrubInlineDateTimes("F");

    [Fact]
    public Task Test()
    {
        var dateTime = DateTime.Now;
        return Verify($"a {dateTime:F} b");
    }

    [Fact]
    public Task Test_Long()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US");

        var settings = new VerifySettings();
        settings.ScrubInlineDateTimes("G");

        return Verify("12/11/2024 10:36:43 AM", settings);
    }
}