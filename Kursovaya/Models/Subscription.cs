using Kursovaya.Utills;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Kursovaya.Models;

public partial class Subscription : ViewModelBase
{
    private int _subscriptionId;
    private string _subscriptionType;
    private int _validityPeriodId;
    private ObservableCollection<PurchasingSubscription> _purchasingSubscriptions;
    private ValidityPeriod _validityPeriod;

    public Subscription()
    {
        _purchasingSubscriptions = new ObservableCollection<PurchasingSubscription>();
        _validityPeriod = new ValidityPeriod(); // Или оставить null, если требуется
    }

    public int SubscriptionId
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

    public string SubscriptionType
    {
        get { return _subscriptionType; }
        set
        {
            if (_subscriptionType != value)
            {
                _subscriptionType = value;
                OnPropertyChanged(nameof(SubscriptionType));
            }
        }
    }

    public int ValidityPeriodId
    {
        get { return _validityPeriodId; }
        set
        {
            if (_validityPeriodId != value)
            {
                _validityPeriodId = value;
                OnPropertyChanged(nameof(ValidityPeriodId));
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

    public virtual ValidityPeriod ValidityPeriod
    {
        get { return _validityPeriod; }
        set
        {
            if (_validityPeriod != value)
            {
                _validityPeriod = value;
                OnPropertyChanged(nameof(ValidityPeriod));
            }
        }
    }
}
