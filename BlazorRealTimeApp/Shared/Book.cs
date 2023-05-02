using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorRealTimeApp.Shared
{
    public class Book
    {
        public string Id { get; set; } = string.Empty;
        public string Isbn { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public double Price { get; set; } = 0.0;
    }
}
