using Spring.Context.Attributes;

namespace Insidiae.WPF.Features.Application
{
    [Configuration]
    public class ApplicationConfiguration
    {
        [Definition]
        public virtual ApplicationViewModel ApplicationViewModel()
        {
            return new ApplicationViewModel();
        }
    }
}