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
using System.Windows.Shapes;

namespace rocketship_simulator_1
{
    /// <summary>
    /// Interaction logic for rocket.xaml
    /// </summary>
    public partial class rocket : Window
    {
        public rocket()
        {
            InitializeComponent();
        }

        public class Ship
        {
            Ship newShip = new Ship();
        }

        private void btn_Quit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
