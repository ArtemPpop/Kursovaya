using Kursovaya.Utills;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Kursovaya.Models;

public partial class ValidityPeriod : ViewModelBase
{
    private int _validityPeriodId;
    private string _validityPeriod1;
    private ObservableCollection<Subscription> _subscriptions;

    public ValidityPeriod()
    {
        _subscriptions = new ObservableCollection<Subscription>();
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

    public string ValidityPeriod1
    {
        get { return _validityPeriod1; }
        set
        {
            if (_validityPeriod1 != value)
            {
                _validityPeriod1 = value;
                OnPropertyChanged(nameof(ValidityPeriod1));
            }
        }
    }

    public virtual ObservableCollection<Subscription> Subscriptions
    {
        get { return _subscriptions; }
        set
        {
            if (_subscriptions != value)
            {
                _subscriptions = value;
                OnPropertyChanged(nameof(Subscriptions));
            }
        }
    }
}
