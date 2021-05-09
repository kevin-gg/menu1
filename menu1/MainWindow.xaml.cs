using System;
using System.Collections.Generic;
using System.IO;
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

namespace menu1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> listaAntipasto = new List<string>();
        List<string> listaPrimo = new List<string>();
        List<string> listaSecondo = new List<string>();
        List<string> listaDolce = new List<string>();
        public MainWindow()
        {

            InitializeComponent();

            

            StreamReader r = new StreamReader("Antipasto.txt");
            StreamReader r1 = new StreamReader("Primo.txt");
            StreamReader r2 = new StreamReader("Secondo.txt");
            StreamReader r3 = new StreamReader("Dolce.txt");

            string line;
            string line1;
            string line2;
            string line3;

            while ((line = r.ReadLine()) != null)
            {

                listaAntipasto.Add(line);
            }
            while ((line1 = r1.ReadLine()) != null)
            {

                listaPrimo.Add(line);
            }
            while ((line2 = r2.ReadLine()) != null)
            {

                listaSecondo.Add(line);
            }
            while ((line3 = r3.ReadLine()) != null)
            {

                listaDolce.Add(line);
            }
        }
        private void cboAntipasto_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string n in listaAntipasto)
            {
                cboAntipasto.Items.Add(n);
            }
        }

        private void cboPrimo_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string n in listaPrimo)
            {
                cboPrimo.Items.Add(n);
            }
        }

        private void cboSecondo_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string n in listaSecondo)
            {
                cboSecondo.Items.Add(n);
            }
        }

        private void cboDolce_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string n in listaDolce)
            {
                cboDolce.Items.Add(n);
            }
        }

        private void btnAggiungi_Click(object sender, RoutedEventArgs e)
        {
            if (cboAntipasto.SelectedIndex != -1)
            {
                lboListaCibo.Items.Add(cboAntipasto.SelectedItem.ToString());
                cboAntipasto.SelectedIndex = -1;
            }
            else if (cboPrimo.SelectedIndex != -1)
            {
                lboListaCibo.Items.Add(cboPrimo.SelectedItem.ToString());
                cboPrimo.SelectedIndex = -1;
            }
            else if (cboSecondo.SelectedIndex != -1)
            {
                lboListaCibo.Items.Add(cboSecondo.SelectedItem.ToString());
                cboSecondo.SelectedIndex = -1;
            }
            else if (cboDolce.SelectedIndex != -1)
            {
                lboListaCibo.Items.Add(cboDolce.SelectedItem.ToString());
                cboDolce.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Devi selezionare un prodotto");
            }
        }

        private void btnRimuovi_Click(object sender, RoutedEventArgs e)
        {
            lboListaCibo.Items.Remove(lboListaCibo.SelectedItem.ToString());
        }
    }
}

