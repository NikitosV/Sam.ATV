using Sam.Foundation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sam.Foundation.Repository.Content
{
    public interface IContentRepository
    {
        T GetContentItem<T>(string contentGuid) where T : class, ICmsEntity;
    }
}
