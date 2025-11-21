using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HvadStemmerDe.backend.Application.DTOs;
using HvadStemmerDe.backend.Application.Interfaces;
namespace HvadStemmerDe.backend.Application.Services
{
    public class VoteService
    {
        private readonly HttpClient _http;
        public VoteService(HttpClient http)
        {
            _http = http;
        }

        Task<IEnumerable<VoteDto>> GetVotesAsync()
        {
            throw new NotImplementedException();

        }
    }
}