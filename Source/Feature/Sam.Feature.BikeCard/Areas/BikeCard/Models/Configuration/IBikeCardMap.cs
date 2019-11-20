using Glass.Mapper.Sc.Maps;
using Sam.Feature.BikeCard.Areas.BikeCard.Models.ViewModels;

namespace Sam.Feature.BikeCard.Areas.BikeCard.Models.Configuration
{
    public class IBikeCardMap : SitecoreGlassMap<IBikeCardClass>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.Id(f => f.Id);
                config.Field(f => f.Name).FieldId("{691D78ED-04D7-48FA-B538-7437E52C633B}");
                config.Field(f => f.Image).FieldId("{84B948FB-CB54-4B30-94F9-D1FE29101629}");
                config.Field(f => f.TypeEngine).FieldId("{22858345-E9B9-4F3B-988B-E09DE154174E}");
                config.Field(f => f.MaxSpeed).FieldId("{C3DF6960-2DD2-4C00-9503-1BB16D779C2F}");
                config.Field(f => f.Fuel).FieldId("{64D5A0A7-BB56-4E3C-8305-D520CFCF10DC}");
                config.Field(f => f.Description).FieldId("{40C3A99E-4004-48C1-BC58-49A56BF96B38}");
                config.Field(f => f.Price).FieldId("{EFBA20B9-F9BE-4285-9107-16E722A629D8}");
            });
        }
    }
}