using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSA.Rabbit.Client.Models
{
    public class TransferViewModel
    {
        public string TransferNotes { get; set; }
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public decimal TransferAmount { get; set; }
    }
}
