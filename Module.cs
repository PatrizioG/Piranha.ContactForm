using Piranha.Extend;
using System;
using System.Collections.Generic;
using System.Text;

namespace Piranha.ContactForm
{
    public class Module : IModule
    {
        public string Author => "Gasperi Patrizio";

        public string Name => "Piranha.ContactForm";

        public string Version => Piranha.Utils.GetAssemblyVersion(GetType().Assembly);

        public string Description => "";

        public string PackageUrl => "";

        public string IconUrl => "";

        public void Init()
        {

        }
    }
}
