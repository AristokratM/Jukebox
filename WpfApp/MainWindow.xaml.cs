using Jukebox.Data.UnitOfWork;
using Jukebox.Domain;
using Jukebox.Services;
using Jukebox.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp.ViewModels;

namespace WpfApp
{
    public partial class MainWindow : Window
    {

        public MainWindow(ApplicationViewModel applicationViewModel)
        {
            InitializeComponent();
            DataContext = applicationViewModel;
        }
    }
}
