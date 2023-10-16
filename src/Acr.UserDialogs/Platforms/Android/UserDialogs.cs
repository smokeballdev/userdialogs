using System;
using Acr.UserDialogs.Infrastructure;
using Android.App;


namespace Acr.UserDialogs
{
    public static partial class UserDialogs
    {
        public static void Init(Func<Activity> topActivityFactory)
        {
            Instance = new UserDialogsImpl(topActivityFactory);
        }


        /// <summary>
        /// Initialize android user dialogs
        /// </summary>
        public static void Init(Application app)
        {
            ActivityLifecycleCallbacks.Register(app);
            Init(() => ActivityLifecycleCallbacks.CurrentTopActivity);
        }


        /// <summary>
        /// Initialize android user dialogs
        /// </summary>
        public static void Init(Activity activity)
        {
            ActivityLifecycleCallbacks.Register(activity);
            Init(() => ActivityLifecycleCallbacks.CurrentTopActivity);
        }
    }
}
