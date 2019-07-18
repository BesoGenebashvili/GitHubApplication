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

            LoginForm loginForm = ServiceManager.Instance.Container.Resolve<LoginForm>();

            Application.Run(loginForm);
        }
    }
}