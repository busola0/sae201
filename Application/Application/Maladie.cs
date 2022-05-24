using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    using System;

    public class Maladie : ICrud<Maladie>
    {
        public Typemaladie typemaladie;

        private int numero;
        private string libelle;

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
            throw new NotImplementedException();
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
