using Kursovaya.Utills;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Kursovaya.Models;

public partial class Producer : ViewModelBase
{
    private int _producersId;
    private string _fio;
    private ObservableCollection<Film> _films;

    public Producer()
    {
        _films = new ObservableCollection<Film>();
    }

    public int ProducersId
    {
        get { return _producersId; }
        set
        {
            if (_producersId != value)
            {
                _producersId = value;
                OnPropertyChanged(nameof(ProducersId));
            }
        }
    }

    public string Fio
    {
        get { return _fio; }
        set
        {
            if (_fio != value)
            {
                _fio = value;
                OnPropertyChanged(nameof(Fio));
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
