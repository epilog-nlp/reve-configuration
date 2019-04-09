using System.ComponentModel.Composition;

namespace REvE.Configuration.Tests
{
    public static class AppSettings
    {
        [Export("json-cfg")]
        public const string JsonSourceKey = "json-config";
        [Export("xml-cfg")]
        public const string XmlSourceKey = "xml-config";
    }
}
