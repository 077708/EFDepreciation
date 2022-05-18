using DepreciationDBApp.Applications.Interfaces;
using DepreciationDBApp.Domain.Entities;
using DepreciationDBApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepreciationDBApp.Applications.Services
{
    public class AssetEmployeeServices : IAssetEmployeeServices
    {
        private IAssetEmployeeRepository AssetEmployeeRepository;

        public AssetEmployeeServices(IAssetEmployeeRepository assetEmployeeRepository)
        {
            this.AssetEmployeeRepository = assetEmployeeRepository;
        }
        
        public void Create(AssetEmployee t)
        {
            AssetEmployeeRepository.Create(t);
        }

        public bool Delete(AssetEmployee t)
        {
            throw new NotImplementedException();
        }

        public AssetEmployee FindByAssetEmployeeId(int employeeId, int assetId)
        {
            throw new NotImplementedException();
        }

        public List<AssetEmployee> FindByAssetId(int assetId)
        {
            throw new NotImplementedException();
        }

        public List<AssetEmployee> FindByEmployeeId(int employeeId)
        {
            throw new NotImplementedException();
        }

        public List<AssetEmployee> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Update(AssetEmployee t)
        {
            throw new NotImplementedException();
        }
    }
}
