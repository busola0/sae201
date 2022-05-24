using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public class Medicament : ICrud<Medicament>
    {
        public CategorieMedicament categorieMedicament;

        private int numero;
        private string nom;
        private CategorieMedicament categorie;

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
            throw new NotImplementedException();
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
