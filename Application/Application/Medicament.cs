using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Application
{
    public class Medicament : ICrud<Medicament>
    {

        public int numero
        {
            get; set;

        }

        public string libelleMedicament
        {
            get; set;

        }


        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public List<Medicament> FindAll()
        {
            List<Medicament> listeMedicament = new List<Medicament>();
            DataAccess access = new DataAccess();
            SqlDataReader reader;
            try
            {
                if (access.openConnection())
                {
                    reader = access.getData("select * from MEDICAMENT;");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Medicament unMedicament = new Medicament();
                            unMedicament.numero = reader.GetInt32(0);
                            unMedicament.libelleMedicament = reader.GetString(2);
                            listeMedicament.Add(unMedicament);
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
            return listeMedicament;
        }

        public List<Medicament> FindBySelection(string criteres)
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
    }

}
