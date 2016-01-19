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
using WpfApplication1.Controller;
using WpfApplication1.Model;

namespace WpfApplication1.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IController controller;
        IModel model;
        
        public MainWindow()
        {
            InitializeComponent();           
            controller = new MyController();
            model = new MyModel();
            controller.SetModel(model);
            //controller.SetView()

        }

        

    }
}
