using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp
{
    public class NavigationService
    {
        public void ShowLoginWindow(object viewModel)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.DataContext = viewModel;
            loginWindow.ShowDialog();
        }
    }
}
