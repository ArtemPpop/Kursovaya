using Kursovaya.Utills;
using System;
using System.Collections.Generic;

namespace Kursovaya.Models;

public partial class BrowsingHistory : ViewModelBase
{
    private int _viewId;
    private int? _userId;
    private int? _filmId;
    private DateTime? _endTime;
    private Film? _film;
    private User? _user;

    public int ViewId
    {
        get { return _viewId; }
        set { _viewId = value; OnPropertyChanged(nameof(ViewId)); }
    }

    public int? UserId
    {
        get { return _userId; }
        set { _userId = value; OnPropertyChanged(nameof(UserId)); }
    }

    public int? FilmId
    {
        get { return _filmId; }
        set { _filmId = value; OnPropertyChanged(nameof(FilmId)); }
    }

    public DateTime? EndTime
    {
        get { return _endTime; }
        set { _endTime = value; OnPropertyChanged(nameof(EndTime)); }
    }

    public virtual Film? Film
    {
        get { return _film; }
        set { _film = value; OnPropertyChanged(nameof(Film)); }
    }

    public virtual User? User
    {
        get { return _user; }
        set { _user = value; OnPropertyChanged(nameof(User)); }
    }
}

