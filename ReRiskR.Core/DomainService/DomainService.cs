using ReRiskR.Core.DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReRiskR.Core.DomainService
{
    public class DomainService<TDomain, TId> where TDomain : class, new()
    {
        readonly IEntityDataService<TDomain> _entityDataService;

        public DomainService(IEntityDataService<TDomain> entityDataService)
        {
            _entityDataService = entityDataService;
        }

        public virtual async Task<IEnumerable<TDomain>> GetAll()
        {
            return await _entityDataService.GetAll();
        }
    }
}
