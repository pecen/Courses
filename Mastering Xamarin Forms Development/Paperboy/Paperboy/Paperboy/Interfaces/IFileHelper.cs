using System;
using System.Collections.Generic;
using System.Text;

namespace Paperboy.Interfaces
{
  public interface IFileHelper {
    string GetLocalFilePath(string filename);

    List<string> GetSpecialFolders();
  }
}
