#if UNITY_IOS || UNITY_IPHONE

using System.Runtime.InteropServices;

namespace Assets.GoogleAdwordsUnity.Adapters
{
    public class GoogleAdwordsIOSAdapter:IGoogleAdwordsAdapter
    {
        public void ConversionReporterRegisterReferrer(string clickUrl)
        {
            GoogleAdwordsIOSWrapper.ConversionReporterRegisterReferrer(clickUrl);
        }

        public void ConversionReporterReportWithConversionId(string conversionId, string label, string value, bool repeatable)
        {
            GoogleAdwordsIOSWrapper.ConversionReporterReportWithConversionId1(conversionId,label,value,repeatable);
        }

        public void ConversionReporterReportWithConversionId(string conversionId, string label, string value, string currencyCode,
            bool repeatable)
        {
            GoogleAdwordsIOSWrapper.ConversionReporterReportWithConversionId2(conversionId, label, value,currencyCode, repeatable);
        }

        public void AutomatedUsageReporterDisableAutomatedUsageReporting(string conversionId)
        {
            GoogleAdwordsIOSWrapper.AutomatedUssageReporterDisableAutomatedUssage(conversionId);
        }

        public void AutomatedUsageReporterEnableAutomatedUsageReporting(string conversionId)
        {
            GoogleAdwordsIOSWrapper.AutomatedUssageReporterEnableAutomatedUssage(conversionId);
        }

        public void RemarketingReporterReportWithConversionId(string conversionId)
        {
            GoogleAdwordsIOSWrapper.RemarketingReporterReportWithConversionId1(conversionId);
        }

        public void RemarketingReporterReportWithConversionId(string conversionId, string jsonParams)
        {
            GoogleAdwordsIOSWrapper.RemarketingReporterReportWithConversionId2(conversionId,jsonParams);
        }

        static class  GoogleAdwordsIOSWrapper
        {
            [DllImport("__Internal")]
            public extern static void ConversionReporterRegisterReferrer(string clickUrl);

            [DllImport("__Internal")]
            public extern static void ConversionReporterReportWithConversionId1(string conversionId,string label, string value,bool repeatable);
            [DllImport("__Internal")]
            public extern static void ConversionReporterReportWithConversionId2(string conversionId,string label, string value,string currencyCode,bool repeatable);
            [DllImport("__Internal")]
            public extern static void AutomatedUssageReporterDisableAutomatedUssage(string conversionId);
            [DllImport("__Internal")]
            public extern static void AutomatedUssageReporterEnableAutomatedUssage(string conversionId);
            [DllImport("__Internal")]
            public extern static void RemarketingReporterReportWithConversionId1(string conversionId);

            [DllImport("__Internal")]
            public extern static void RemarketingReporterReportWithConversionId2(string conversionId, string jsonParams);
        }
    }

}
#endif
