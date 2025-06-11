using Kursovaya.Utills;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Kursovaya.Models;

public partial class User : ViewModelBase
{
    private int _userId;
    private int? _subscriptionId;
    private string _login;
    private string _email;
    private string _password;
    private DateOnly? _registrationDate;
    private int? _favoritesId;
    private ObservableCollection<BrowsingHistory> _browsingHistories;
    private Favorite? _favorite;
    private ObservableCollection<PurchaseFilm> _purchaseFilms;
    private ObservableCollection<PurchasingSubscription> _purchasingSubscriptions;
    private ObservableCollection<Review> _reviews;

    public User()
    {
        _browsingHistories = new ObservableCollection<BrowsingHistory>();
        _purchaseFilms = new ObservableCollection<PurchaseFilm>();
        _purchasingSubscriptions = new ObservableCollection<PurchasingSubscription>();
        _reviews = new ObservableCollection<Review>();
    }

    public int UserId
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

    public int? SubscriptionId
    {
        get { return _subscriptionId; }
        set
        {
            if (_subscriptionId != value)
            {
                _subscriptionId = value;
                OnPropertyChanged(nameof(SubscriptionId));
            }
        }
    }

    public string Login
    {
        get { return _login; }
        set
        {
            if (_login != value)
            {
                _login = value;
                OnPropertyChanged(nameof(Login));
            }
        }
    }

    public string Email
    {
        get { return _email; }
        set
        {
            if (_email != value)
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }
    }

    public string Password
    {
        get { return _password; }
        set
        {
            if (_password != value)
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
    }

    public DateOnly? RegistrationDate
    {
        get { return _registrationDate; }
        set
        {
            if (_registrationDate != value)
            {
                _registrationDate = value;
                OnPropertyChanged(nameof(RegistrationDate));
            }
        }
    }

    public int? FavoritesId
    {
        get { return _favoritesId; }
        set
        {
            if (_favoritesId != value)
            {
                _favoritesId = value;
                OnPropertyChanged(nameof(FavoritesId));
            }
        }
    }

    public virtual ObservableCollection<BrowsingHistory> BrowsingHistories
    {
        get { return _browsingHistories; }
        set
        {
            if (_browsingHistories != value)
            {
                _browsingHistories = value;
                OnPropertyChanged(nameof(BrowsingHistories));
            }
        }
    }

    public virtual Favorite? Favorite
    {
        get { return _favorite; }
        set
        {
            if (_favorite != value)
            {
                _favorite = value;
                OnPropertyChanged(nameof(Favorite));
            }
        }
    }

    public virtual ObservableCollection<PurchaseFilm> PurchaseFilms
    {
        get { return _purchaseFilms; }
        set
        {
            if (_purchaseFilms != value)
            {
                _purchaseFilms = value;
                OnPropertyChanged(nameof(PurchaseFilms));
            }
        }
    }

    public virtual ObservableCollection<PurchasingSubscription> PurchasingSubscriptions
    {
        get { return _purchasingSubscriptions; }
        set
        {
            if (_purchasingSubscriptions != value)
            {
                _purchasingSubscriptions = value;
                OnPropertyChanged(nameof(PurchasingSubscriptions));
            }
        }
    }

    public virtual ObservableCollection<Review> Reviews
    {
        get { return _reviews; }
        set
        {
            if (_reviews != value)
            {
                _reviews = value;
                OnPropertyChanged(nameof(Reviews));
            }
        }
    }
}

