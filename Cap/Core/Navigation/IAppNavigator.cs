using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap
{
    public interface IAppNavigator
    {
        Task GoBackAsync(object data = default);

        Task NavigateAsync(string target, object args = default);
    }
}
