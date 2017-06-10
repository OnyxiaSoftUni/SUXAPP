using Android.App;
using Android.Widget;
using Android.OS;

namespace SUXAPP
{
    [Activity(Label = "SUXAPP", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button button = FindViewById<Button>(Resource.Id.Mybutton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}