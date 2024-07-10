using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._03___InterfaceVsImplementacao
{
    public interface IRepositorio
    {
        void Adicionar();
    }

    public class Repositorio : IRepositorio
    {
        public void Adicionar()
        {
            throw new NotImplementedException();
        }
    }

    public class RepositorioFake : IRepositorio
    {
        public void Adicionar()
        {
            throw new NotImplementedException();
        }
    }

    public class UsoImplementacao : IRepositorio
    {
        public void Adicionar()
        {
            var rep = new Repositorio();
            rep.Adicionar();    
        }
    }

    public class UsoAbstracao
    {
        private readonly IRepositorio _repositorio;

        public UsoAbstracao(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Processo()
        {
            _repositorio.Adicionar();
        }
    }

}
