using System.Text.Json.Serialization;

namespace CashRegister.Shared.DataModel
{
    public class Product
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }

        [JsonPropertyName("productName")]
        public string ProductName { get; set; } = string.Empty;

        [JsonPropertyName("unitPrice")]
    public decimal UnitPrice { get; set; }
    }
}
