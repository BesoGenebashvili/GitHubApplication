using System;
using System.Windows.Forms;
using GitHubApplication.Common;
using Unity.Lifetime;
using Unity;
using GitHub.Core.DataBaseContext;
using GitHub.Core.Services.Abstractions;
using GitHub.Core.Services.Implementations;

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
            ServiceManager.Instance.Container.RegisterType<IGitHubApiService, GitHubApiService>();
            ServiceManager.Instance.Container.RegisterType<IUserManager, UserManger>();

            GitHubForm gitHubForm = ServiceManager.Instance.Container.Resolve<GitHubForm>();
            Application.Run(gitHubForm);
        }
    }
}