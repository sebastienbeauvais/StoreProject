using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreBusinessObjectLayer.DataBaseEntities;

namespace StoreBusinessLayer.LogicServices
{
	public interface IProductsLogic
	{
        List<StoreBusinessObjectLayer.DataBaseEntities.Products> GetProductsListLogic();

    }
}

