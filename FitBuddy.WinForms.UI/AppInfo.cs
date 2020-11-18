namespace FitBuddy.WinForms.UI
{
    internal static class AppInfo
    {
        private static readonly System.Diagnostics.FileVersionInfo _fileVersionInfo;

        static AppInfo()
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            _fileVersionInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
        }
        
        public static string ProductName => _fileVersionInfo.ProductName;
        public static string ProductVersion => _fileVersionInfo.ProductVersion;
    }
}
