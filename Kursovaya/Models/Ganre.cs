using Kursovaya.Utills;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Kursovaya.Models;

public partial class Ganre : ViewModelBase
{
    private int _ganreId;
    private string _ganreName;
    private ObservableCollection<Film> _films;

    public Ganre()
    {
        _films = new ObservableCollection<Film>();
    }

    public int GanreId
    {
        get { return _ganreId; }
        set
        {
            if (_ganreId != value)
            {
                _ganreId = value;
                OnPropertyChanged(nameof(GanreId));
            }
        }
    }

    public string GanreName
    {
        get { return _ganreName; }
        set
        {
            if (_ganreName != value)
            {
                _ganreName = value;
                OnPropertyChanged(nameof(GanreName));
            }
        }
    }

    public virtual ObservableCollection<Film> Films
    {
        get { return _films; }
        set
        {
            if (_films != value)
            {
                _films = value;
                OnPropertyChanged(nameof(Films));
            }
        }
    }
}
