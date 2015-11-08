using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ScrollViewMaking
{
  public partial class Sl : StackLayout
  {
    public Sl()
    {
      InitializeComponent();
      this.Children.Add(new Lv());
    }
  }
}
