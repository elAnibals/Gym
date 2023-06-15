using GymManager.Core.Navigation;
using System.Runtime.CompilerServices;

namespace GymManager.Web.Model
{
    public class MenuViewModel
    {
        public string CurrentPageName { get; set; }
        public List<UserMenuItem> Menu { get; set; }
    }
}
