using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreBusinessObjectLayer.DataBaseEntities;
using StoreDataAccessLayer.DataServices;

namespace StoreBusinessLayer.LogicServices
{
	public class Products : IProductsLogic
	{
		// intantiates the data access layer
		private readonly StoreDataAccessLayer.DataServices.IProductsDataAccess _productsDataAccess;

		// Constructor for data access layer
		public Products(StoreDataAccessLayer.DataServices.IProductsDataAccess productsLogic)
		{
			this._productsDataAccess = productsLogic;
		}

		// Logic for getting a list of products through out interface
		public List<StoreBusinessObjectLayer.DataBaseEntities.Products> GetProductsListLogic()
		{
            List<StoreBusinessObjectLayer.DataBaseEntities.Products> result = new List<StoreBusinessObjectLayer.DataBaseEntities.Products>();

			result = _productsDataAccess.GetProductsListDataAccess();

			return result;
		}
	}
}

