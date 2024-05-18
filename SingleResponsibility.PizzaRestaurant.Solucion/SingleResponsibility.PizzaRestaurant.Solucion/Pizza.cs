using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.PizzaRestaurant.Solucion
{
    public class Pizza
    {
        public List<string> Ingredientes { get; set; }
        public string Tipo { get; set; }

        public Pizza()
        {
            this.Ingredientes = new List<string>();
        }
    }
}
