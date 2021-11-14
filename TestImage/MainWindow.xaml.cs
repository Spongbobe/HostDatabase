using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestImage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Models.AccountDataAccess accountData = new Models.AccountDataAccess();

        //
        public int AccountId;

        public MainWindow()
        {
            InitializeComponent();
            LoadUserAccountToComboBox();
        }
        private void LoadUserAccountToComboBox()
        {

            AccountsCb.ItemsSource = accountData.GetAllUserAccount(); 
        }

        private void AccountsCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = AccountsCb.SelectedItem as Models.Account;

            var Images =  accountData.GetAccountData(selectedItem.acount);
            imagesLb.ItemsSource = Images;
            accountName.Text = "Account : " + selectedItem.acount;
        }

        private async Task  ChangeImage(string url,Image img)
        {
            img.Source = new BitmapImage(new Uri(url));
        }

        private async void imagesLb_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedItem = imagesLb.SelectedItem as Models.Account;
            await ChangeImage(selectedItem.ImagePath, img);
        }
     

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog fdo = new FolderBrowserDialog();
            fdo.ShowDialog();

            if(fdo.SelectedPath.Length > 0)
            {
                foreach (var file in System.IO.Directory.GetFiles(fdo.SelectedPath))
                {
                    var selectedItem = AccountsCb.SelectedItem as Models.Account;
                    accountData.AddUserData(new Models.Account() { Id = selectedItem.Id,ImagePath = file});

                }
            }
        }
    }
}
