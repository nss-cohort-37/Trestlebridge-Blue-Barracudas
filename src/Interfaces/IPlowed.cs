namespace Trestlebridge.Interfaces
{
    public interface IPlowed : ISeedProducing, IProcess
    {
        string Type { get; }


    }
}