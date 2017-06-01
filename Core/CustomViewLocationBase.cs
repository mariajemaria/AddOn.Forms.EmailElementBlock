using EPiServer.Forms.EditView;

namespace AddOn.Forms.EmailElementBlock.Core
{
    public abstract class CustomViewLocationBase : ICustomViewLocation
    {
        public virtual int Order { get; set; }

        public abstract string[] Paths { get; }

        public virtual string GetDefaultViewLocation()
        {
            return "~" + EPiServer.Shell.Paths.ToResource(GetType(), "Views/ElementBlocks");
        }
    }
}
