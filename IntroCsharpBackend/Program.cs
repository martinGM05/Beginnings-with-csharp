using System.Text;

var sale = new SaleWithTax(15, 1.165m);
var message = sale.GetInfo();
Console.WriteLine(message);



class SaleWithTax : Sale
{
    public decimal Tax {  get; set; }

    public SaleWithTax(decimal total, decimal tax) : base(total)
    {
        Tax = tax;
    }

    public override string GetInfo()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("El total es ").Append(Total).Append("\n");
        stringBuilder.Append("Impuesto es ").Append(Tax);
        return stringBuilder.ToString();
    }

}

class Sale
{
    public  decimal Total { get; set; }

    public Sale(decimal total) {
        Total = total;
    }

    public virtual string GetInfo()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("El total es ").Append(Total);
        return stringBuilder.ToString();
    }
    
}