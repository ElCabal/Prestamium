﻿namespace Prestamium.Dto.Response
{
    public class PaymentDto
    {
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public int LoanId { get; set; }
    }
}
