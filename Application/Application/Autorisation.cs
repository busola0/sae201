using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Application 
{
    public class Autorisation : ICrud<Autorisation>
    {
        public System.Collections.ArrayList medicament;


        public void Create()
        {
            DataAccess access = new DataAccess();
            access.openConnection();
            access.setData($"INSERT INTO EST_AUTORISE(nummaladie,nummedicament, dateautorisation, commentaire) VALUES({idMaladie},{idMedicament}, '{this.date}', '{this.commentaire}')");
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            DataAccess access = new DataAccess();
            access.openConnection();
        }

        public void Delete()
        {
            DataAccess access = new DataAccess();
            access.openConnection();
            access.setData($"Delete from est_autorise where nummaladie = {idMaladie} AND nummedicament = {idMedicament} AND dateautorisation = '{this.date}'");
        }

        public List<Autorisation> FindAll()
        {


            List<Autorisation> listeAutotisations = new List<Autorisation>();
            DataAccess access = new DataAccess();
            SqlDataReader reader;
            try
            {
                if (access.openConnection())
                {
                    reader = access.getData("select ma.nummaladie, me.nummedicament, nomMedicament, libelleMaladie, dateautorisation, commentaire from est_autorise e join maladie ma on e.nummaladie = ma.nummaladie join medicament me on e.nummedicament = me.nummedicament");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Autorisation uneAutorisation = new Autorisation();
                            uneAutorisation.nomMedicament = reader.GetString(2);
                            uneAutorisation.libelleMaladie = reader.GetString(3);
                            uneAutorisation.date = ((DateTime)reader.GetDateTime(4)).ToShortDateString();
                            uneAutorisation.commentaire = reader.GetString(5);
                            uneAutorisation.idMaladie = reader.GetInt32(0);
                            uneAutorisation.idMedicament = reader.GetInt32(1);
                            listeAutotisations.Add(uneAutorisation);
                            
                           
                        }
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("No rows found.", "Important Message");
                    }
                    reader.Close();
                    access.closeConnection();
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Important Message");
            }
            return listeAutotisations;
        }

        public List<Autorisation> FindBySelection(string criteres)
        {
            throw new NotImplementedException();
        }

        public string libelleMaladie
        {
            get; set;

        }

        public string nomMedicament
        {
            get; set;

        }
        public string date
        {
            get; set;

        }

        public string commentaire
        {
            get; set;

        }
        public int idMaladie
        {
            get;set;
        }
        public int idMedicament
        {
            get;set;
        }

    }

}
