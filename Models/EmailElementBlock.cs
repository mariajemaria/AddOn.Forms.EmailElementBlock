using System.Linq;
using AddOn.Forms.EmailElementBlock.Core;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Forms.Core.Validation;
using EPiServer.Forms.EditView.DataAnnotations;
using EPiServer.Forms.Implementation.Elements;
using EPiServer.Forms.Implementation.Validation;

namespace AddOn.Forms.EmailElementBlock.Models
{
    [ContentType(DisplayName = "Email element", 
        GroupName = "Custom Elements", 
        GUID = "6EC25089-FC8B-45E1-BB2E-03E13C3020CD")]
    [AvailableValidatorTypes(Include = new [] { typeof(RequiredValidator) })]
    [EmailElementImageUrl]
    public class EmailElementBlock : TextboxElementBlock
    {
        public override string Validators
        {
            get
            {
                var propertyValue = this.GetPropertyValue("Validators");
                var listFromRawString = _validationService.Service.CreateValidatorListFromRawString(propertyValue).ToList();
                
                var validatorsWithEmailAdded = _validationService.Service.ToRawString(listFromRawString.Union(new IElementValidator[]
                {
                    new EmailValidator()
                }));

                return validatorsWithEmailAdded;
            }
            set
            {
                this.SetPropertyValue(content => content.Validators, value);
            }
        }
    }
}