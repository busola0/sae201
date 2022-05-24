using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Application 
{
    public class Autorisation : ICrud<Autorisation>
    {
        public System.Collections.ArrayList medicament;

        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.ArrayList GetMedicament()
        {
            if (medicament == null)
                medicament = new System.Collections.ArrayList();
            return medicament;
        }

        /// <pdGenerated>default setter</pdGenerated>
        public void SetMedicament(System.Collections.ArrayList newMedicament)
        {
            RemoveAllMedicament();
            foreach (Medicament oMedicament in newMedicament)
                AddMedicament(oMedicament);
        }

        /// <pdGenerated>default Add</pdGenerated>
        public void AddMedicament(Medicament newMedicament)
        {
            if (newMedicament == null)
                return;
            if (this.medicament == null)
                this.medicament = new System.Collections.ArrayList();
            if (!this.medicament.Contains(newMedicament))
                this.medicament.Add(newMedicament);
        }

        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveMedicament(Medicament oldMedicament)
        {
            if (oldMedicament == null)
                return;
            if (this.medicament != null)
                if (this.medicament.Contains(oldMedicament))
                    this.medicament.Remove(oldMedicament);
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllMedicament()
        {
            if (medicament != null)
                medicament.Clear();
        }
        public System.Collections.ArrayList maladie;

        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.ArrayList GetMaladie()
        {
            if (maladie == null)
                maladie = new System.Collections.ArrayList();
            return maladie;
        }

        /// <pdGenerated>default setter</pdGenerated>
        public void SetMaladie(System.Collections.ArrayList newMaladie)
        {
            RemoveAllMaladie();
            foreach (Maladie oMaladie in newMaladie)
                AddMaladie(oMaladie);
        }

        /// <pdGenerated>default Add</pdGenerated>
        public void AddMaladie(Maladie newMaladie)
        {
            if (newMaladie == null)
                return;
            if (this.maladie == null)
                this.maladie = new System.Collections.ArrayList();
            if (!this.maladie.Contains(newMaladie))
                this.maladie.Add(newMaladie);
        }

        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveMaladie(Maladie oldMaladie)
        {
            if (oldMaladie == null)
                return;
            if (this.maladie != null)
                if (this.maladie.Contains(oldMaladie))
                    this.maladie.Remove(oldMaladie);
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllMaladie()
        {
            if (maladie != null)
                maladie.Clear();
        }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
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
                    reader = access.getData("select * from dbo.Groupe;");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Autorisation uneAutorisation = new Autorisation();
                            uneAutorisation.uneMaladie = reader.GetFieldValue<Maladie>(0);
                            uneAutorisation.unMedicament = reader.GetFieldValue<Medicament>(1);
                            uneAutorisation.dateAutorisation = reader.GetDateTime(2);
                            uneAutorisation.commentaire = reader.GetString(3);
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

        private Maladie uneMaladie;
        private Medicament unMedicament;
        private DateTime dateAutorisation;
        private string commentaire;

    }

}
