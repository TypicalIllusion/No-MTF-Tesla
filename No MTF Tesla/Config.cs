using System.Collections.Generic;
using System.ComponentModel;

using Exiled.API.Interfaces;

namespace No_MTF_Tesla
{
    public class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;
    }
}
