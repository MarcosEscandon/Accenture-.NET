using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PhotoSharingApplication.Models;


namespace PhotoSharingApplication.Data
{
    public class PhotoDBContext : DbContext 
    {
        public PhotoDBContext() : base("keyPhotoDB") { }

        public DbSet<Photo> Photos { get; set; }

    }
}