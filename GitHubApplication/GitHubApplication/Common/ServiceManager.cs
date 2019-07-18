using Unity;

namespace GitHubApplication.Common
{
    public sealed class ServiceManager
    {
        private ServiceManager() { }
        static ServiceManager() { }

        public UnityContainer Container { get; } = new UnityContainer();

        public static ServiceManager Instance { get; } = new ServiceManager();
    }
}