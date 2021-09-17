namespace LCBSetting {
    using System;
    using System.Runtime.InteropServices;
    using System.Text;

    /// <summary>
    /// 
    /// </summary>
    internal class IniFile {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lpApplicationName"></param>
        /// <param name="lpKeyName"></param>
        /// <param name="lpDefault"></param>
        /// <param name="lpReturnedstring"></param>
        /// <param name="nSize"></param>
        /// <param name="lpFileName"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(string lpApplicationName, string lpKeyName, string lpDefault, StringBuilder lpReturnedstring, int nSize, string lpFileName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lpApplicationName"></param>
        /// <param name="lpKeyName"></param>
        /// <param name="lpstring"></param>
        /// <param name="lpFileName"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        private static extern int WritePrivateProfileString(string lpApplicationName, string lpKeyName, string lpstring, string lpFileName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        public IniFile(string filePath) => this.filePath = filePath;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public string this[string section, string key] {
            get {
                var stringBuilder = new StringBuilder(256);
                IniFile.GetPrivateProfileString(section, key, string.Empty, stringBuilder, stringBuilder.Capacity, filePath);
                return stringBuilder.ToString();
            }
            set => IniFile.WritePrivateProfileString(section, key, value, filePath);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="defaultvalue"></param>
        /// <returns></returns>
        public string GetValue(string section, string key, string defaultvalue) {
            var stringBuilder = new StringBuilder(256);
            IniFile.GetPrivateProfileString(section, key, defaultvalue, stringBuilder, stringBuilder.Capacity, filePath);
            return stringBuilder.ToString();
        }

        private readonly string filePath;
    }
}
