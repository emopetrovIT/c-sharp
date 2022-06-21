namespace CarDealer.Web.Controllers
{
    using CarDealer.Services;
    using CarDealer.Web.Infrastructure.Extensions;
    using Microsoft.AspNetCore.Mvc;

    [Route("sales")]
    public class SalesController : Controller
    {
        private readonly ISaleService sales;

        public SalesController(ISaleService sales)
        {
            this.sales = sales;
        }

        [Route("")]
        public IActionResult All()
        {
            return View(this.sales.All());
        }

        [Route("{id}")]
        public IActionResult Details(int id)
        {
            return this.ViewOrNotFound(this.sales.Details(id));
        }
    }
}
