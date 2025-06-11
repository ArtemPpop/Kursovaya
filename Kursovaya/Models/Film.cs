using Kursovaya.Utills;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Kursovaya.Models;

public partial class Film : ViewModelBase
{
    private int _filmId;
    private string _filmName;
    private string _description;
    private string _yearIssue;
    private string _subscripType;
    private int _ganreId;
    private int _directorId;
    private int _actorId;
    private int _producersId;
    private TimeOnly _duration;
    private int _ageLimit;
    private string _country;
    private Actor _actor;
    private Director _director;
    private Producer _directorNavigation;
    private Ganre _ganre;
    private ObservableCollection<BrowsingHistory> _browsingHistories;
    private ObservableCollection<PurchaseFilm> _purchaseFilms;
    private ObservableCollection<Review> _reviews;

    public Film()
    {
        _filmName = string.Empty;
        _description = string.Empty;
        _yearIssue = string.Empty;
        _subscripType = string.Empty;
        _country = string.Empty;
        _browsingHistories = new ObservableCollection<BrowsingHistory>();
        _purchaseFilms = new ObservableCollection<PurchaseFilm>();
        _reviews = new ObservableCollection<Review>();
    }

    public int FilmId
    {
        get => _filmId;
        set { _filmId = value; OnPropertyChanged(nameof(FilmId)); }
    }

    public string FilmName
    {
        get => _filmName;
        set { _filmName = value; OnPropertyChanged(nameof(FilmName)); }
    }

    public string Description
    {
        get => _description;
        set { _description = value; OnPropertyChanged(nameof(Description)); }
    }

    public string YearIssue
    {
        get => _yearIssue;
        set { _yearIssue = value; OnPropertyChanged(nameof(YearIssue)); }
    }

    public string SubscripType
    {
        get => _subscripType;
        set { _subscripType = value; OnPropertyChanged(nameof(SubscripType)); }
    }

    public int GanreId
    {
        get => _ganreId;
        set { _ganreId = value; OnPropertyChanged(nameof(GanreId)); }
    }

    public int DirectorId
    {
        get => _directorId;
        set { _directorId = value; OnPropertyChanged(nameof(DirectorId)); }
    }

    public int ActorId
    {
        get => _actorId;
        set { _actorId = value; OnPropertyChanged(nameof(ActorId)); }
    }

    public int ProducersId
    {
        get => _producersId;
        set { _producersId = value; OnPropertyChanged(nameof(ProducersId)); }
    }

    public TimeOnly Duration
    {
        get => _duration;
        set { _duration = value; OnPropertyChanged(nameof(Duration)); }
    }

    public int AgeLimit
    {
        get => _ageLimit;
        set { _ageLimit = value; OnPropertyChanged(nameof(AgeLimit)); }
    }

    public string Country
    {
        get => _country;
        set { _country = value; OnPropertyChanged(nameof(Country)); }
    }

    public virtual Actor Actor
    {
        get => _actor;
        set { _actor = value; OnPropertyChanged(nameof(Actor)); }
    }

    public virtual Director Director
    {
        get => _director;
        set { _director = value; OnPropertyChanged(nameof(Director)); }
    }

    public virtual Producer DirectorNavigation
    {
        get => _directorNavigation;
        set { _directorNavigation = value; OnPropertyChanged(nameof(DirectorNavigation)); }
    }

    public virtual Ganre Ganre
    {
        get => _ganre;
        set { _ganre = value; OnPropertyChanged(nameof(Ganre)); }
    }

    public virtual ObservableCollection<BrowsingHistory> BrowsingHistories
    {
        get => _browsingHistories;
        set { _browsingHistories = value; OnPropertyChanged(nameof(BrowsingHistories)); }
    }

    public virtual ObservableCollection<PurchaseFilm> PurchaseFilms
    {
        get => _purchaseFilms;
        set { _purchaseFilms = value; OnPropertyChanged(nameof(PurchaseFilms)); }
    }

    public virtual ObservableCollection<Review> Reviews
    {
        get => _reviews;
        set { _reviews = value; OnPropertyChanged(nameof(Reviews)); }
    }
}