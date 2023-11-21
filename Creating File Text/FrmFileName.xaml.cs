using Microsoft.Win32;
using System;
using System.Windows;

namespace Creating_File_Text
{
    public partial class FrmFileName : Window
    {        
        public static string SetFileName;

        public FrmFileName()
        {
            InitializeComponent();
        }

        private void BtnOkay_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtFileName.Text))
            {
                MessageBox.Show("Plese Enter A File Name!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                Console.WriteLine("File Name Is Required");
            }
            else
            {
                MessageBox.Show("Your Text File Has Been Save And The File Location Is In Your Documents", "Save Path", MessageBoxButton.OK, MessageBoxImage.Information);
                string fileName = TxtFileName.Text;
                SetFileName = fileName + ".txt";
                this.Close();

               //This Is For The Challenge
                FrmRegistration fr = new FrmRegistration();
                fr.Show();
            }
        }

    }
}
