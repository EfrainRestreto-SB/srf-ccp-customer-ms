

namespace Domain.Models.CreateSavingsAccount.Out;

public class SavingsAccountOutModel
{
    public string? NumeroProducto { get; set; }
    public string? IdCliente{ get; set; }
    public string? CodProducto{ get; set; }
    public string? Producto{ get; set; }
    public string? SubProducto{ get; set; }
    public string? Referencia{ get; set; }
    public string? NumeroCuenta{ get; set; }
    public string? SaldoTotal{ get; set; }
    public string? SaldoRetenido{ get; set; }
    public string? SaldoCanje{ get; set; }
    public string? SaldoDisponible{ get; set; }
    public string? FechaApertura{ get; set; }
    public string? EstadoCuenta{ get; set; }
    public string? CupoSobregiro{ get; set; }
    public string? DiasSobregiro{ get; set; }

    public string? DisponibleSobregiro { get; set; }
}