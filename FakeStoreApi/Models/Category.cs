using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeStoreApi.Models
{
    /// <summary>
    /// Entidad categoria relacionada con un producto
    /// </summary>
    internal class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public DateTime creationAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
