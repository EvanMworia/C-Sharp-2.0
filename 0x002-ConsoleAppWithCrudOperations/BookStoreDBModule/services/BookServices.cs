using BookStoreRemastered.models;
using BookStoreRemastered.services.IServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreRemastered.services
{
    public class BookServices : IBook
    {

        private readonly HttpClient _httpClient;
        private readonly string _URL = "http://localhost:3000/products";


        public BookServices()
        {
            _httpClient = new HttpClient();
        }
        public Task<bool> CreateBook(AddBook newBook)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Book>> GetAllBooks()
        {
            var response = await _httpClient.GetAsync(_URL);
            var content = await response.Content.ReadAsStringAsync();
            var books = JsonConvert
        }
    }
}
