using Mediator.MediatorSetting;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Mediator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RessourceController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RessourceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreerRessource([FromBody] CreerRessourceCommande commande)
        {
            var resultatCommande = await _mediator.Send(commande);
            // Traitement du résultat
            return Ok(resultatCommande);
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        public async Task<IActionResult> ObtenirInfoRessource(int id)
        {
            var requete = new ObtenirInfoRessourceRequete { Id = id };
            var resultatRequete = await _mediator.Send(requete);
            // Traitement du résultat
            return Ok(resultatRequete);
        }
    }
}
