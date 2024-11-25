using DataBaseModel.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using RepositoryModel;
using RepositoryModel.IRepository;
using RepositoryModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseModel
{
    public class UnitOFWork : IUnitOFWork
    {
        private readonly ApplicationDbContext context;

 
        public IDatabaseRepository<Unit> Units { get; private set; }
    
        public UnitOFWork(ApplicationDbContext context)
        {
             this.context = context;
        }

        public int Compelet()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }


    }
}
