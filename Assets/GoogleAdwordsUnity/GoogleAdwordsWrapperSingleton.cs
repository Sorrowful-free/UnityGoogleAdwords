using Assets.GoogleAdwordsUnity.Adapters;

namespace Assets.GoogleAdwordsUnity
{
    public static class GoogleAdwordsWrapperSingleton
    {
        private static IGoogleAdwordsAdapter _adapterInstance;

        public static IGoogleAdwordsAdapter AdapterInstance
        {

            get
            {
#if UNITY_ANDROID
                return _adapterInstance ?? new GoogleAdwordsAndroidAdapter();
#elif UNITY_IPHONE || UNITY_IOS
                return _adapterInstance ?? new GoogleAdwordsIOSAdapter();
#else
                return _adapterInstance ?? new GoogleAdwordsDummyAdapter();
#endif
            }
        }
    }
}
