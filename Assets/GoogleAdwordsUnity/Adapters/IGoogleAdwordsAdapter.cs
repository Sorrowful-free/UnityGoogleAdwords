namespace Assets.GoogleAdwordsUnity.Adapters
{
    public interface IGoogleAdwordsAdapter
    {
        void ConversionReporterRegisterReferrer(string clickUrl);
        void ConversionReporterReportWithConversionId(string conversionId, string label, string value, bool repeatable);
        void ConversionReporterReportWithConversionId(string conversionId, string label, string value, string currencyCode, bool repeatable);

        void AutomatedUsageReporterDisableAutomatedUsageReporting(string conversionId);
        void AutomatedUsageReporterEnableAutomatedUsageReporting(string conversionId);

        void RemarketingReporterReportWithConversionId(string conversionId);
        void RemarketingReporterReportWithConversionId(string conversionId, string jsonParams);

    }
}
