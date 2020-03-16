namespace Trestlebridge.Interfaces
{
    public interface IDuck : IFeatherProducing, IEggsProducing, IMeatProducing
    {
        string Type { get; }
    }

}