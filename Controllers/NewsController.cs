using Microsoft.AspNetCore.Mvc;
using NewsAPI.Constants;
using NewsAPI.Models;
using NewsWebApi.Repository.Interface;

namespace NewsWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewsController : ControllerBase
    {
        private readonly INewsRepository _newsRepository;
        public NewsController(INewsRepository newsRepository) 
        {
            _newsRepository = newsRepository;
        }

        [HttpGet("GetTopHeadLines")]
        public ArticlesResult Get(Countries countries = Countries.AR)
        {
            return _newsRepository.getTopHeadLines(countries);
        }

        
        [HttpGet("Search")]
        public ArticlesResult Get(string criteria,DateTime? from, DateTime? to)
        {
            return _newsRepository.searchNews(criteria,from,to);
        }
    }
}
