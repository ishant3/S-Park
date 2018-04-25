using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace S_Park_Android
{
    [Activity(Label = "ParkSpace_SelectionActivity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class ParkSpace_SelectionActivity: AppCompatActivity
    {

        List<string> listData = new List<string>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.RecyclerView);

            SetupList();
            var recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            recyclerView.HasFixedSize = true;
            var layoutManager = new GridLayoutManager(this, 2);
            recyclerView.SetLayoutManager(layoutManager);

            RecyclerAdapter adapter = new RecyclerAdapter(listData, this);
            recyclerView.SetAdapter(adapter);
            //Database_Connection db = new Database_Connection();
            //db.MyConnection();
        }
        private void SetupList()
        {
            for (int i = 1; i <= 8; i++)
            {
                listData.Add("" + i);

            }
        }
    }
}