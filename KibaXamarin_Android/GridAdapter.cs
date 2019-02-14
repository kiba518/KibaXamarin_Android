using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Android.Content;
using Java.Lang;
using Android.Util;
using Android.Graphics.Drawables;
using Android.Content.Res;

namespace KibaXamarin_Android
{
    public class GridAdapter : BaseAdapter
    {
        private DisplayMetrics localDisplayMetrics;
        private LayoutInflater inflater;
        private Resources resources;
        public GridAdapter(Context context, Resources _resources)
        {
            resources = _resources;
            localDisplayMetrics = resources.DisplayMetrics;
            inflater = LayoutInflater.From(context);
        }

        public override int Count => 9; 

        public override Object GetItem(int position)
        {
            return null;
        } 

        public override long GetItemId(int position)
        {
            return position;
        }
         
        public override View GetView(int paramInt, View paramView, ViewGroup paramViewGroup)
        {
            paramView = inflater.Inflate(Resource.Layout.activity_label_item, null);
            TextView text = (TextView)paramView.FindViewById(Resource.Id.activity_name);

            switch (paramInt)
            {
                case 0:
                    {
                        text.Text = "local";
                        Drawable draw = this.resources.GetDrawable(Resource.Drawable.home_button_local);
                        draw.SetBounds(0, 0, draw.IntrinsicWidth, draw.IntrinsicHeight);
                        text.SetCompoundDrawables(null, draw, null, null);
                        break;
                    }

                case 1:
                    {
                        text.Text = "search";
                        Drawable draw = this.resources.GetDrawable(Resource.Drawable.home_button_search);
                        draw.SetBounds(0, 0, draw.IntrinsicWidth, draw.IntrinsicHeight);
                        text.SetCompoundDrawables(null, draw, null, null);
                        break;
                    }

                case 2:
                    {
                        text.Text = "checkin";
                        Drawable draw = this.resources.GetDrawable(Resource.Drawable.home_button_checkin);
                        draw.SetBounds(0, 0, draw.IntrinsicWidth, draw.IntrinsicHeight);
                        text.SetCompoundDrawables(null, draw, null, null);
                        break;
                    }

                case 3:
                    {
                        text.Text = "promo";
                        Drawable draw = this.resources.GetDrawable(Resource.Drawable.home_button_promo);
                        draw.SetBounds(0, 0, draw.IntrinsicWidth, draw.IntrinsicHeight);
                        text.SetCompoundDrawables(null, draw, null, null);
                        break;
                    }

                case 4:
                    {
                        text.Text = "tuan";
                        Drawable draw = this.resources.GetDrawable(Resource.Drawable.home_button_tuan);
                        draw.SetBounds(0, 0, draw.IntrinsicWidth, draw.IntrinsicHeight);
                        text.SetCompoundDrawables(null, draw, null, null);
                        break;
                    }

                case 5:
                    {
                        text.Text = "rank";
                        Drawable draw = this.resources.GetDrawable(Resource.Drawable.home_button_rank);
                        draw.SetBounds(0, 0, draw.IntrinsicWidth, draw.IntrinsicHeight);
                        text.SetCompoundDrawables(null, draw, null, null);
                        break;
                    }

                case 6:
                    {
                        text.Text = "history";
                        Drawable draw = this.resources.GetDrawable(Resource.Drawable.home_button_history);
                        draw.SetBounds(0, 0, draw.IntrinsicWidth, draw.IntrinsicHeight);
                        text.SetCompoundDrawables(null, draw, null, null);
                        break;
                    }

                case 7:
                    {
                        text.Text = "myzone";
                        Drawable draw = this.resources.GetDrawable(Resource.Drawable.home_button_myzone);
                        draw.SetBounds(0, 0, draw.IntrinsicWidth, draw.IntrinsicHeight);
                        text.SetCompoundDrawables(null, draw, null, null);
                        break;
                    }
                case 8:
                    {
                        text.Text = "more";
                        Drawable draw = this.resources.GetDrawable(Resource.Drawable.home_button_more);
                        draw.SetBounds(0, 0, draw.IntrinsicWidth, draw.IntrinsicHeight);
                        text.SetCompoundDrawables(null, draw, null, null);
                        break;
                    }
            }

            paramView.SetMinimumHeight((int)(96.0F * localDisplayMetrics.Density));
            paramView.SetMinimumWidth(((-12 + localDisplayMetrics.WidthPixels) / 3));

            return paramView;
        }
    }
}

