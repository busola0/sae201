using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public abstract class Typemaladie : ICrud<Typemaladie>
    {
        private int numeroType;
        private string libelleMaladie;

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public List<Typemaladie> FindAll()
        {
            throw new NotImplementedException();
        }

        public List<Typemaladie> FindBySelection(string criteres)
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
