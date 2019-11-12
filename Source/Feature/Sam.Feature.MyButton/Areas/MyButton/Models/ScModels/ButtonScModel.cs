using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;

namespace Sam.Feature.MyButton.Areas.MyButton.Models.ScModels
{
    [SitecoreType(TemplateId = Templates.Button.Id, AutoMap = true)]
    public class ButtonScModel
    {
        [SitecoreId]
        public virtual Guid Id { get; set; }

        [SitecoreField(FieldType = SitecoreFieldType.GeneralLink)]
        public virtual Link Link { get; set; }
    }
}