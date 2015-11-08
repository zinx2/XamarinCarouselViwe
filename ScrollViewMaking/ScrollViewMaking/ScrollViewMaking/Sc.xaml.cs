using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ScrollViewMaking
{
  public partial class Sc : ScrollView
  {
    List<ListView> list;

    ListView lv1;
    ListView lv2;
    ListView lv3;
    Vm vm;
    public Sc()
    {
      list = new List<ListView>();
      vm = new Vm();
      BindingContext = vm;
      InitializeComponent();

      //lv1 = CreateLv(Color.Lime);
      //lv2 = CreateLv(Color.Yellow);
      //lv3 = CreateLv(Color.Blue);

      //this.sl_main.Children.Add(lv1);
      //AddLv(1);
      //AddLv(2);
      //ContentView lv = new Lv();
      //this.sl_main.Children.Add(CreateLv(Color.Lime));
      //this.sl_main.Children.Add(CreateLv(Color.Yellow));

    }

    public ListView CreateLv(Color color)
    {
      ListView lv = new ListView();
      lv.ItemsSource = vm.Tc;
      lv.ItemTemplate = new DataTemplate(typeof(Tc));
      lv.BackgroundColor = color;
      list.Add(lv);
      return lv;
    }
    public void AddLv(int index)
    {
      if(index == 1)
      {
        this.sl_main.Children.Add(lv2);
      }
      else
      {
        this.sl_main.Children.Add(lv3);
      }
    }

    public void Create(Color color)
    {
      ListView lv = new ListView();
      lv.ItemsSource = vm.Tc;
      lv.ItemTemplate = new DataTemplate(typeof(Tc));
      lv.BackgroundColor = color;
      list.Add(lv);

      this.sl_main.Children.Add(lv);
    }

    //public ListView RemoveLv(int index)
    //{
    //  //sl_main.Children.Remove()

    //  //ListView lv = new ListView();
    //  //lv.ItemsSource = vm.Tc;
    //  //lv.ItemTemplate = new DataTemplate(typeof(Tc));
    //  //lv.BackgroundColor = color;
    //  return lv;
    //}
  }
}
