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

namespace ProgramTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Car> Cars { get; set; } = new List<Car>();
       
        public MainWindow()
        {
            InitializeComponent();
            var car1 = new Car() {BrandName="Mastang",Speed=100,Items= new bot() {bc="bc1",bike="bike1" } };
            var car2 = new Car() {BrandName="Stank",Speed=200 };
            var car3 = new Car() {BrandName="Spong",Speed=120 };

            Cars.Add(car1);
            Cars.Add(car2);
            Cars.Add(car3);

            DataContext = this;
        }
    }
    public class Car
    {
        public string BrandName { get; set; }
        public int Speed  { get; set; }
        public bot Items { get; set; }
    }
    public class bot
    {
        public string bike { get; set; }
        public string bc { get; set; }
    }
}
