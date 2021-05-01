using System.Text.Json.Serialization;

namespace CashRegister.Shared.DataModel
{
    public class ReceiptLine
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }

        [JsonPropertyName("product")]
        public Product Product { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("totalPrice")]
        public decimal TotalPrice { get; set; }
    }
}
