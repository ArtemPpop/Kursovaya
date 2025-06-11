using Kursovaya.Utills;
using System;
using System.Collections.Generic;

namespace Kursovaya.Models;

public partial class PurchaseFilm : ViewModelBase
{
    private int _purchaseId;
    private int? _filmId;
    private int? _userId;
    private Film? _film;
    private User? _user;

    public int PurchaseId
    {
        get { return _purchaseId; }
        set
        {
            if (_purchaseId != value)
            {
                _purchaseId = value;
                OnPropertyChanged(nameof(PurchaseId));
            }
        }
    }

    public int? FilmId
    {
        get { return _filmId; }
        set
        {
            if (_filmId != value)
            {
                _filmId = value;
                OnPropertyChanged(nameof(FilmId));
            }
        }
    }

    public int? UserId
    {
        get { return _userId; }
        set
        {
            if (_userId != value)
            {
                _userId = value;
                OnPropertyChanged(nameof(UserId));
            }
        }
    }

    public virtual Film? Film
    {
        get { return _film; }
        set
        {
            if (_film != value)
            {
                _film = value;
                OnPropertyChanged(nameof(Film));
            }
        }
    }

    public virtual User? User
    {
        get { return _user; }
        set
        {
            if (_user != value)
            {
                _user = value;
                OnPropertyChanged(nameof(User));
            }
        }
    }
}
