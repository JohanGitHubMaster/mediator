using MediatR;

namespace Mediator.MediatorSetting
{
    public class CreerRessourceCommande : IRequest<ResultatCommande>
    {
        // Propriétés de la commande
        public string Nom { get; set; }
    }

    public class ObtenirInfoRessourceRequete : IRequest<ResultatRequete>
    {
        // Propriétés de la requête
        public int Id { get; set; }
    }
}
