namespace Mediator.MediatorSetting
{
    // Classe pour représenter le résultat d'une commande
    public class ResultatCommande
    {
        // Propriétés du résultat de la commande
        public bool Succes { get; set; }
        public string Message { get; set; }
    }

    // Classe pour représenter le résultat d'une requête
    public class ResultatRequete
    {
        // Propriétés du résultat de la requête
        public string Info { get; set; }
    }
}
