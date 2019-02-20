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

            GridView my_grid = this.FindControl<GridView>("my_grid");
            IListAdapter adapter = new GridAdapter(this);
            my_grid.Adapter = adapter;//配置适配器
            my_grid.ItemClick += (s, e) =>
            {
                this.ShowToast("Click Me" + e.Id);
            };
        }
    }

   

}

