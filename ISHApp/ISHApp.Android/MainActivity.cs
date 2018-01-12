using Android.App;
using Android.OS;
using Android.Util;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;


namespace ISHApp.Droid
{
    [Activity(Label = "@string/app_name", MainLauncher = true, Icon = "@drawable/ic_launcher_tbi")]
    public class MainActivity : Activity
    {
        static readonly string Tag = "ActionBarTabsSupport";

        Fragment[] _fragments;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            AppCenter.Start("154a210d-e24f-484b-b586-057fee3fa0ab",
                   typeof(Analytics), typeof(Crashes));
            SetContentView(Resource.Layout.Main);

            ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
            SetContentView(Resource.Layout.Main);

            _fragments = new Fragment[]
                         {
                             //new BeschikbaarheidFragment(),
                             new ActueelFragment(),
                             new HistorieFragment()
                         };

            //AddTabToActionBar(Resource.String.beschikbaarheid_tab_label, Resource.Drawable.ic_action_empty);
            AddTabToActionBar(Resource.String.actueel_tab_label, Resource.Drawable.ic_action_empty);
            AddTabToActionBar(Resource.String.historie_tab_label, Resource.Drawable.ic_action_empty);
        }

        void AddTabToActionBar(int labelResourceId, int iconResourceId)
        {
            ActionBar.Tab tab = ActionBar.NewTab()
                                         .SetText(labelResourceId)
                                         .SetIcon(iconResourceId);
            tab.TabSelected += TabOnTabSelected;
            ActionBar.AddTab(tab);
        }

        void TabOnTabSelected(object sender, ActionBar.TabEventArgs tabEventArgs)
        {
            ActionBar.Tab tab = (ActionBar.Tab)sender;

            Log.Debug(Tag, "The tab {0} has been selected.", tab.Text);
            Fragment frag = _fragments[tab.Position];
            tabEventArgs.FragmentTransaction.Replace(Resource.Id.frameLayout1, frag);
        }
    }
}
