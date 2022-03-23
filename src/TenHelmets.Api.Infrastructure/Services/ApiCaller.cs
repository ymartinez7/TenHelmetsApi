using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TenHelmets.API.Core.DTOs;

namespace TenHelmets.API.Infrastructure.Services
{
    public static class ApiCaller
    {
        public static async Task<ResponseDTO> GetToken(string endpoint, 
            string credentials)
        {
            ResponseDTO apiResponse;

            using (var client = new HttpClient())
            {
                try
                {
                    var request = JsonConvert.SerializeObject(credentials);
                    var content = new StringContent(request, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync(endpoint, content);

                    if (!response.IsSuccessStatusCode)
                    {
                        apiResponse = new ResponseDTO(false, 
                            response.StatusCode.ToString(), 
                            null);
                    }
                    else
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        var objectResult = JsonConvert.DeserializeObject<string>(result);

                        apiResponse = new ResponseDTO(true, 
                            "OK", 
                            objectResult);
                    }
                }
                catch (Exception ex)
                {
                    apiResponse = new ResponseDTO(false, 
                        ex.Message, 
                        null);
                }
            }
            return apiResponse;
        }

        public static async Task<ResponseDTO> Get<T>(string endpoint, 
            string token)
        {
            ResponseDTO apiResponse;

            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    var response = await client.GetAsync(endpoint);

                    if (!response.IsSuccessStatusCode)
                    {
                        apiResponse = new ResponseDTO(false, 
                            response.StatusCode.ToString(), 
                            null);
                    }
                    else
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        var objectResult = JsonConvert.DeserializeObject<T>(result);

                        apiResponse = new ResponseDTO(true, 
                            "OK", 
                            objectResult);
                    }
                }
                catch (Exception ex)
                {
                    apiResponse = new ResponseDTO(false, ex.Message, null);
                }
            }
            return apiResponse;
        }

        public static async Task<ResponseDTO> PostAsync<T>(string endpoint, 
            string token, 
            T model)
        {
            ResponseDTO apiResponse;

            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    var request = JsonConvert.SerializeObject(model);
                    var content = new StringContent(request, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync(endpoint, content);

                    if (!response.IsSuccessStatusCode)
                    {
                        apiResponse = new ResponseDTO(false, 
                            response.StatusCode.ToString(), 
                            null);
                    }
                    else
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        var objectResult = JsonConvert.DeserializeObject<string>(result);

                        apiResponse = new ResponseDTO(true, 
                            "OK", 
                            objectResult);
                    }
                }
                catch (Exception ex)
                {
                    apiResponse = new ResponseDTO(false, 
                        ex.Message, 
                        null);
                }
            }

            return apiResponse;
        }
    }
}
