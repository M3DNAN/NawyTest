﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryModel.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string ProfilePicture {  get; set; } 

        public int NationalId { get; set; }

        public ICollection<CompanyTransaction> CompanyInstallments { get; set; } = new List<CompanyTransaction>();
        public ICollection<SharesTransaction> SharesTransactionS { get; set; }=new List<SharesTransaction>();


    }
}