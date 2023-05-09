namespace iBarberShop.Data.Entities;

// Entidad Reserva
public class Reserva
{
    public int Id { get; set; }
    public int BarberiaId { get; set; }
    public int ClienteId { get; set; }
    public int ServicioId { get; set; }
    public DateTime Fecha { get; set; }

    public virtual Barberia Barberia { get; set; }
    public virtual Cliente Cliente { get; set; }
    public virtual Servicio Servicio { get; set; }
    public virtual ICollection<Pago> Pagos { get; set; }
}

