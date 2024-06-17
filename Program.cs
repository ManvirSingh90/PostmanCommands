using System;
using RestSharp;
using System.Threading;
using System.Threading.Tasks;
namespace HelloWorldApplication
{
	class HelloWorld
	{
		static async Task Main(string[] args)
		{
			var options = new RestClientOptions("https://reqres.in");
			var client = new RestClient(options);
			var request = new RestRequest("/api/users?page=1", Method.Get);
			var body = @"";
			request.AddParameter("text/plain", body, ParameterType.RequestBody);
			RestResponse response = await client.ExecuteAsync(request);
			Console.WriteLine(response.Content);
		}
		static async Task Main1(string[] args)
		{

			var options = new RestClientOptions("https://reqres.in");
			var client = new RestClient(options);
			var request = new RestRequest("/api/users/5", Method.Get);
			RestResponse response = await client.ExecuteAsync(request);
			Console.WriteLine(response.Content);
		}
		static async Task Main2(string[] args)
		{
			var options = new RestClientOptions("https://reqres.in");
			var client = new RestClient(options);
			var request = new RestRequest("/api/users?page=1", Method.Get);
			RestResponse response = await client.ExecuteAsync(request);
			Console.WriteLine(response.Content);
		}
		static async Task Main3(string[] args)
		{

			var options = new RestClientOptions("https://reqres.in");
			var client = new RestClient(options);
			var request = new RestRequest("/api/users", Method.Post);
			request.AddHeader("Content-Type", "text/html");
			var body = @"{
            " + "\n" +
			@"   ""id"":13
            " + "\n" +
			@"   ""email"" : ""brandonwoods@gmail.com"",
            " + "\n" +
			@"   ""first_name"" : "" Brandon "",
            " + "\n" +
			@"   ""last_name"" : "" Wood ""
            " + "\n" +
			@"}";
			request.AddParameter("text/html", body, ParameterType.RequestBody);
			RestResponse response = await client.ExecuteAsync(request);
			Console.WriteLine(response.Content);
		}
		static async Task Main4(string[] args)
		{

			var options = new RestClientOptions("https://reqres.in");
			var client = new RestClient(options);
			var request = new RestRequest("/api/users/315", Method.Put);
			request.AddHeader("Content-Type", "text/html");
			var body = @"{
            " + "\n" +
			@"   ""id"":13
            " + "\n" +
			@"   ""email"" : "" brandonwoods@gmail.com"",
            " + "\n" +
			@"   ""first_name"" : "" Bradnon "",
            " + "\n" +
			@"   ""last_name"" : ""Woods Biden ""
            " + "\n" +
			@"}";
			request.AddParameter("text/html", body, ParameterType.RequestBody);
			RestResponse response = await client.ExecuteAsync(request);
			Console.WriteLine(response.Content);
		}
		static async Task Main5(string[] args)
		{
			var options = new RestClientOptions("https://reqres.in");
			var client = new RestClient(options);
			var request = new RestRequest("/api/register", Method.Post);
			request.AddHeader("Content-Type", "application/json");
			var body = @"{
            " + "\n" +
			@"    ""email"" : "" eve.holt@reqres.in"",
            " + "\n" +
			@"    ""password"" : "" pistol""
            " + "\n" +
			@"}";
			request.AddStringBody(body, DataFormat.Json);
			RestResponse response = await client.ExecuteAsync(request);
			Console.WriteLine(response.Content);
		}
		static async Task Main6(string[] args)
		{
			var options = new RestClientOptions("https://reqres.in");
		var client = new RestClient(options);
		var request = new RestRequest("/api/login", Method.Post);
		request.AddHeader("Content-Type", "application/json");
         var body = @"{
         " + "\n" +
	     @"    ""email"" : "" peter@klaven""
          " + "\n" +
	      @"}";
		request.AddStringBody(body, DataFormat.Json);
      RestResponse response = await client.ExecuteAsync(request);
		Console.WriteLine(response.Content);
		}
		static async Task Main7(string[] args)
		{

			var options = new RestClientOptions("https://reqres.in");
			var client = new RestClient(options);
			var request = new RestRequest("/api/users?delay=5", Method.Get);
			RestResponse response = await client.ExecuteAsync(request);
			Console.WriteLine(response.Content);
		}
	}
} 
