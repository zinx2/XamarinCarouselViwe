using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrollViewMaking
{
  public class Fc
  {
    private static Fc _fc = new Fc();
    public static Fc Instance
    {
      get
      {
        return _fc;
      }
    }

    private Lv _lv;
    public Lv LView
    {
      set
      {
        _lv = value;
      }
      get
      {
        return _lv;
      }
    }

    private Sc _sc;
    public Sc SView
    {
      set
      {
        _sc = value;
      }
      get
      {
        return _sc;
      }
    }

  }
}
