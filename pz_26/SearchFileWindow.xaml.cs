using System;
using System.IO;
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

namespace pz_26
{
    /// <summary>
    /// Логика взаимодействия для SearchFileWindow.xaml
    /// </summary>
    public partial class SearchFileWindow : Window
    {
        public SearchFileWindow()
        {
            InitializeComponent();
        }
        private void Ofcourse_Click(object sender, RoutedEventArgs e)
        {
            listbox1.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(Search.Text);

            DirectoryInfo[] dirs = dir.GetDirectories();

            foreach (DirectoryInfo derol in dirs)
            {
                listbox1.Items.Add(derol);
            }
            FileInfo[] files = dir.GetFiles();
            foreach(FileInfo derol in files)
            {
                listbox1.Items.Add(derol);
            }
        }
        public string FileName
        {
            get { return Search.Text; }
        }

    }
}