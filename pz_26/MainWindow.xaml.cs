using Microsoft.SqlServer.Server;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace pz_26
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool ital = false;
        bool bld = false;
        bool und = false;
        private string ReadMessage;

        public string filename { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            SearchFileWindow searceFileWindow = new SearchFileWindow();
            if (searceFileWindow.ShowDialog() == true)
                filename = searceFileWindow.FileName;
        }
        private void New_Click(object sender, RoutedEventArgs e)
        {
            CreateFileWindow createFileWindow = new CreateFileWindow();
            if (createFileWindow.ShowDialog() == true)
                filename = createFileWindow.FileName;
            StreamWriter ss = new StreamWriter($@"C:\Users\user\source\repos\2pk2_ArapovAleksej\pz_26\data/{filename}.txt");
            ss.Close();
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter($@"C:\Users\user\source\repos\2pk2_ArapovAleksej\pz_26\data/{filename}.txt");
            sw.WriteLine(textbox1.Text);
            sw.Close();
        }
        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == true)
            {
                textbox1.Text = File.ReadAllText(openFile.FileName);
            }
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (bld)
            {
                textBox.FontWeight = FontWeights.Bold;
            }
            if (ital)
            {
                textBox.FontStyle = FontStyles.Italic;
            }
            if (und)
            {
                textBox.TextDecorations = TextDecorations.Underline;
            }

            textBox.FontWeight = FontWeights.Bold;
        }
        private void italicc(object sender, RoutedEventArgs e)
        {
            if (italic.IsEnabled == true)
                ital = true;
            else if (italic.IsEnabled == false)
                ital = false;
        }
        private void blodd(object sender, RoutedEventArgs e)
        {
            if (blod.IsEnabled == true)
                bld = true;
            else if (blod.IsEnabled == false)
                bld = false;
        }
        private void underr(object sender, RoutedEventArgs e)
        {
            if (under.IsEnabled == true)
                und = true;
            else if (under.IsEnabled == false)
                und = false;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
