using Microsoft.AspNetCore.Mvc;
using StoreBusinessLayer.LogicServices;
using StoreBusinessObjectLayer.DataBaseEntities;

namespace StorePortal.Controllers
{
	public class ProductController : Controller
	{
		private readonly IProductsLogic _productsDataAccess;

		// constructor for controller
		public ProductController(IProductsLogic productsDataAccess)
		{
			_productsDataAccess = productsDataAccess;
		}

		[HttpGet]
		public IActionResult ProductsList()
		{
            List<StoreBusinessObjectLayer.DataBaseEntities.Products> result = new List<StoreBusinessObjectLayer.DataBaseEntities.Products>();

			// getting products from the business layer 
			result = _productsDataAccess.GetProductsListLogic().ToList();

			return View();
		}
	}
}

