namespace Trestlebridge.Interfaces
{
    public interface IChicken : IFeatherProducing, IEggsProducing, IMeatProducing
    {
        string Type { get; }
    }

}