using System.Linq;
using System.Web.Mvc;
using EPiServer.Forms.EditView;
using EPiServer.ServiceLocation;

namespace AddOn.Forms.EmailElementBlock.Core
{
    public class EmailElementViewEngine : RazorViewEngine
    {
        public EmailElementViewEngine()
        {
            var customViewLocator = ServiceLocator.Current.GetAllInstances<ICustomViewLocation>();
            foreach (ICustomViewLocation customViewLocation in customViewLocator.OrderBy(cvl => cvl.Order))
            {
                PartialViewLocationFormats = PartialViewLocationFormats.Union(
                    customViewLocation.Paths.Select(p => $"{p}/{{0}}.cshtml")).ToArray();
            }
        }
    }
}
