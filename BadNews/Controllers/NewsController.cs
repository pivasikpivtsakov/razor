using BadNews.ModelBuilders.News;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BadNews.Controllers
{
    public class NewsController : Controller
    {
        private readonly INewsModelBuilder _newsModelBuilder;

        public NewsController(INewsModelBuilder newsModelBuilder)
        {
            _newsModelBuilder = newsModelBuilder;
        }

        [HttpGet("/")]
        public IActionResult Index(int pageIndex = 0)
        {
            if (true)
            {
                var indexModel = _newsModelBuilder.BuildIndexModel(pageIndex, true, null);
                return View(indexModel);
                
            }
        }

        public IActionResult fullarticle (Guid id)
        {
            if (true)
            {
                var indexModel = _newsModelBuilder.BuildFullArticleModel(id);
                if (indexModel == null)
                    return NotFound();
                return View(indexModel);
            }
        }
    }
}