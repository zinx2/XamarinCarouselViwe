using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ScrollViewMaking
{
  public class Tc : TextCell
  {
    public Tc()
    {
      
      this.SetBinding(TextProperty, "Tx");
    }
  }
}
