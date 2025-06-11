using Kursovaya.Utills;
using System;
using System.Collections.Generic;

namespace Kursovaya.Models;

public partial class Favorite : ViewModelBase
{
    private int _userId;
    private int? _filmId;
    private User _user;

    public int UserId
    {
        get { return _userId; }
        set
        {
            _userId = value;
            OnPropertyChanged(nameof(UserId));
        }
    }

    public int? FilmId
    {
        get { return _filmId; }
        set
        {
            _filmId = value;
            OnPropertyChanged(nameof(FilmId));
        }
    }

    public virtual User User
    {
        get { return _user; }
        set
        {
            _user = value;
            OnPropertyChanged(nameof(User));
        }
    }
}
