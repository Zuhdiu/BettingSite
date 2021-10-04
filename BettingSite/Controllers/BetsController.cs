using BettingSite.Models;
using BettingSite.Repositories;
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
    public class BetsController : ControllerBase
    {
        private readonly IBetsRepository _betsRepository;

        public BetsController(IBetsRepository betsRepository)
        {
            _betsRepository = betsRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Bets>> GetBets()
        {
            return await _betsRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Bets>> GetBets(int id)
        {
            return await _betsRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Bets>> PostBets([FromBody] Bets bets)
        {
            var newBets = await _betsRepository.Create(bets);
            return CreatedAtAction(nameof(GetBets), new { id = bets.ID }, newBets);
        }

        [HttpPut]
        public async Task<ActionResult> PutBets(int id, [FromBody] Bets bets)
        {
            if (id != bets.ID)
            {
                return BadRequest();
            }

            await _betsRepository.Update(bets);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var betToDelete = await _betsRepository.Get(id);
            if (betToDelete == null)
                return NotFound();

            await _betsRepository.Delete(betToDelete.ID);
            return NoContent();
        }
    }
}
