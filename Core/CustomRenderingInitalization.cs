using System.Web.Mvc;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;

namespace AddOn.Forms.EmailElementBlock.Core
{
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class CustomieRenderingInitialization : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            ViewEngines.Engines.Insert(0, new EmailElementViewEngine());
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        public void Preload(string[] parameters)
        {
        }
    }
}
