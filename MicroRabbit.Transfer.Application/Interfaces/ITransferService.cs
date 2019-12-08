using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Application.Interfaces
{
    public interface ITransferService
    {
        Task<IEnumerable<TransferLog>> GetTransferLogs();
    }
}
