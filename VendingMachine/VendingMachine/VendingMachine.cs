using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class VendingMachine
    {
        private List<Product> products = new();
        private int _balance;
        private int _income;
        public int Balance { get { return _balance; } }
        public int Income { get { return _income; } }
        
    }
}
