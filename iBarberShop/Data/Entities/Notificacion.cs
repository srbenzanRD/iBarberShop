namespace iBarberShop.Data.Entities;

// Entidad Notificación
public class Notificacion
{
    public int Id { get; set; }
    public int ClienteId { get; set; }
    public string Mensaje { get; set; }
    public DateTime Fecha { get; set; }

    public virtual Cliente Cliente { get; set; }
}

