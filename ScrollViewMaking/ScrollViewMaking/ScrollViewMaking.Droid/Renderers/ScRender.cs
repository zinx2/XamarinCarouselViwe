using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using ScrollViewMaking.Droid.Renderers;
using ScrollViewMaking;
using Xamarin.Forms.Platform.Android;
using Java.Lang;

[assembly: ExportRenderer(typeof(Sc), typeof(ScRender))]
namespace ScrollViewMaking.Droid.Renderers
{
  public class ScRender : ScrollViewRenderer
  {

    int x1;
    int x2;
    int y1;
    int y2;
    List<int> posXs;
    bool _moveEnabled = false;
    int accessCount = 0;
    int distanceX;
    int _moveDisabledDistance = 5;
    bool _isHalf = false;

    protected override void OnElementChanged(VisualElementChangedEventArgs e)
    {
      //this.Touch += LvRender2_Touch;
    }

    public int dp(float value)
    {
      return (int) (value / Resources.DisplayMetrics.Density);
    }

    public int Abs(float value)
    {
      return (int) Java.Lang.Math.Abs(value);
    }

    public override bool DispatchTouchEvent(MotionEvent e)
    {

      

      switch (e.Action)
      {
        
        case MotionEventActions.Down:
          //this.Parent.RequestDisallowInterceptTouchEvent(false);
          x1 = dp(e.GetX());
          y1 = dp(e.GetY());

          //OnInterceptTouchEvent(e);
          break;
        case MotionEventActions.Move:
          x2 = dp(e.GetX());
          y2 = dp(e.GetY());
          int dx = dp(x2 - x1);
          
          int absDy = Abs(dp(y2 - y1));
          
          if (20 > x1 || x1 > ( dp(Width) - 20 )  && absDy < 20)
          {
            //횡 스크롤 가능
            Cf.OK = false;
          }
          else
          {
            //횡 스크롤 불가능
            Cf.OK = true;
          }

          x1 = x2;
          y1 = y2;
          //if (Java.Lang.Math.Abs(dy) < 20) Cf.OK = true;
          //else
          //  Cf.OK = false;
          //this.Parent.RequestDisallowInterceptTouchEvent(false);

          //if (_moveEnabled)
          //{
          //  x2 = e.GetX();
          //  distanceX = (int)((x2 - x1) / Resources.DisplayMetrics.Density);
          //  _moveEnabled = false;
          //}
          //else
          //{

          //  _moveEnabled = true;
          //}

          //this.Post(new Runnable(() =>
          //{


          //  //Fc.Instance.SView.AddLv(1);
          //}));


          break;
        case MotionEventActions.Up:
          //this.SmoothScrollTo(0, 0);
          //this.Parent.RequestDisallowInterceptTouchEvent(false);
          break;
      }
      
      return base.DispatchTouchEvent(e);
    }

    public override bool OnInterceptTouchEvent(MotionEvent ev)
    {

      return false;
    }
    protected override void OnScrollChanged(int a, int b, int c, int d)
    {

    }

  }
}