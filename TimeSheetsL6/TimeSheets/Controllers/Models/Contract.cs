using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheets.Controllers.Models
{
    public class Contract
    {
        public long id { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        private long _customerId;

        public long Id
        {
            get => id;
            set => id = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public long CustomerId
        {
            get => _customerId;
            set => _customerId = value;
        }

        internal Contract(long _id, string _name, long customerId)
        {
            id = _id;
            name = _name;
            _customerId = customerId;
        }

        public Contract() { }

    }

    public class ContractFactory
    {
        public Contract Create(long id, string name, long customerId) => new Contract(id, name, customerId);
    }
}
