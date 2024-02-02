using System.Diagnostics;
using JobScribe_stranger_strings.Model;
using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System.Net;
using JobScribe_stranger_strings.Contracts;
using JsonSerializer = System.Text.Json.JsonSerializer;


public class Tests
    {
        private HttpClient _client;

        [SetUp]
        public void Setup()
        {
           
            var factory = new WebApplicationFactory<Program>();
            string connectionString = "Server=localhost,1434;Database=JobScribe;User Id=sa;Password=yourStrong(!)Password;Encrypt=false;";
            Environment.SetEnvironmentVariable("CONNECTION_STRING", connectionString);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

           
            _client = factory.CreateClient();

            AuthRequest authRequest = new AuthRequest("user@user.com", "user123");
            var jsonString = JsonSerializer.Serialize(authRequest);
            var jsonStringContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = _client.PostAsync("http://localhost:5225/api/Auth/UserAuthenticate", jsonStringContent).Result;
            var content = response.Content.ReadAsStringAsync().Result;
            var desContent = JsonSerializer.Deserialize<AuthResponse>(content,options);
            var token = desContent.Token;
            _client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
        }
        [Test]
        public async Task GetCompanyAsync_CompanyData()
        {
            // Arrange
            
            var companyName = "CodeCool";

            // Act
            var response = await _client.GetAsync($"http://localhost:5225/api/Company/GetCompanyByName?companyName={companyName}");

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            
            var responseContent = await response.Content.ReadAsStringAsync();
            var companyData = JsonConvert.DeserializeObject<Company>(responseContent);
            
            //Assert.NotNull(companyData);
            Assert.AreEqual(companyName, companyData.Name);
        }
        
        [Test]
        public async Task GetCompanyAsync_ReturnsNotFoundForInvalidCompany()
        {

            var companyName = "Aba";
            
            var response = await _client.GetAsync($"http://localhost:5225/api/Company/GetCompanyByName?companyName=${companyName}");
        
            
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.NotFound));
            
        }
        
        [Test]
        public async Task CreateCompany_ReturnsCreatedResponse()
        {
            // Arrange
            //delete Company if exist
            var newCompany = new Company
            {
                Name = "Hays",
                Location = "London",
                Industry = "Consulting",
                Founded = 1994,
                Description = "International consulting company"
            };
        
            var jsonString = JsonSerializer.Serialize(newCompany);
            var jsonStringContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
        
            // Act
            var response = await _client.PostAsync("http://localhost:5225/api/Company/AddCompany", jsonStringContent);
        
            // Assert
            response.EnsureSuccessStatusCode(); 
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }


    }