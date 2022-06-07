using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    using System;
    using System.Data.SqlClient;

    public class Maladie : ICrud<Maladie>
    {
        
        public int numero
        {
            get;set;

        }

        public string libelleMaladie
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

        public List<Maladie> FindAll()
        {
            List<Maladie> listeMaladie = new List<Maladie>();
            DataAccess access = new DataAccess();
            SqlDataReader reader;
            try
            {
                if (access.openConnection())
                {
                    reader = access.getData("select * from MALADIE;");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Maladie uneMaladie = new Maladie();
                            uneMaladie.numero = reader.GetInt32(0);
                            uneMaladie.libelleMaladie = reader.GetString(1);
                            listeMaladie.Add(uneMaladie);
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
            return listeMaladie;
        }

        public List<Maladie> FindBySelection(string criteres)
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
