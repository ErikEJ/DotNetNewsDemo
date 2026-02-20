// Before .NET 10
public class Product {
	private decimal _discount;

	public decimal Discount {
		get => _discount;
		set => _discount = value >= 0
			? value
			: throw new ArgumentOutOfRangeException("Discount must be 0 or greater");
	}
}


// .NET 10
public class Product10 {
	public decimal Discount {
		get;
		set => field = value >= 0
			? value
			: throw new ArgumentOutOfRangeException("Discount must be 0 or greater");
	}
}