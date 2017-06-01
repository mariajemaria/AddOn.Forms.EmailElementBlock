using EPiServer.DataAnnotations;
using EPiServer.Shell;

namespace AddOn.Forms.EmailElementBlock.Core
{
    public class EmailElementImageUrl : ImageUrlAttribute
    {
        public EmailElementImageUrl() : base("/ClientResources/icons/email-block-choose-icon.png")
        {
        }

        public override string Path
        {
            get
            {
                var type = GetType();
                var version = type.Assembly.GetName().Version;
                var path = Paths.ToResource(type, $"{version}/ClientResources/icons/email-block-choose-icon.png");
                return path;
            }
        }
    }
}
