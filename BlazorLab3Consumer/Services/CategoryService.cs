using System.Net.Http.Json;
using System.Runtime.InteropServices;

namespace BlazorLab3Consumer.Services
{
    public class CategoryService : IGenServices<Category>
    {
        HttpClient httpClient;
        public CategoryService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        // DELETE: api/Categories/5 
        public async Task Delete(int id)
        {
            await httpClient.DeleteAsync($"/api/Categories/{id}");
        }

        //  // GET: api/Categories/5
        public async Task<Category> Get(int id)
        { 
            return await httpClient.GetFromJsonAsync<Category>($"/api/Categories/{id}");
        }

        public async Task<List<Category>> GetAll()
        {
            return await httpClient.GetFromJsonAsync<List<Category>>("/api/Categories");
        }

        public async Task Insert(Category obj)
        {
            await httpClient.PostAsJsonAsync<Category>("/api/Categories", obj);
        }

        public async Task Update(int id, Category obj)
        {
            await httpClient.PutAsJsonAsync<Category>($"/api/Categories/{id}", obj);
        }
    }
}
