using System;
using System.Windows.Forms;
using GitHubApplication.Services;
using GitHubApplication.Common;
using GitHubApplication.DataBaseContext;
using Unity.Lifetime;
using Unity;

namespace GitHubApplication
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ServiceManager.Instance.Container.RegisterType<GitHubDataBaseContext>(new ContainerControlledLifetimeManager());
            ServiceManager.Instance.Container.RegisterType<IUserService, UserServiceDb>();

            GitHubForm gitHubForm = ServiceManager.Instance.Container.Resolve<GitHubForm>();
            Application.Run(gitHubForm);
        }
    }
}