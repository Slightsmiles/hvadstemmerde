using HvadStemmerDe.backend.Application.DTOs;

namespace HvadStemmerDe.Application.Interfaces
{
    public interface IVoteService
    {
        Task<IEnumerable<VoteDto>> GetVotesAsync();
    }
}