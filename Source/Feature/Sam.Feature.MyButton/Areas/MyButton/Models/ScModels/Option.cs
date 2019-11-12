using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam.Feature.MyButton.Areas.MyButton.Models.ScModels
{
    [SitecoreType(TemplateId = Templates.Option.Id, AutoMap = true)]
    public class Option
    {
        [SitecoreId]
        public virtual Guid Id { get; set; }

        [SitecoreField(FieldType = SitecoreFieldType.SingleLineText)]
        public virtual string Class { get; set; }
    }
}