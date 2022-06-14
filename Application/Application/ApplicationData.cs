using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public class ApplicationData
    {
        public static List<Maladie> listeMaladies
        {
            get;
            set;
        }

        public static List<CategorieMedicament> listeCategorie
        {
            get;
            set;
        }
        public static List<Medicament> listeMedicaments
        {
            get;
            set;
        }
        public static List<Autorisation> listeAutorisations
        {
            get;
            set;
        }

        public static void loadApplicationData()
        {

            Maladie uneMaladie = new Maladie();
            listeMaladies = uneMaladie.FindAll();
            Medicament unMedicament = new Medicament();
            listeMedicaments = unMedicament.FindAll();
            Autorisation uneAutorisation = new Autorisation();
            listeAutorisations = uneAutorisation.FindAll();
        }
    }
}
