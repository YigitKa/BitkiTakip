using System;
using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Bitky_API.Models.DapperContext
{
	public class Context
	{
		private readonly IConfiguration _configuration;
		private readonly string? _connectionString;

		public Context(IConfiguration configuration)
		{
			_configuration = configuration;
            _connectionString = _configuration.GetConnectionString("connection");

			if (string.IsNullOrEmpty(_connectionString))
			{
				Console.WriteLine("Veritabanı bağlantı cümlesi boş. " +
					"appSettings json dosyasına aşağıdaki formatta MS SQL veritabanı bağlantı cümlesini ekleyebilirsiniz.");
				Console.WriteLine("{\n  \"ConnectionStrings\": {\n    \"connection\": \"CONNECTIONSTRINGHERE\"\n\n  }\n}\n,{\n  \"Logging\": {\n    \"LogLevel\": {\n      \"Default\": \"Information\",\n      \"Microsoft.AspNetCore\": \"Warning\"\n    }\n  },\n  \"AllowedHosts\": \"*\"\n},\n");

				for (int i = 5; i >= 0; i--)
				{
					Console.WriteLine($"Uygulama Kapatılıyor. {i}");
					Thread.Sleep(1000);
				}

				Environment.Exit(1); // hata vererek çıkıldığı belli olsun. 
			}
		}
		public IDbConnection ConnectSQL() => new SqlConnection(_connectionString);
	}
}

