using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace vestaabnerMonqo.Models
{
    public class BookDataBaseSetting : IBookDataBaseSetting
    {
        public string ShelveCollectionName { get ; set ; }
        public string BookCollectionName { get ; set ; }
        public string LibreryCollectionName { get ; set ; }
        public string UserCollectionName { get ; set ; }
        public string ConnectionString { get ; set ; }
        public string DatabaseName { get ; set ; }
    }
    public interface IBookDataBaseSetting
    {
        string ShelveCollectionName { get; set; }
        string BookCollectionName { get; set; }
        string LibreryCollectionName { get; set; }
        string UserCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }

}