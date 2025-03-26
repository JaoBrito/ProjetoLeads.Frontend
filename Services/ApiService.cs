using ProjetoLeads.Frontend.Models;
using System.Net.Http.Json;

namespace ProjetoLeads.Frontend.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService( HttpClient httpClient )
        {
            _httpClient = httpClient;
        }

        public async Task<List<LeadModel>> GetDadosAsync( )
        {
            return await _httpClient.GetFromJsonAsync<List<LeadModel>>( "api/leads" );
        }
    }
}
