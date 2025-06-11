using Kursovaya.Utills;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Kursovaya.Models;

public partial class Director : ViewModelBase
{
    private int _directorId;
    private string _fio;
    private ICollection<Film> _films;

    public Director()
    {
        _films = new ObservableCollection<Film>();
    }

    public int DirectorId
    {
        get { return _directorId; }
        set
        {
            _directorId = value;
            OnPropertyChanged(nameof(DirectorId));
        }
    }

    public string Fio
    {
        get { return _fio; }
        set
        {
            _fio = value;
            OnPropertyChanged(nameof(Fio));
        }
    }

    public virtual ICollection<Film> Films
    {
        get { return _films; }
        set
        {
            _films = value;
            OnPropertyChanged(nameof(Films));
        }
    }
}
