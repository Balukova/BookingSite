using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Models;
namespace Mappers
{
    public class ProductInShopMapper : IMapper<ProductInShop, ProductInShopEntity>
    {
        private IMapper<Shop, ShopEntity> shopMapper;
        private IMapper<Product, ProductEntity> productMapper;

        public ProductInShopMapper(IMapper<Shop, ShopEntity> shopMapper, IMapper<Product, ProductEntity> productMapper)
        {
            this.shopMapper = shopMapper;
            this.productMapper = productMapper;
        }
        public ProductInShop ToDomain(ProductInShopEntity entity)
        {
            return new ProductInShop { Id = entity.Id, Quantity = entity.Quantity, Product = productMapper.ToDomain(entity.Product), Shop = shopMapper.ToDomain(entity.Shop), Price = entity.Price, ShopId = entity.ShopId, ProductId = entity.ProductId };
        }

        public ProductInShopEntity ToEntity(ProductInShop domain)
        {
            return new ProductInShopEntity { Id = domain.Id, Quantity = domain.Quantity, Product = productMapper.ToEntity(domain.Product), Shop = shopMapper.ToEntity(domain.Shop), Price = domain.Price, ProductId = domain.ProductId, ShopId = domain.ShopId };
        }
    }
}
