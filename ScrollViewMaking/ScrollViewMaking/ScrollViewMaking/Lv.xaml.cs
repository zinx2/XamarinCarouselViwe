using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ScrollViewMaking
{
  public partial class Lv : ListView
  {
    public Lv()
    {
      InitializeComponent();
      //BindingContext = new Vm();

      Fc.Instance.LView = this;
    }

    public void MoveTo(float posX)
    {
      this.TranslateTo((double)posX, 0);
    }

  }
}
