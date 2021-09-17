namespace LCBSetting.Properties {
    using System.CodeDom.Compiler;
    using System.Configuration;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// 
    /// </summary>
    [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    [CompilerGenerated]
    internal sealed partial class Settings : ApplicationSettingsBase {
       /// <summary>
       /// 
       /// </summary>
        public static Settings Default {
            get {
                return Settings.defaultInstance;
            }
        }

        private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
    }
}
