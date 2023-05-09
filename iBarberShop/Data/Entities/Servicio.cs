namespace iBarberShop.Data.Entities;

// Entidad Servicio
public class Servicio
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public int BarberiaId { get; set; }

    public virtual Barberia Barberia { get; set; }
    public virtual ICollection<Reserva> Reservas { get; set; }
}

