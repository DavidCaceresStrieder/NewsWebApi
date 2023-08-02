using NewsAPI.Constants;
using NewsAPI.Models;

namespace NewsWebApi.Repository.Interface
{
    public interface INewsRepository
    {        
        ArticlesResult getTopHeadLines(Countries? country);
        ArticlesResult searchNews(string criteria, DateTime? from, DateTime? to);

    }
}
