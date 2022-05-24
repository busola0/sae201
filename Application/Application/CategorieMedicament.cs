using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public abstract class CategorieMedicament :ICrud<CategorieMedicament>
    {
        private int numero;
        private string nom;

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public List<CategorieMedicament> FindAll()
        {
            throw new NotImplementedException();
        }

        public List<CategorieMedicament> FindBySelection(string criteres)
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
