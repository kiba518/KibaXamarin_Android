using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace KibaXamarin_Android
{
    [Activity(Label = "KibaXamarin_Android", MainLauncher = true)]
    public class MainActivity : BaseActivity
    { 
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);  
            SetContentView(Resource.Layout.MainActivity);
            //Button btn_search = this.FindControl<Button>("btn_search");
            //btn_search.Click += (s, e) =>
            //{
            //    this.ShowToast("Click Me");
            //};
            Button btn_search = this.FindControl<Button>("btn_search", () => { this.ShowToast("Click Me"); });
            //IListAdapter adapter = new GridAdapter(this, this.Resources);
            //GridView my_grid = this.FindControl<GridView>("my_grid");
            //my_grid.SetAdapter(adapter);//配置适配器
            //my_grid.ItemClick += (s, e) =>
            //{
            //    this.ShowToast("Click Me" + e.Id);
            //};
        }
    }

   

}

