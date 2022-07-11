using System;
using System.Collections;
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

namespace Sorted_List_Tutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedList;
        public MainWindow()
        {
            InitializeComponent();
            sortedList=new SortedList();
        }

        private void Addbt_Click(object sender, RoutedEventArgs e)
        {
            sortedList.Add(KeyTxT.Text,ValueTxT.Text);

            ICollection icollection = sortedList.Keys;

            string AllValue = "";
            foreach (string key in icollection)
            {
                //MessageBox.Show(sortedList[key].ToString());
                
                AllValue = AllValue + " " + "\n" + sortedList[key].ToString();
            }
            MessageBox.Show(AllValue);
        }

        private void KeyTxT_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ValueTxT_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
