using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System
{
    internal class Medicine
    {
        public int ID;
        public string Name;
        public string Company;
        public int Quantity;
        public string ExpireDate;
        public int Price;
       

        public Medicine(int ID,string Name, string Company,  int Quantity,string ExpireDate,int Price)
        {
            this.ID = ID; 
            this.Name = Name;
            this.Company = Company;
            this.Quantity = Quantity;
            this.ExpireDate = ExpireDate;
            this.Price = Price;
            
            
        }

        public string history()
        {
            return this.ID.ToString() + "\t" + this.Name;
        }

    }
}
