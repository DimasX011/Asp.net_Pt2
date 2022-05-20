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

        public string _record { get; set; }

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

        public string record
        {
            get => _record;
            set => _record = value;
        }

        internal Contract(long _id, string _name, long customerId)
        {
            id = _id;
            name = _name;
            _customerId = customerId;
        }

        public Contract() { }

        public Contract(string record)
        {
            _record = record;
        }


    }

    public class ContractFactory
    {
        public Contract Create(long id, string name, long customerId) => new Contract(id, name, customerId);

        public Contract IncludeSheets(string record) => new Contract(record);

    }
}
