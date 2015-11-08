using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ScrollViewMaking
{
  public class TItem : INotifyPropertyChanged
  {
    private string _tx;

    public string Tx { get { return _tx; } set { _tx = value; OnPropertyChanged(); } }
    private void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
      if (PropertyChanged != null)
      {
        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
      }
    }


    public event PropertyChangedEventHandler PropertyChanged;

  }
  public class Vm : INotifyPropertyChanged
  {
    private ObservableCollection<TItem> _tc;
    public ObservableCollection<TItem> Tc
    {
      get
      {
        return _tc;
      }
      set
      {
        _tc = value;
        OnPropertyChanged();
      }
    }

    public Vm()
    {
      _tc = new ObservableCollection<TItem>();
      for (int i = 0; i < 50; i++)
        _tc.Add(new TItem { Tx = i + "번" });

    }
    private void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
      if (PropertyChanged != null)
      {
        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
      }
    }


    public event PropertyChangedEventHandler PropertyChanged;
  }


}
