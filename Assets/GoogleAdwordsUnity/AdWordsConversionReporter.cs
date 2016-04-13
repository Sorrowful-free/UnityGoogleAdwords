namespace Assets.GoogleAdwordsUnity
{
    public static class AdWordsConversionReporter
    {
        public static void RegisterReferrer(string clickUrl)
        {
            GoogleAdwordsWrapperSingleton.AdapterInstance.ConversionReporterRegisterReferrer(clickUrl);
        }

        public static void ReportWithConversionId(string conversionId, string label, string value, bool repeatable)
        {
            GoogleAdwordsWrapperSingleton.AdapterInstance.ConversionReporterReportWithConversionId(conversionId,label,value,repeatable);
        }

        public static void ReportWithConversionId(string conversionId, string label, string value, string currencyCode,
            bool repeatable)
        {
            GoogleAdwordsWrapperSingleton.AdapterInstance.ConversionReporterReportWithConversionId(conversionId, label, value, currencyCode, repeatable);
        }
    }
}
