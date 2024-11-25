using RepositoryModel.IRepository;
using RepositoryModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryModel
{
    public interface IUnitOFWork : IDisposable
    {
        IDatabaseRepository<Unit> Units { get; }
        int Compelet();
        void Dispose();
    }
}
