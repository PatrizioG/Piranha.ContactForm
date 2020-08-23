using Piranha.Manager;

namespace Piranha.ContactForm
{
    public class Module : Piranha.Extend.IModule
    {
        public string Author => "Gasperi Patrizio";

        public string Name => "Piranha.ContactForm";

        public string Version => Piranha.Utils.GetAssemblyVersion(GetType().Assembly);

        public string Description => "";

        public string PackageUrl => "";

        public string IconUrl => "";

        public void Init()
        {
            Menu.Items["Settings"].Items.Add(new MenuItem
            {
                InternalId = "ContactForm",
                Name = "Contact Form",
                Route = "~/manager/contactform",
                Css = "fab fa-wpforms",
                Policy = Permission.Config
            });
        }
    }
}
