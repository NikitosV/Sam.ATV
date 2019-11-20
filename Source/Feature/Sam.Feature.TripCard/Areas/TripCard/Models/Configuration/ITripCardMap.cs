using Glass.Mapper.Sc.Maps;
using Sam.Feature.TripCard.Areas.TripCard.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sam.Feature.TripCard.Areas.TripCard.Models.Configuration
{
    public class ITripCardMap : SitecoreGlassMap<ITripCardClass>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.Id(f => f.Id);
                config.Field(f => f.Title).FieldId("{C87CE1B1-2CFF-47B4-94F1-8217B0E5235E}");
                config.Field(f => f.Image).FieldId("{BFC53BB3-75E3-4E2E-AD3B-DB8294993BDB}");
                config.Field(f => f.Description).FieldId("{7F3F531D-69CA-480F-8995-A7FFD1008F52}");
                config.Field(f => f.StartDate).FieldId("{09EFCD45-15E1-4732-B9CA-80EDB4C319B8}");
                config.Field(f => f.EndDate).FieldId("{DAFDB3B3-844D-47E7-A013-F175C6D4CE3D}");
                config.Field(f => f.Price).FieldId("{AADD3D1C-1F66-4CDA-8E6F-3C6BEA7E0CEA}");
            });

        }
    }
}
