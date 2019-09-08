using Insidiae.DependencyInjection;

namespace Insidiae.WPF.Features.Application
{
    public class ViewModelLocator
    {
        public static ApplicationViewModel ApplicationViewModel =>
            SpringContext.GetObject<ApplicationViewModel>(nameof(ApplicationViewModel));

        //public static HomeViewModel HomeViewModel => SpringContext.GetObject<HomeViewModel>(nameof(HomeViewModel));
    }
}