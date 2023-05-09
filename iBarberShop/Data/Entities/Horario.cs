namespace iBarberShop.Data.Entities;

public class Horario
{
    public int Id { get; set; }
    public int BarberiaId { get; set; }
    public DiaSemana DiaSemana { get; set; }
    public TimeSpan HoraApertura { get; set; }
    public TimeSpan HoraCierre { get; set; }

    public virtual Barberia Barberia { get; set; }
}

