using MSA.Rabbit.Client.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSA.Rabbit.Client.Services
{
    public interface ITransferService
    {
        Task Transfer(TransferDto transferDto);
    }
}
