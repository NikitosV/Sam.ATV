using Glass.Mapper.Sc.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam.ATV.Web.Areas.ATV.Models.Order.Configuration
{
    public class IOrderClassMap : SitecoreGlassMap<IOrderClass>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.Id(f => f.Id);
                config.Field(f => f.EmailName).FieldId("{AA97E091-D1D4-4786-9D56-8C6A33962229}");
                config.Field(f => f.BikeId).FieldId("{C63392E0-CB87-4B81-9825-719F57053EE4}");
                config.Field(f => f.BikeName).FieldId("{8EB09A65-92B6-4881-A149-2DDE16EDCA12}");
                config.Field(f => f.Price).FieldId("{1B51A149-9A65-4D9A-8F0B-441C96F93187}");
            });

        }
    }
}