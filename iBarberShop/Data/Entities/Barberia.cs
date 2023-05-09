namespace iBarberShop.Data.Entities;

// Entidad Barbería
public class Barberia
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Direccion { get; set; }

    public virtual ICollection<Servicio> Servicios { get; set; }
    public virtual ICollection<Reserva> Reservas { get; set; }
    public virtual ICollection<Comentario> Comentarios { get; set; }

    public virtual ICollection<Horario> Horarios { get; set; }
}

