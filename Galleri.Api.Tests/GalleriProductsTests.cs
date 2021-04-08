using System;
using Galleri.Api.Models;
using Galleri.Api.Services;
using Xunit;

namespace Galleri.Api.Tests
{
    public class GalleriProductsTests
    {
        [Fact]
        public void ProductService_GetAllProducts_ShouldReturnTwoEntities()
        {
            var service = new ProductService();
            var products = service.GetAllProducts();
            Assert.Equal(products.Count, 2);
        }

        [Fact]
        public void ProductService_AddlProducts_ShouldReturnThreeEntities()
        {
            var product = new Product();
            var service = new ProductService();
            var products = service.AddProduct(product);
            Assert.Equal(service.GetAllProducts().Count, 3);
        }

        [Fact]
        public void ProductService_GetProductById_ShouldReturnTheProduct()
        {
            var service = new ProductService();
            var product = service.GetProductById(1);
            Assert.Equal(product.Id, 1);
        }
    }
}
