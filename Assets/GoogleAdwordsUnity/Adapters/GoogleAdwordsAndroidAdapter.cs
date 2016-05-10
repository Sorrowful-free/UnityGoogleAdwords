#if UNITY_ANDROID
using UnityEngine;

namespace Assets.GoogleAdwordsUnity.Adapters
{
    public class GoogleAdwordsAndroidAdapter : IGoogleAdwordsAdapter
    {
        private AndroidJavaObject _currentActivity;
        private AndroidJavaObject CurrentActivity
        {
            get
            {
                if (_currentActivity == null)
                {
                    AndroidJavaClass javaClassUnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
                    _currentActivity = javaClassUnityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
                }
                return _currentActivity;
            }

        }

        private AndroidJavaClass _googleAdwordsAndroidWrapper;

        private AndroidJavaClass GoogleAdwordsAndroidWrapper
        {
            get
            {
                if (_googleAdwordsAndroidWrapper == null)
                {
                    _googleAdwordsAndroidWrapper = new AndroidJavaClass("com.milkygames.googleadwordsandroidwrapper.GoogleAdwordsAndroidWrapper");
                }
                return _googleAdwordsAndroidWrapper;
            }
        }
        public void ConversionReporterRegisterReferrer(string clickUrl)
        {
            GoogleAdwordsAndroidWrapper.CallStatic("ConversionReporterRegisterReferrer", CurrentActivity, clickUrl);
        }

        public void ConversionReporterReportWithConversionId(string conversionId, string label, string value, bool repeatable)
        {
            GoogleAdwordsAndroidWrapper.CallStatic("ConversionReporterReportWithConversionId1", CurrentActivity, conversionId, label, value,  new AndroidJavaObject("java.lang.Boolean", repeatable));
        }

        public void ConversionReporterReportWithConversionId(string conversionId, string label, string value, string currencyCode,bool repeatable)
        {
            GoogleAdwordsAndroidWrapper.CallStatic("ConversionReporterReportWithConversionId2", CurrentActivity, conversionId, label, value, currencyCode,  new AndroidJavaObject("java.lang.Boolean", repeatable));
        }

        public void AutomatedUsageReporterDisableAutomatedUsageReporting(string conversionId)
        {
            GoogleAdwordsAndroidWrapper.CallStatic("AutomatedUsageReporterDisableAutomatedUsageReporting", CurrentActivity, conversionId);
        }

        public void AutomatedUsageReporterEnableAutomatedUsageReporting(string conversionId)
        {
            GoogleAdwordsAndroidWrapper.CallStatic("AutomatedUsageReporterEnableAutomatedUsageReporting", CurrentActivity, conversionId);
        }

        public void RemarketingReporterReportWithConversionId(string conversionId)
        {
            GoogleAdwordsAndroidWrapper.CallStatic("RemarketingReporterReportWithConversionId1", CurrentActivity, conversionId);
        }

        public void RemarketingReporterReportWithConversionId(string conversionId, string jsonParams)
        {
            GoogleAdwordsAndroidWrapper.CallStatic("RemarketingReporterReportWithConversionId2", CurrentActivity, conversionId, jsonParams);
        }
    }
}
#endif
