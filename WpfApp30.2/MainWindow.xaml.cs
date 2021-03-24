using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace WpfApp30._2
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

        private CommissieWerker commissieWerker;
        private StukWerker stukWerker;
        private UurWerker uurWerker;
        private Werknemer werknemer;
        private List<Werknemer> mijnWerknemers = new List<Werknemer>();

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            rbWerknemer.IsChecked = true;
        }

        private void rbCommissiewerker_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                txtAantal.IsEnabled = true;
                txtCommissie.IsEnabled = true;
                txtbAantal.Text = "Aantal";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbStukwerker_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                txtAantal.IsEnabled = true;
                txtCommissie.IsEnabled = false;
                txtbAantal.Text = "Aantal";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbUurweker_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                txtCommissie.IsEnabled = false;
                txtAantal.IsEnabled = true;
                txtbAantal.Text = "Aantal uren";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbWerknemer_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                txtCommissie.IsEnabled = false;
                txtAantal.IsEnabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (rbWerknemer.IsChecked != null && (bool)rbWerknemer.IsChecked)
                {
                    werknemer = new Werknemer(txtNaam.Text, txtVoornaam.Text, decimal.Parse(txtLoon.Text));
                    mijnWerknemers.Add(werknemer);
                    RefreshListbox();
                }
                else if (rbCommissiewerker.IsChecked != null && (bool)rbCommissiewerker.IsChecked)
                {
                    commissieWerker = new CommissieWerker(txtNaam.Text, txtVoornaam.Text, decimal.Parse(txtLoon.Text),
                        decimal.Parse(txtCommissie.Text), int.Parse(txtAantal.Text));
                    mijnWerknemers.Add(commissieWerker);
                    RefreshListbox();
                }
                else if (rbStukwerker.IsChecked != null && (bool)rbStukwerker.IsChecked)
                {
                    stukWerker = new StukWerker(txtNaam.Text, txtVoornaam.Text, decimal.Parse(txtLoon.Text),
                        int.Parse(txtAantal.Text));
                    mijnWerknemers.Add(stukWerker);
                    RefreshListbox();
                }
                else if (rbUurweker.IsChecked != null && (bool)rbUurweker.IsChecked)
                {
                    uurWerker = new UurWerker(txtNaam.Text, txtVoornaam.Text, decimal.Parse(txtLoon.Text),
                    int.Parse(txtAantal.Text));
                    mijnWerknemers.Add(uurWerker);
                    RefreshListbox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshListbox()
        {
            lbWerknemer.ItemsSource = null;
            lbWerknemer.ItemsSource = mijnWerknemers;
        }

        private void rbtnNaam_Checked(object sender, RoutedEventArgs e)
        {

            mijnWerknemers.Sort(new VolledigeNaamComparer());
            lbWerknemer.Items.Refresh();
        }

        private void rbtnVerdiensten_Checked(object sender, RoutedEventArgs e)
        {
            mijnWerknemers.Sort(new VerdienstenComparer());
            lbWerknemer.Items.Refresh();
        }
    }
}
