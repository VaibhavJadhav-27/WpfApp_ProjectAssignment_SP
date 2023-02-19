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
using WpfApp_ProjectAssignment_SP.ViewModels;

namespace WpfApp_ProjectAssignment_SP.Views
{
    /// <summary>
    /// Interaction logic for MainScreen.xaml
    /// </summary>
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
            DataContext = new MainScreenViewModel();
        }
    }
}
