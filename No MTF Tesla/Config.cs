using System.ComponentModel;

using Exiled.API.Interfaces;

namespace No_MTF_Tesla
{
    public class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;
        [Description("Should scientists set off tesla gates?")]
        public bool ScientistTesla { get; set; } = false;
        [Description("Should MTF set off the tesla gates?")]
        public bool MTFTesla { get; set; } = false;
    }
}
