namespace iBarberShop.Data.Entities;

// Entidad Comentario
public class Comentario
{
    public int Id { get; set; }
    public int BarberiaId { get; set; }
    public int ClienteId { get; set; }
    public string Contenido { get; set; }

    public virtual Barberia Barberia { get; set; }
    public virtual Cliente Cliente { get; set; }
}

