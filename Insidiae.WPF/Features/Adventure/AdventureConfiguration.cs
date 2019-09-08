using Insidiae.AdventureFeature.Views;
using Spring.Context.Attributes;

namespace Insidiae.WPF.Features.Adventure
{
    [Configuration]
    public class AdventureConfiguration
    {
        [Definition]
        public virtual AdventureHostViewModel AdventureHostViewModel()
        {
            return new AdventureHostViewModel();
        }

        [Definition]
        public virtual AdventureListViewModel AdventureListViewModel()
        {
            return new AdventureListViewModel();
        }

        [Definition]
        public virtual AdventureViewModel AdventureViewModel()
        {
            return new AdventureViewModel();
        }
    }
}