﻿namespace APICoreBank.RequetModels
{
    public class PaymentRequestModels
    {
        public string CardNumber { get; set; }
        public string CardUserName { get; set; }
        public string CVC { get; set; }
        public int ExpiryYear { get; set; }
        public int ExpiryMonth { get; set; }
        public decimal ShoppingPrice { get; set; }
    }
}
