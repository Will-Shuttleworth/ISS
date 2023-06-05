using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISS.ViewModel;

public partial class BaseViewModel : ObservableObject, IBaseViewModel
{
    public BaseViewModel()
    {

    }

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    bool _isBusy;

    [ObservableProperty]
    string _title;

    [ObservableProperty]
    bool _isInitialized;

    public bool IsNotBusy => !IsBusy;

    public Task InitializeAsync()
    {
        return Task.CompletedTask;
    }
}

