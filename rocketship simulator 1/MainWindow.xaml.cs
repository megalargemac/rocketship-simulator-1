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
        public Launcher myLauncher = null;

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
            private int fuel; ///fuel
            private int passengers; ///passengers

            ///public methods
            
            ///get/set methods
            public void SetRockets(int r) { rockets = r; }
            public int GetRockets() { return rockets; }
            public void SetFuel(int f) { fuel = f; }
            public int GetFuel() { return fuel; }
            public void SetPassengers(int p) { passengers = p; }
            public int GetPassengers() { return passengers; }

            ///overloaded constructor
            public Ship(int rockets, int fuel, int passengers)
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

        public class Launcher
        {
            private string name; //name
            private double height; //height
            private double diameter; //diameter
            private int emptymass; //empty mass
            private int grossmass; //gross mass
            private double maxthrust; //maximum thrust
            private double specificimpulse; //specific impulse
            private double burntime; // burn time

            //public methods

            //get/set methods
            public void SetName(string n) { name = n; }
            public string GetName() { return name; }
            public void SetHeight(double h) { height = h; }
            public double GetHeight() { return height; }
            public void SetDiameter(double d) { diameter = d; }
            public double GetDiameter() { return diameter; }
            public void SetEmptyMass(int em) { emptymass = em; }
            public int GetEmptyMass() { return emptymass; }
            public void SetGrossMass(int gm) { grossmass = gm; }
            public int GetGrossMass() { return grossmass; }
            public void SetMaxThrust(double mt) { maxthrust = mt; }
            public double GetMaxThrust() { return maxthrust; }
            public void SetSpecificImpulse(double si) { specificimpulse = si; }
            public double GetSpecificImpulse() { return specificimpulse; }
            public void SetBurnTime(double bt) { burntime = bt; }
            public double GetBurnTime() { return burntime; }

            //overloaded constructor
            public Launcher(string name, double height, double diameter, int emptymass, int grossmass, double maxthrust, double specificimpulse, double burntime)
            {
                this.SetName(name);
                this.SetHeight(height);
                this.SetDiameter(diameter);
                this.SetEmptyMass(emptymass);
                this.SetGrossMass(grossmass);
                this.SetMaxThrust(maxthrust);
                this.SetSpecificImpulse(specificimpulse);
                this.SetBurnTime(burntime);
            }

            public Launcher()
            {
                //default constructor no overloads
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

            //selector
            if (this.cmb_rocket.SelectedItem == null || this.cmb_rocket.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a rocket");

            }
            else
            {
                switch (cmb_rocket.Text)
                {
                    //vega
                    case "Vega":
                        myLauncher = new Launcher("Vega", 11.7, 3, 7330, 95695, 2261, 280, 107);
                        break;

                    //soyuz
                    case "Soyuz ST":
                        myLauncher = new Launcher("Soyuz ST", 27.1, 2.95, 6545, 99765, 99100, 792.41, 263.3);
                        break;
                    
                    //ariane 5
                    case "Ariane 5":
                        myLauncher = new Launcher("Ariane 5", 31.6, 3.06, 33530, 273317, 7080, 262, 140);
                        break;

                    //saturn v
                    case "Saturn V":
                        myLauncher = new Launcher("Saturn V", 42, 10, 137000, 2214000, 35100, 263, 150);
                        break;
                }

                if (this.txt_numrockets.Text == null)
                {
                    MessageBox.Show("Please select a number of rockets");
                }
                else
                {
                    int rockets = Int32.Parse(txt_numrockets.Text);
                }

                if (this.txt_fuel.Text == null)
                {
                    MessageBox.Show("Please select an amount of fuel");
                }
                else
                {
                    int fuel = Int32.Parse(txt_fuel.Text);
                }

                if (this.txt_passengers.Text == null)
                {
                    MessageBox.Show("Please select a number of passengers");
                }
                else
                {
                    int rockets = Int32.Parse(txt_passengers.Text);
                }
            }
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
