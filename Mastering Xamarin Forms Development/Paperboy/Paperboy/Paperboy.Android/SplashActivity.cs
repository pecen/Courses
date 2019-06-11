using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Paperboy.Droid {
  //[Activity(Label = "SplashActivity")]
  //public class SplashActivity : Activity {
  //  protected override void OnCreate(Bundle savedInstanceState) {
  //    base.OnCreate(savedInstanceState);

  //    // Create your application here
  //  }
  //}

  [Activity(Label = "Paperboy", Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory = true)]
  public class SplashActivity : Activity {
    public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState) {
      base.OnCreate(savedInstanceState, persistentState);
    }

    protected override void OnResume() {
      base.OnResume();

      Task startupWork = new Task(async () =>
      {
        await Task.Delay(1000);
      });

      startupWork.ContinueWith(t =>
      {
        StartActivity(new Intent(Application.Context, typeof(MainActivity)));

      }, TaskScheduler.FromCurrentSynchronizationContext());

      startupWork.Start();
    }
  }
}