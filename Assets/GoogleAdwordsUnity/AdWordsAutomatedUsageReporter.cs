namespace Assets.GoogleAdwordsUnity
{
    public static class AdWordsAutomatedUsageReporter
    {
        public static void DisableAutomatedUsageReporting(string conversionId)
        {
            GoogleAdwordsWrapperSingleton.AdapterInstance.AutomatedUsageReporterDisableAutomatedUsageReporting(conversionId);
        }

        public static void EnableAutomatedUsageReporting(string conversionId)
        {
            GoogleAdwordsWrapperSingleton.AdapterInstance.AutomatedUsageReporterEnableAutomatedUsageReporting(conversionId);
        }
    }
}
