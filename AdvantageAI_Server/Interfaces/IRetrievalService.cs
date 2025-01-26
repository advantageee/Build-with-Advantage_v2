using System.Threading.Tasks;

namespace AdvantageAIWeb.Services.Interfaces
{
    /// <summary>
    /// Interface for retrieving relevant documents based on a search query.
    /// </summary>
    public interface RetrievalIService
    {
        /// <summary>
        /// Retrieves documents relevant to the specified query.
        /// </summary>
        /// <param name="query">The search query to retrieve relevant documents.</param>
        /// <returns>
        /// A task representing the asynchronous operation. The task result contains
        /// the relevant documents as a string.
        /// </returns>
        /// <exception cref="ArgumentException">Thrown if the query is null or empty.</exception>
        Task<string> GetRelevantDocumentsAsync(string query);
    }
}
