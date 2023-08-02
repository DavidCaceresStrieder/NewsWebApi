using NewsWebApi.Repository.Interface;

using NewsAPI;
using NewsAPI.Models;
using NewsAPI.Constants;
using System;

namespace NewsWebApi.Repository.Implementation
{
    public class NewsRepository : INewsRepository
    {

        private readonly IConfiguration _configuration;
        public NewsRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public ArticlesResult getTopHeadLines(Countries? country)
        {
            var newsApiClient = new NewsApiClient(_configuration.GetValue<string>("NewsApiSettings:apiKey"));
            var articlesResponse = newsApiClient.GetTopHeadlines(new TopHeadlinesRequest
            {                
                Country = country,
            });

            return articlesResponse;

        }

        public ArticlesResult searchNews(string criteria,DateTime? from, DateTime? to)
        {
            var newsApiClient = new NewsApiClient(_configuration.GetValue<string>("NewsApiSettings:apiKey"));
            var articlesResponse = newsApiClient.GetEverything(new EverythingRequest
            {
                Q = criteria,
                From = from,
                To = to
            });

            return articlesResponse;
        }
    }
}
