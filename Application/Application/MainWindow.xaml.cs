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

namespace Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            listViewMaladie.ItemsSource = ApplicationData.listeMaladies;
            listViewMedicament.ItemsSource = ApplicationData.listeMedicaments;
            dataGridAuto.ItemsSource = ApplicationData.listeAutorisations;

        }

        private void AjoutAutorisation(object sender, RoutedEventArgs e)
        {
            Autorisation newAutorisaition = new Autorisation();
            newAutorisaition.idMaladie= ((Maladie)listViewMaladie.SelectedValue).numero;
            newAutorisaition.idMedicament = ((Medicament)listViewMedicament.SelectedValue).numero;
            newAutorisaition.date = calendrier.SelectedDate.Value.Date.ToShortDateString(); ;
            newAutorisaition.commentaire = commentaire.Text;

            newAutorisaition.Create();
            ApplicationData.loadApplicationData();
            dataGridAuto.ItemsSource = ApplicationData.listeAutorisations;
        }

        private void DelAutorisation(object sender, RoutedEventArgs e)
        {
            Autorisation auto = (Autorisation)dataGridAuto.SelectedItem;
            auto.Delete();


        }

    }
}
