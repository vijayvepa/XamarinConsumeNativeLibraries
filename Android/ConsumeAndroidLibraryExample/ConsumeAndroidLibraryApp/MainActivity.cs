using Android.App;
using Android.Widget;
using Android.OS;
using Imprt.Aar.Philips.Com.Demochart;

namespace ConsumeAndroidLibraryApp
{
    [Activity(Label = "ConsumeAndroidLibraryApp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            DrawBarChart chart = new DrawBarChart(this.ApplicationContext);
            SetContentView(chart.RootView);


            // Set our view from the "main" layout resource
            //SetContentView(Resource.Layout.Main);
        }
    }
}

