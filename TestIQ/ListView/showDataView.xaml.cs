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

namespace TestIQ.ListView
{
    /// <summary>
    /// Interaction logic for showDataView.xaml
    /// </summary>
    public partial class showDataView : Page
    {
        Grid _grid;

        public showDataView(Grid grid)
        {
            InitializeComponent();
            _grid = grid;
        }

        private async void LoadData()
        {
            var question = new DataAcces.QuestionAccess();
            var listUserData  = question.LoadQuestion();
            listUserDt.ItemsSource = await listUserData;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void listUserDt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = listUserDt.SelectedItem as TestIQ.Models.QuestionModel;
            Console.WriteLine(item.Answer);
        }

        private void listUserDt_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            var _question = listUserDt.SelectedItem as Models.QuestionModel;
            UControls.DetailQuestionUControl detail = new UControls.DetailQuestionUControl(_grid,_question);
            AddControl(_grid,0,1,detail);

        }
        private void AddControl(Grid grd,int gridColumn,int gridRow,UserControl u)
        {
            grd.Children.Add(u);
            u.SetValue(Grid.RowProperty, gridRow);
            u.SetValue(Grid.ColumnProperty, gridColumn);
            u.SetValue(Grid.ColumnSpanProperty, 4);
            u.SetValue(Grid.RowSpanProperty, 4);
            u.Margin = new Thickness(20);

        }

    }
}
