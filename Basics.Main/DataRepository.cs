using Basic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Main
{
    public class DataRepository: IDataRepository
    {
        private IDataRepository _repo;
        public DataRepository()
        {
            _repo = new DataRepository();
        }

        public Task<string> GetAppSettingAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}
