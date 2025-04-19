using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsStore.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }
        public ImportedProduct() 
        { 
        }

        public ImportedProduct(string name, double price, double customsfee) : base(name, price) 
        { 
            CustomsFee = customsfee;
        }

        public double TotalPrice()
        {
            return CustomsFee + Price;
        }

        public override string PriceTag()
        {
            return Name + " $" + TotalPrice() + $" (Customs fee: ${CustomsFee})";
        }
    }
}
