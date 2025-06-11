using Kursovaya.Utills;
using System;
using System.Collections.Generic;

namespace Kursovaya.Models;

public partial class Review : ViewModelBase
{
    private int _reviewsId;
    private int? _filmId;
    private int? _userId;
    private DateOnly? _dateWritten;
    private int? _userRating;
    private Film? _film;
    private User? _user;

    public int ReviewsId
    {
        get => _reviewsId;
        set
        {
            if (_reviewsId != value)
            {
                _reviewsId = value;
                OnPropertyChanged(nameof(ReviewsId));
            }
        }
    }

    public int? FilmId
    {
        get => _filmId;
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
        get => _userId;
        set
        {
            if (_userId != value)
            {
                _userId = value;
                OnPropertyChanged(nameof(UserId));
            }
        }
    }

    public DateOnly? DateWritten
    {
        get => _dateWritten;
        set
        {
            if (_dateWritten != value)
            {
                _dateWritten = value;
                OnPropertyChanged(nameof(DateWritten));
            }
        }
    }

    public int? UserRating
    {
        get => _userRating;
        set
        {
            if (_userRating != value)
            {
                _userRating = value;
                OnPropertyChanged(nameof(UserRating));
            }
        }
    }

    public virtual Film? Film
    {
        get => _film;
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
        get => _user;
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

