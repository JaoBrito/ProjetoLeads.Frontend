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

        public async Task<List<LeadModel>> GetLeadAsync( )
        {
            return await _httpClient.GetFromJsonAsync<List<LeadModel>>( "api/leads" );
        }

        public async Task<LeadModel> GetLeadByIdAsync( int id )
        {
            return await _httpClient.GetFromJsonAsync<LeadModel>( $"api/leads/{id}" );
        }

        public async Task<LeadModel> CreateLeadAsync( LeadModel lead )
        {
            var response = await _httpClient.PostAsJsonAsync( "api/leads", lead );

            if ( response.IsSuccessStatusCode )
            {
                return await response.Content.ReadFromJsonAsync<LeadModel>();
            }

            return null;
        }

        public async Task<bool> UpdateLeadAsync( int id, LeadModel lead )
        {
            var response = await _httpClient.PutAsJsonAsync( $"api/leads/{id}", lead );
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteLeadAsync( int id )
        {
            var response = await _httpClient.DeleteAsync( $"api/leads/{id}" );
            return response.IsSuccessStatusCode;
        }
    }
}
