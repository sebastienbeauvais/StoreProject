﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreBusinessObjectLayer.DataBaseEntities;

namespace StoreDataAccessLayer.DataServices
{
	public class ProductsDataServices : IProductsDataAccess
	{
		public List<Products>GetProductsListDataAccess()
		{
			return new List<Products>();
		}
	}
}

