using BadNews.ModelBuilders.News;
using Microsoft.AspNetCore.Mvc;

namespace BadNews.Controllers
{
    public class NewsController : Controller
    {
        private readonly INewsModelBuilder _newsModelBuilder;

        public NewsController(INewsModelBuilder newsModelBuilder)
        {
            _newsModelBuilder = newsModelBuilder;
        }

        public IActionResult Index(int pageIndex = 0)
        {
            if (true)
            {
                var indexModel = _newsModelBuilder.BuildIndexModel(pageIndex, false, null);
                return View(indexModel);
                
            }
        }
    }
}