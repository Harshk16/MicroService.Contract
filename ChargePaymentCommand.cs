// MicroService.Contracts.Events (or a new Commands namespace)
namespace MicroService.Contracts.Commands;

public class ChargePaymentCommand
{
    public Guid OrderId { get; set; }
    public string CustomerId { get; set; } = "";
    public decimal Amount { get; set; }
}