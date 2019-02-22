using Colloseum.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Colloseum.Extensions
{
  public static class JsonExtensions {
    /// <summary>
    /// Converts an object to a Json string
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="self"></param>
    /// <returns></returns>
    public static string ToJson<T>(this T self) => JsonConvert.SerializeObject(self, Converter.Settings);

    /// <summary>
    /// Converts a Json string to its equivalent object
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="self"></param>
    /// <param name="json"></param>
    /// <returns></returns>
    public static T FromJson<T>(this T self, string json) => JsonConvert.DeserializeObject<T>(json, Converter.Settings);
  }
}
