using Insidiae.AdventureFeature.Views;
using Insidiae.DependencyInjection;

namespace Insidiae.AdventureFeature
{
    public class ViewModelLocator
    {
        public static AdventureHostViewModel AdventureHostViewModel =>
            SpringContext.GetObject<AdventureHostViewModel>(nameof(AdventureHostViewModel));

        public static AdventureListViewModel AdventureListViewModel =>
            SpringContext.GetObject<AdventureListViewModel>(nameof(AdventureListViewModel));

        public static AdventureViewModel AdventureViewModel =>
            SpringContext.GetObject<AdventureViewModel>(nameof(AdventureViewModel));
    }
}