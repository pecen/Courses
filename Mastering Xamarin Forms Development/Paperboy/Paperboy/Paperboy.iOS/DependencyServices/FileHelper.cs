using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Foundation;
using Paperboy.Interfaces;
using Paperboy.iOS.DependencyServices;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]
namespace Paperboy.iOS.DependencyServices {
  public class FileHelper : IFileHelper {
    public string GetLocalFilePath(string filename) {
      string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
      string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

      if (!Directory.Exists(libFolder)) {
        Directory.CreateDirectory(libFolder);
      }

      return Path.Combine(libFolder, filename);
    }

    public List<string> GetSpecialFolders() {
      List<string> folders = new List<string>();

      foreach (var folder in Enum.GetValues(typeof(Environment.SpecialFolder))) {
        if (!string.IsNullOrEmpty(System.Environment.GetFolderPath((Environment.SpecialFolder)folder))) {
          folders.Add($"{folder}={System.Environment.GetFolderPath((Environment.SpecialFolder)folder)}");
        }
      }

      return folders;
    }
  }
}