namespace iBarberShop.Data.Entities;

// Entidad Pago
public class Pago
{
    public int Id { get; set; }
    public int ReservaId { get; set; }
    public decimal Monto { get; set; }

    public virtual Reserva Reserva { get; set; }
}

