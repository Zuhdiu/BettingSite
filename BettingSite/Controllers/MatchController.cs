using BettingSite.Interfaces;
using BettingSite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        private readonly IMatchRepository _matchRepository;

        public MatchController(IMatchRepository matchRepository)
        {
            _matchRepository = matchRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Match>> GetMatches()
        {
            return await _matchRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Match>> GetMatches(int id)
        {
            return await _matchRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Match>> PostMatches([FromBody] Match match)
        {
            var newMatch = await _matchRepository.Create(match);
            return CreatedAtAction(nameof(GetMatches), new { id = match.Id}, newMatch);
        }

        [HttpPut]
        public async Task<ActionResult> PutMatches(int id, [FromBody] Match match)
        {
            if (id != match.Id)
            {
                return BadRequest();
            }

            await _matchRepository.Update(match);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var matchtoDelete = await _matchRepository.Get(id);
            if (matchtoDelete == null)
                return NotFound();

            await _matchRepository.Delete(matchtoDelete.Id);
            return NoContent();
        }
    }
}
