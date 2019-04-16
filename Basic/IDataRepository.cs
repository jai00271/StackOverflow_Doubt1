using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    public interface IDataRepository
    {
        Task<string> GetAppSettingAsync(string name);
    }
}
