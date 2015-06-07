namespace BusinessLayer.Contracts.First
{
    public interface ITemplateToSearch
    {
        int NumberOfSymbols { get; set; }
        char Symbol { get; set; }
    }
}