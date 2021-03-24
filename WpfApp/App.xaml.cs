using Jukebox.Data;
using Jukebox.Data.UnitOfWork;
using Jukebox.Data.UnitOfWork.Abstract;
using Jukebox.Domain;
using Jukebox.Services;
using Jukebox.Services.Abstract;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApp.ViewModels;

namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IServiceProvider serviceProvider;
        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        { 
            services.AddSingleton<IUnitOfWork, UnitOfWork>();
            services.AddSingleton<MainWindow>();
            services.AddTransient<IAlbumService<Album, int>, AlbumService>();
            services.AddTransient<ISongService<Song, int>, SongService>();
            services.AddTransient<ApplicationViewModel>();

        }
        protected override void OnStartup(StartupEventArgs e)
        {
            var mainwindow = serviceProvider.GetRequiredService<MainWindow>();
            mainwindow.Show();
            base.OnStartup(e);
        }
    }
}
