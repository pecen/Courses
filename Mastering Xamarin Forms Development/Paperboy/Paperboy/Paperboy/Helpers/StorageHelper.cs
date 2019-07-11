using Paperboy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paperboy.Helpers
{
  public static class StorageHelper {
    public static List<string> GetSpecialFolders() {
      return Xamarin.Forms.DependencyService.Get<IFileHelper>().GetSpecialFolders();
    }

    public static string GetLocalFilePath() {
      return Xamarin.Forms.DependencyService.Get<IFileHelper>().GetLocalFilePath("paperboy.db3");
    }
  }
}
