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
using WpfApplication1.ServiceReference1;
namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ServiceReference1.MyServiceClient client = new ServiceReference1.MyServiceClient();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            String uname = Uname.Text;
            String pw = Pw.Text;
            if (client.Login(uname, pw))
            {   Window1 w1 = new Window1();
                w1.Show();
                this.Close();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            String uname = Usname.Text;
            label.Content = "password: "+ client.Register(uname);
            Console.WriteLine(client.Register(uname));
            client.Insert(Usname.Text);

        }
    }
}
