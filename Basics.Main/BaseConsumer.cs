using Basic;
using System;
using System.Threading.Tasks;

namespace Basics.Main
{
    public class BaseConsumer
    {
        public IDataRepository DataRepository = new DataRepository();

        public async Task<string> AppSetting()
        {
            return await DataRepository.GetAppSettingAsync("name");
        }
    }
}
