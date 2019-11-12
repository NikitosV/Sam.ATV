using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sam.Feature.MyButton.Areas.MyButton.Models.ScModels;

namespace Sam.Feature.MyButton.Areas.MyButton.Models.Rendering_Parameters
{
    [SitecoreType(TemplateId = Templates.ButtonRP.Id, AutoMap = true)]
    public class ButtonRP
    {
        [SitecoreField(FieldType = SitecoreFieldType.Droplink)]
        public virtual Option Style { get; set; }
    }
}