using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap
{
    public class AppNavigator : IAppNavigator
    {
        public Task GoBackAsync(object data = default)
        {
            return NavigateAsync($"{UriHelper.GoBackSegment}", data);
        }

        public Task NavigateAsync(string target, object args = default)
        {
            var targetUri = UriHelper.EnsureUri(target, args);
            return Shell.Current.GoToAsync(targetUri);
        }
    }
}
