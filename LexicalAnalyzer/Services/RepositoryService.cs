using LexicalAnalyzer.Contracts;

namespace LexicalAnalyzer.Services
{
    public class RepositoryService : IRepositoryService
    {
        public IEnumerable<string> GetRepository(string path)
        {
            return File.ReadAllLines(path).ToList();
        }
    }
}
