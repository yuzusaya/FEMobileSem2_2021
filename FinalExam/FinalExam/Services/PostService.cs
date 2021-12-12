using FinalExam.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Services
{
    public class PostService
    {
        const string url = "https://jsonplaceholder.typicode.com/posts";
        HttpClient Client = new HttpClient();
        public async Task<List<PostRecord>> GetAllPosts()
        {
            var result = await Client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<PostRecord>>(content);
        }

        public async Task<bool> SavePost(PostRecord record)
        {
            var itemJson = JsonConvert.SerializeObject(record);
            var content = new StringContent(itemJson, Encoding.UTF8, "application/json");
            HttpResponseMessage response;
            if (record.Id == 0)
            {
                response = await Client.PostAsync(url,content);
            }
            else
            {
                response = await Client.PutAsync($"{url}/{record.Id}",content);
            }
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeletePost(PostRecord record)
        {
            var resposne = await Client.DeleteAsync($"{url}/{record.Id}");
            return resposne.IsSuccessStatusCode;
        }
    }
}
