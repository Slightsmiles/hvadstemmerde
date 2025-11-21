using HvadStemmerDe.backend.Application.DTOs;

namespace HvadStemmerDe.backend.Application.Interfaces
{
    public interface IVoteService
    {
        Task<IEnumerable<VoteDto>> GetVotesAsync();
    }
}