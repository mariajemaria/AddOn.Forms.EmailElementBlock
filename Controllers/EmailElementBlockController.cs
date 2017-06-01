using System.Web.Mvc;
using EPiServer.Shell;
using EPiServer.Web.Mvc;

namespace AddOn.Forms.EmailElementBlock.Controllers
{
    public class EmailElementBlockController : BlockController<Models.EmailElementBlock>
    {
        public override ActionResult Index(Models.EmailElementBlock currentBlock)
        {
            var path = Paths.ToResource(GetType(), "Views/ElementBlocks/EmailElementBlock.ascx");

            return PartialView(path, currentBlock);
        }
    }
}
