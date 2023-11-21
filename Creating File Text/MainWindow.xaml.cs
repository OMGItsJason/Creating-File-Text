using System;
using System.IO;
using System.Windows;

namespace Creating_File_Text
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtInput.Text))
            {
                MessageBox.Show("Please Input!", "Warning",MessageBoxButton.OK,MessageBoxImage.Warning);
                Console.WriteLine("Input Is Required");
            }
            else
            {
            FrmFileName Fn = new FrmFileName();
            Fn.ShowDialog();
            string getInput;
            getInput = TxtInput.Text;
            
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(System.IO.Path.Combine(docPath, FrmFileName.SetFileName)))
            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);
            }
            }

        }
    }
}
