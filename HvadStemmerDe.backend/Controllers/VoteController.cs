using HvadStemmerDe.backend.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HvadStemmerDe.backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoteController : ControllerBase
    {

        private readonly IVoteService _voteservice;
        public VoteController(IVoteService voteService)
        {
            _voteservice = voteService;
        }

    }
}
