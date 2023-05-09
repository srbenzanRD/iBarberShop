namespace iBarberShop.Data.Entities;

// Entidad Cliente
public class Cliente
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Email { get; set; }
    public string Telefono { get; set; }

    public virtual ICollection<Reserva> Reservas { get; set; }
    public virtual ICollection<Comentario> Comentarios { get; set; }
    public virtual ICollection<Notificacion> Notificaciones { get; set; }
}

