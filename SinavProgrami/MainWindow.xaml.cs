using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Management.Instrumentation;

namespace SinavProgrami
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Ekle(object sender, RoutedEventArgs e)
        {
            if(radioBolum.IsChecked == true)
            {
                bolumler.Items.Add(new { NAME = EklemeTextBox.Text });
            } 
            else if(radioDers.IsChecked == true)
            {
                dersler.Items.Add(new { NAME = EklemeTextBox.Text });
            }
            else if (radioSinif.IsChecked == true)
            {
                siniflar.Items.Add(new { NAME = EklemeTextBox.Text });
            }
            else
            {
                gorevliler.Items.Add(new { NAME = EklemeTextBox.Text });
            }

            EklemeTextBox.Clear();
        }

        private void DataSil(object sender, RoutedEventArgs e)
        {
            if (bolumler.SelectedItem != null)
            {
                bolumler.Items.Remove(bolumler.SelectedItem);
            }
            else if (dersler.SelectedItem != null)
            {
                dersler.Items.Remove(dersler.SelectedItem);
            }
            else if (siniflar.SelectedItem != null)
            {
                siniflar.Items.Remove(siniflar.SelectedItem);
            }
            else if(gorevliler.SelectedItem != null)
            {
                gorevliler.Items.Remove(gorevliler.SelectedItem);
            }
        }

        private void TextBox_Sil(object sender, RoutedEventArgs e)
        {
            EklemeTextBox.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Page1 page = new Page1();
            this.Content = page;
        }
    }
}
