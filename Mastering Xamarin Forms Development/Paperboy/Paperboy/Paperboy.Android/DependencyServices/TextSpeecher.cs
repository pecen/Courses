using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Speech.Tts;
using Android.Views;
using Android.Widget;
using Paperboy.Droid.DependencyServices;
using Paperboy.Interfaces;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(TextSpeecher))]
namespace Paperboy.Droid.DependencyServices {
  public class TextSpeecher : Java.Lang.Object, ITextSpeecher, TextToSpeech.IOnInitListener {
    TextToSpeech speaker;
    string toSpeak;

    public void OnInit([GeneratedEnum] OperationResult status) {
      var result = speaker.SetLanguage(Java.Util.Locale.Uk);
      if (status.Equals(OperationResult.Success)) {
        if (Build.VERSION.Release.StartsWith("4")) {
          speaker.Speak(toSpeak, QueueMode.Flush, null);
        }
        else {
          speaker.Speak(toSpeak, QueueMode.Flush, null, null);
        }
      }
    }

    public void Speak(string text) {
      // Forms.Context is obsolete as of Xamarin.Forms 2.5
      // Why did Forms.Context go obsolete?
      // Xamarin.Forms 2.5 introduced a new "Forms embedding" feature, which can embed Forms pages 
      // into Xamarin.iOS / Xamarin.Android apps.However, since Xamarin.Android apps can use multiple 
      // Activities, seemingly there was a danger of Xamarin.Android users calling Forms.Context and in 
      //turn getting a reference to the MainActivity, which has the potential to cause problems.
      var ctx = Android.App.Application.Context; //Forms.Context;

      toSpeak = text;
      if (speaker == null) {
        speaker = new TextToSpeech(ctx, this);
      }
      else {
        if (Android.OS.Build.VERSION.Release.StartsWith("4")) {
          speaker.Speak(toSpeak, QueueMode.Flush, null);
        }
        else {
          speaker.Speak(toSpeak, QueueMode.Flush, null, null);
        }
      }
    }
  }
}