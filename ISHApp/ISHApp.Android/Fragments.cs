using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace ISHApp.Droid
{
    public class ActueelFragment : Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.simple_fragment, null);
            //view.FindViewById<TextView>(Resource.Id.textView1).SetText(Resource.String.actueel_tab_label);
            ListView lv = view.FindViewById<ListView>(Resource.Id.listViewMeldingen);

            var mItems = new List<string>();
            mItems.Add("Bob");
            mItems.Add("Tom");
            mItems.Add("Jim");

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this.Activity, Android.Resource.Layout.SimpleListItem1);

            adapter.AddAll(mItems);
            lv.SetAdapter(adapter);


            return view;
        }
    }

    public class HistorieFragment : Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.simple_fragment, null);
            //view.FindViewById<TextView>(Resource.Id.textView1).SetText(Resource.String.historie_tab_label);
            view.FindViewById<ListView>(Resource.Id.listViewMeldingen);
            ListView lv = view.FindViewById<ListView>(Resource.Id.listViewMeldingen);

            var mItems = new List<string>();
            mItems.Add("Jan");
            mItems.Add("Klaas");
            mItems.Add("Piet");

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this.Activity, Android.Resource.Layout.SimpleListItem1);

            adapter.AddAll(mItems);
            lv.SetAdapter(adapter);

            return view;
        }
    }

    public class BeschikbaarheidFragment : Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.simple_fragment, null);
            //view.FindViewById<TextView>(Resource.Id.textView1).SetText(Resource.String.beschikbaarheid_tab_label);
            view.FindViewById<ListView>(Resource.Id.listViewMeldingen);
            return view;
        }
    }
}
