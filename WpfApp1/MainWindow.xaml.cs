using FastReport;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Print();
        }
        private List<Class1> Load()
        {
            List<Class1> L = new List<Class1>();
            for(int i=1;i<20;i++)
                L.Add(new Class1 { id = i, Name = "Name"+i.ToString() });
            return L;
        }
        private void Print()
        {
            var R = Load();
            Report rep = new Report();
            rep.RegisterData(R, "prntTurn");
            rep.Load(@"Test.frx");
            //     rep.Design();
          
          
             rep.Show();
        }
    }
   
}
