using MSA.Rabbit.Client.Models.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MSA.Rabbit.Client.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient _httpClient;
        private string uri  = "https://localhost:5001/api/Banking";

        public TransferService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task Transfer(TransferDto transferDto)
        {
            var transferContent = new StringContent(JsonConvert.SerializeObject(transferDto),
                                                       Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(uri, transferContent);
            response.EnsureSuccessStatusCode();
        }
    }
}
