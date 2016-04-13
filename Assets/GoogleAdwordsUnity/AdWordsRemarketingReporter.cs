using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
