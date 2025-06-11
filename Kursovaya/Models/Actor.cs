using Kursovaya.Utills;
using System;
using System.Collections.Generic;

namespace Kursovaya.Models;

public class Actor : ViewModelBase
{
    private int actorId;
    public int ActorId
    {
        get { return actorId; }
        set { actorId = value; OnPropertyChanged(nameof(ActorId)); }
    }

    private string fio;
    public string Fio
    {
        get { return fio; }
        set { fio = value; OnPropertyChanged(nameof(Fio)); }
    }

    private ICollection<Film> films = new List<Film>();
    public virtual ICollection<Film> Films
    {
        get { return films; }
        set { films = value; OnPropertyChanged(nameof(Films)); }
    }
}
