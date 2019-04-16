using Basic;
using System;
using System.Threading.Tasks;

namespace Basics.Main
{
    public class BaseConsumer
    {
        public IDataRepository DataRepository;

        public BaseConsumer(IDataRepository repo)
        {
            DataRepository = repo;
        }

        public async Task<string> AppSetting()
        {
            return await DataRepository.GetAppSettingAsync("name");
        }
    }
}
