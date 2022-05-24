using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public interface ICrud<T>
    {
        void Create();
        void Read();
        void Update();
        void Delete();
        List<T> FindAll();
        List<T> FindBySelection(string criteres);
    }
}
