using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CashRegister.Shared.DataModel
{
    public class Receipt
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }

        [JsonPropertyName("receiptTimestamp")]
        public DateTime ReceiptTimestamp { get; set; }

        [JsonPropertyName("receiptLines")]
        public List<ReceiptLine> ReceiptLines { get; set; } = new();

        [JsonPropertyName("totalPrice")]
        public decimal TotalPrice { get; set; }
    }
}
