using System;


namespace Acr.UserDialogs
{
    public static partial class UserDialogs
    {
        static IUserDialogs currentInstance;
        public static IUserDialogs Instance
        {
            get
            {
                if (currentInstance == null)
#if NET7_0

                    throw new ArgumentException("[Acr.UserDialogs] This is the bait library, not the platform library.  You must install the nuget package in your main executable/application project");
#elif ios

                    currentInstance = currentInstance ?? new UserDialogsImpl();
#elif ANDROID
                    throw new ArgumentException("[Acr.UserDialogs] In android, you must call UserDialogs.Init(Activity) from your first activity OR UserDialogs.Init(App) from your custom application OR provide a factory function to get the current top activity via UserDialogs.Init(() => supply top activity)");
#endif
                return currentInstance;
            }
            set => currentInstance = value;
        }

    }

}
