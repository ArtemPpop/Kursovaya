using Kursovaya.Utills;
using System;
using System.Collections.Generic;

namespace Kursovaya.Models;

public partial class PurchasingSubscription : ViewModelBase
{
    private int _purchasingId;
    private int? _subscriptionId;
    private int? _userId;
    private DateOnly? _startDate;
    private DateOnly? _endDate;
    private string _status;
    private Subscription? _subscription;
    private User? _user;

    public int PurchasingId
    {
        get { return _purchasingId; }
        set
        {
            if (_purchasingId != value)
            {
                _purchasingId = value;
                OnPropertyChanged(nameof(PurchasingId));
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

    public DateOnly? StartDate
    {
        get { return _startDate; }
        set
        {
            if (_startDate != value)
            {
                _startDate = value;
                OnPropertyChanged(nameof(StartDate));
            }
        }
    }

    public DateOnly? EndDate
    {
        get { return _endDate; }
        set
        {
            if (_endDate != value)
            {
                _endDate = value;
                OnPropertyChanged(nameof(EndDate));
            }
        }
    }

    public string? Status
    {
        get { return _status; }
        set
        {
            if (_status != value)
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }
    }

    public virtual Subscription? Subscription
    {
        get { return _subscription; }
        set
        {
            if (_subscription != value)
            {
                _subscription = value;
                OnPropertyChanged(nameof(Subscription));
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
