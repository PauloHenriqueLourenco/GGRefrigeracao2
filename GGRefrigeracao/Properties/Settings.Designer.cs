﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GGRefrigeracao.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.1.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\paulo\\Documents\\DBGG" +
            "Refrigeracao.mdf;Integrated Security=True;Connect Timeout=30")]
        public string DBGGRefrigeracaoConnectionString {
            get {
                return ((string)(this["DBGGRefrigeracaoConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=C:\\USERS\\PAULO\\DOCUMENTS\\DBGGR" +
            "EFRIGERACAO.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustS" +
            "erverCertificate=True")]
        public string C__USERS_PAULO_DOCUMENTS_DBGGREFRIGERACAO_MDFConnectionString {
            get {
                return ((string)(this["C__USERS_PAULO_DOCUMENTS_DBGGREFRIGERACAO_MDFConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=PAULO;Initial Catalog=DBGGRefrigeracao;Persist Security Info=True;Use" +
            "r ID=sa;Password=17212300")]
        public string DBGGRefrigeracaoConnectionString1 {
            get {
                return ((string)(this["DBGGRefrigeracaoConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=PAULO;Initial Catalog=DBGGRefrigeracao;Integrated Security=True")]
        public string DBGGRefrigeracaoConnectionString2 {
            get {
                return ((string)(this["DBGGRefrigeracaoConnectionString2"]));
            }
        }
    }
}
