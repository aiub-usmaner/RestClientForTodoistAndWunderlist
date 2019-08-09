using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client3
{
    class Todoist
    {
        private const String bearer = "51da0996c39cd56e8f48add2fb14110cae68bf79";
        public static String CreateTask(Int64 project, String titel, String date)
        {
            var client = new RestClient("https://api.todoist.com/rest/v1/tasks");
            var request = new RestSharp.RestRequest(RestSharp.Method.POST);
            request.RequestFormat = RestSharp.DataFormat.Json;
            request.AddHeader("Content-Type", "application/json");
            //request.AddHeader("X-Request-Id", "008de752b4254b1c8cdf2fcd16473fe9");
            request.AddHeader("Authorization", "Bearer " +bearer);
            var body = new
            {
                content = titel,
                project_id = project,
                due_date = date

            };
            request.AddJsonBody(body);
            var response = client.Execute(request);
            return response.Content.ToString();
        }
    }
}
