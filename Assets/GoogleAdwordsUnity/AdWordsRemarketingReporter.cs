namespace Assets.GoogleAdwordsUnity
{
    public static class AdWordsRemarketingReporter
    {
        public static void ReportWithConversionId(string conversionId)
        {
            GoogleAdwordsWrapperSingleton.AdapterInstance.RemarketingReporterReportWithConversionId(conversionId);
        }

        public static void ReportWithConversionId(string conversionId,string jsonParams)
        {
            GoogleAdwordsWrapperSingleton.AdapterInstance.RemarketingReporterReportWithConversionId(conversionId,jsonParams);
        }

    }
}
