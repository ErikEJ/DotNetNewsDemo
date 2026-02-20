// Extension members

// Before .NET 10
var product = new Product();
product.GetPrice();

public class Product {
	public decimal Price { get; set; }
}

public static class ProductExtensions {
	public static decimal GetPrice(this Product product) {
		return product.Price;
	}
}

// .NET 10

public class Product10 {
	public decimal Price { get; set; }
}

public static class Product10Extensions {
	extension(Product10 product) {
		public decimal GetPrice() {
			return product.Price;
		}
	}
}
