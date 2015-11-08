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
using ScrollViewMaking.Droid.Renderers;
using ScrollViewMaking;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Java.Lang;

[assembly: ExportRenderer(typeof(Lv), typeof(LvRenderer))]
namespace ScrollViewMaking.Droid.Renderers
{
  public class LvRenderer : ListViewRenderer
  {

    float x1;
    float x2;
    float y1;
    float y2;
    List<int> posXs;
    bool _moveEnabled = false;
    int accessCount = 0;
    int distanceX;
    int _moveDisabledDistance = 5;
    bool _isHalf = false;
    //protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ListView> e)
    //{
    //  e.NewElement
    //  this.Touch += LvRenderer_Touch;
    //}

    private void LvRenderer_Touch(object sender, TouchEventArgs e)
    {
      switch (e.Event.Action)
      {
        case MotionEventActions.Down:

          //x1 = e.GetX();
          //this.Parent.RequestDisallowInterceptTouchEvent(false);
          break;
        case MotionEventActions.Move:
          
          break;
        case MotionEventActions.Up:
          //this.Parent.RequestDisallowInterceptTouchEvent(false);
          break;
      }

    }

    public override bool DispatchTouchEvent(MotionEvent e)
    {
      posXs = new List<int>();
      switch (e.Action)
      {
        case MotionEventActions.Scroll:
          break;
        case MotionEventActions.Down:
          //x1 = e.GetX();
          //this.Parent.RequestDisallowInterceptTouchEvent(true);
          break;
        case MotionEventActions.Move:
          this.Parent.RequestDisallowInterceptTouchEvent(Cf.OK);
          x2 = e.GetX();
          y2 = e.GetY();
          float dx = x2 - x1;
          float dy = y2 - y1;
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

          ////int distanceX = (int)(x2 - x1);

          //int startX = (int)x1;
          //int endX = (int)x2;
          //_isHalf = Java.Lang.Math.Abs(distanceX) > (int)((this.Width / 2) / Resources.DisplayMetrics.Density);


          //this.Post(new Runnable(() =>
          //{

          //  //if(distanceX <= 0)
          //  //{
          //  bool isLeft = distanceX < -5 ? true : false;
          //  bool isRight = distanceX > 5 ? true : false;



          //  if (isLeft)
          //  {
          //    if (_isHalf) Fc.Instance.LView.MoveTo(0);
          //    else
          //    {
          //      Fc.Instance.LView.MoveTo(distanceX);
          //      this.AnimationEnd += LvRenderer_AnimationEnd;
          //      this.LayoutChange += LvRenderer_LayoutChange;
          //      //this.On;
          //      //this.OnAnimationEnd();
          //      //Fc.Instance.LView.MoveTo(0);
          //    }
          //  }
          //  if (isRight)
          //  {
          //    if (_isHalf) Fc.Instance.LView.MoveTo((int)(this.Width / Resources.DisplayMetrics.Density));
          //    else
          //    {
          //      Fc.Instance.LView.MoveTo(distanceX);
          //      //this.OnAnimationEnd();
          //      //Fc.Instance.LView.MoveTo(0);
          //    }

          //  }
          //  //if (isLeft || isRight)
          //  //  Fc.Instance.LView.MoveTo(distanceX);
          //  //}
          //}));


          //this.Parent.RequestDisallowInterceptTouchEvent(false);
          break;
        case MotionEventActions.Up:
          //this.Parent.RequestDisallowInterceptTouchEvent(false);
          break;
      }

      return base.DispatchTouchEvent(e);
    }

    private void LvRenderer_LayoutChange1(object sender, LayoutChangeEventArgs e)
    {
      throw new NotImplementedException();
    }

    private void LvRenderer_LayoutChange(object sender, LayoutChangeEventArgs e)
    {
      if(!_isHalf) Fc.Instance.LView.MoveTo(0);
    }

    private void LvRenderer_AnimationEnd(object sender, Android.Views.Animations.Animation.AnimationEndEventArgs e)
    {
      throw new NotImplementedException();
    }
    public override bool OnInterceptTouchEvent(MotionEvent ev)
    {

      return !Cf.OK;
    }
  }
}