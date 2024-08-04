namespace WebApiWithMessageQueue.Payment;

internal class PaymentRequest
{
    public Guid Id { get; set; }
    public string BuyerName { get; set; }
    public decimal Value { get; set; }
    public DateTime OrderDate { get; set; }
}
