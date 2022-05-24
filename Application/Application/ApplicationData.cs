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
        public static List<Typemaladie> listeTypeMaladie
        {
            get;
            set;
        }
        public static void loadApplicationData()
        {
            //chargement des tables
            //Eleve unEleve = new Eleve();
            //Professeur unProfesseur = new Professeur();
            Autorisation uneAutorisation = new Autorisation();
            //EstNote unEstNote = new EstNote();
            //listeEleves = unEleve.FindAll();
            //listeProfesseurs = unProfesseur.FindAll();
            listeAutorisations = uneAutorisation.FindAll();
            //listeEstNotes = unEstNote.FindAll();
            //mapping des relations en mode déconnecté
            //relation bi-directionnelle entre eleve et groupe
            
        //relation eleve -> note
        //relation note -> professeur
        }
    }
}
