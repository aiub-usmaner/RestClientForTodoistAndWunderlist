using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client3
{
    class Wunderlist
    {
        private const String bearer = "a6c09b209cc9aa5059089971584469c3f1e18e6ee58dd12193122cb2d84b";
        private const String client_id = "8d655b45271173ba3d53";
        private const String token = "a6c09b209cc9aa5059089971584469c3f1e18e6ee58dd12193122cb2d84b";
        public static String CreateTask(Int64 project, String titel, String date)
        {
            var client = new RestClient("https://a.wunderlist.com/api/v1/tasks");
            var request = new RestSharp.RestRequest(RestSharp.Method.POST);
            request.RequestFormat = RestSharp.DataFormat.Json;
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("X-Access-Token", token);
            request.AddHeader("X-Client-ID", client_id);
            request.AddHeader("Authorization", "Bearer " + bearer);
            request.AddParameter("scope", "read_write");

            var body = new
            {
                list_id = project,
                title = titel,
                due_date = date 

            };
            request.AddJsonBody(body);
            var response = client.Execute(request);
            return response.Content.ToString();
        }
    }
}
