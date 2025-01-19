using Microsoft.Build.Utilities;
using System;
using System.Threading.Tasks;
using WebGrease;
using AdvantageAI.Services;
using Microsoft.Build.Framework;

namespace AdvantageAI.Services
{
    public class RetrievalService
    {
        private readonly IDataRepository _dataRepository; // Injected dependency
        private readonly Logger _logger;
        public RetrievalService(IDataRepository dataRepository, Logger logger)
        {
            _dataRepository = dataRepository ?? throw new ArgumentNullException(nameof(dataRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<string> GetRelevantDocumentsAsync(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                throw new ArgumentException("Query cannot be null or empty.", nameof(query));
            }

            try
            {
                var documents = await _dataRepository.SearchDocumentsAsync(query);
                return documents ?? "No relevant documents found.";
            }
            catch (Exception ex)
            {
                var buildErrorEventArgs = new BuildErrorEventArgs(
                    "Error",
                    "Error fetching relevant documents.",
                    null,
                    0,
                    0,
                    0,
                    0,
                    ex.Message,
                    null,
                    null
                );
                _logger.FormatErrorEvent(buildErrorEventArgs);
                throw;
            }
        }
    }

    public interface IDataRepository
    {
        Task<string> SearchDocumentsAsync(string query);
    }
}
