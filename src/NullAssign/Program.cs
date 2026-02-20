Product? product = null;

// Before .NET 10
if (product != null) {
	product.Discount = 3;
}

// .NET 10
product?.Discount = 3;

public class Product {
	public decimal Discount {
		get;
		set => field = value >= 0
			? value
			: throw new ArgumentOutOfRangeException("Discount must be 0 or greater");
	}
}