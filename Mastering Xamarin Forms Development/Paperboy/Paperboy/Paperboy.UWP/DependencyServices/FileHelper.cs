using Paperboy.Interfaces;
using Paperboy.UWP.DependencyServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]
namespace Paperboy.UWP.DependencyServices {
  public class FileHelper : IFileHelper {
    public string GetLocalFilePath(string filename) {
      return Path.Combine(ApplicationData.Current.LocalFolder.Path, filename);
    }

    public List<string> GetSpecialFolders() {
      return new List<string>();
    }
  }
}
