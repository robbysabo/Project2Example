using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Project2.ViewModel;

public class Project2Viewmodel : INotifyPropertyChanged
{
    public Project2Viewmodel()
    {
        OnChangeButtonTextClicked = new Command<string>((key) => ChangeButtonText="change");
    }

    public string Title { get; set; } = "Robert Sabo : Project 2";

    private string _myname = "Robert Sabo";
    public string MyName
    {
        get => _myname;
        private set
        {
            _myname = value;

            OnPropertyChanged();
        }
    }

    private string _ChangeButtonText = "Show first name";
    public string ChangeButtonText
    {
        get => _ChangeButtonText;
        set
        {
            if (_myname == "Robert")
            {
                _ChangeButtonText = "Show first name";
                MyName = "Robert Sabo";
            } else
            {
                MyName = "Robert";
                _ChangeButtonText = "Show full name";
            }
            OnPropertyChanged();
        }
    }

    public ICommand OnChangeButtonTextClicked
    {
        get;
        private set;
    }

    public void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    public event PropertyChangedEventHandler? PropertyChanged;
}

