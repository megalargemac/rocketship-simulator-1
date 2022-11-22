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

namespace rocketship_simulator_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Ship myShip = null;

        private void txt_numrockets_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void txt_fuel_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void txt_passengers_TextChanged(object sender, TextChangedEventArgs e)
        {
             
        }

        public class Ship
        {
            ///private components
            private int rockets; ///rockets
            private float fuel; ///fuel
            private int passengers; ///passengers

            ///public methods
            
            ///get/set methods
            public void SetRockets(int r) { rockets = r; }
            public int GetRockets() { return rockets; }
            public void SetFuel(float f) { fuel = f; }
            public float GetFuel() { return fuel; }
            public void SetPassengers(int p) { passengers = p; }
            public int GetPassengers() { return passengers; }

            ///overloaded constructor
            public Ship(int rockets, float fuel, int passengers)
            {
                this.SetRockets(rockets);
                this.SetFuel(fuel);
                this.SetPassengers(passengers);
            }

            public Ship()
            {
                ///default constructor no overloads
            }

        }
        
        ///rocket ship window
        private void btn_launch_Click(object sender, RoutedEventArgs e)
        {
            rocket a = new rocket();
            a.Show();

            myShip = new Ship();
            txt_numrockets.Text = myShip.GetPassengers().ToString();
            txt_fuel.Text = myShip.GetFuel().ToString();
            txt_passengers.Text = myShip.GetPassengers().ToString();

        }
        
        ///quit
        private void btn_Quit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        
        ///rocket selector
        private void cmb_rocket_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
