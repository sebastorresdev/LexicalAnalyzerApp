namespace LexicalAnalyzer.Contracts;

public interface IRepositoryService
{
    IEnumerable<string> GetRepository(string path);
}
