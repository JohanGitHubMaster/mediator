using MediatR;

namespace Mediator.MediatorSetting
{
    public class CreerRessourceCommandeHandler : IRequestHandler<CreerRessourceCommande, ResultatCommande>
    {
        public async Task<ResultatCommande> Handle(CreerRessourceCommande request, CancellationToken cancellationToken)
        {
            // Logique de gestion de la commande
            // ...
            var resultat = new ResultatCommande
            {
                Succes = true,
                Message = $"Ressource '{request.Nom}' créée avec succès."
            };

            return resultat;

            
        }
    }

    public class ObtenirInfoRessourceRequeteHandler : IRequestHandler<ObtenirInfoRessourceRequete, ResultatRequete>
    {
        public async Task<ResultatRequete> Handle(ObtenirInfoRessourceRequete request, CancellationToken cancellationToken)
        {
            // Logique de gestion de la requête
            // ...

            var resultat = new ResultatRequete
            {
                Info = $"Informations de la ressource avec l'ID {request.Id}."
            };

            return resultat;
        }
    }
}
