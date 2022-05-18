using DepreciationDBApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepreciationDBApp.Applications.Interfaces
{
    public interface IAssetEmployeeServices : IService<AssetEmployee>
    {
        List<AssetEmployee> FindByEmployeeId(int employeeId);
        List<AssetEmployee> FindByAssetId(int assetId);
        AssetEmployee FindByAssetEmployeeId(int employeeId, int assetId);
    }
}
