using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheets.Controllers.Models
{
    public class PaySlip
    {
        private Object Type;

        private DateTime TimePay;

        private String Record;

        public Object type
        {
            get => Type;
            set => Type = value;
        }
        public DateTime time
        {
            get => TimePay;
            set => TimePay = value;
        }

        public String record
        {
            get => Record;
            set => Record = value;
        }

        public PaySlip(Object paySlip, DateTime time, String record)
        {
            Type = paySlip;
            TimePay = time;
            Record = record;
        }

        public PaySlip(Object paySlip, String record)
        {
            Type = paySlip;
            TimePay = DateTime.UtcNow;
            Record = record;
        }

        internal PaySlip() { }

        public void Create(String record, Object obj)
        {
            new PaySlip() { Type = obj, Record = record, TimePay = DateTime.UtcNow };
        }

        public void UdpateInformation(string record)
        {
            Record = record;
        }

    }

    public class PaySlipFactory
    {
        PaySlip slip;

        public void Create(string record, Object obj) => slip.Create(record, obj);

        public void UpdateInformation(string record) => slip.UdpateInformation(record);
    }
}
