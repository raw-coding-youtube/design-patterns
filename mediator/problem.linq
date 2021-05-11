<Query Kind="Program" />

void Main()
{

}

public class Product
{
	public int Id { get; set; }
}

public class Cart
{
	List<Product> products;

	public void AddProduct(Product product)
	{
		products.Add(product);
	}
}

public class Catalog
{
	List<Product> products;
	
	public List<Product> getProducts(){
		return products;
	}
}

public class ProductPage
{ 
	Cart cart;
	Catalog catalog;

	public ProductPage(Catalog catalog, Cart cart)
	{
		this.cart = cart;
		this.catalog = catalog;
	}

	public void AddToCart(int id)
	{
		var product = catalog.getProducts().First(x => x.Id == id);
		cart.AddProduct(product);
	}
	
	public void DisplayProducts(){
		// set ui elements from catalog
	}
}