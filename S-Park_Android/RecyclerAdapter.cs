using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using RestSharp;

namespace S_Park_Android
{
     public class RecyclerAdapter : RecyclerView.Adapter, IItemClickListener
    {
        private List<string> listData = new List<string>();
        private Context context;
        int row_index = -1;
        List<Parking_Garage> garagelist = new List<Parking_Garage>();

        //for using restSharp API
        public RestClient client = new RestClient("http://localhost/WcfServiceTest/Service.svc/rest/");
         

        //View itemView;
        public RecyclerAdapter(List<string> listData, Context context)
        {
            this.listData = listData;
            this.context = context;
        }
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).
           Inflate(Resource.Layout.ParkingPlace_Selection, parent, false);
            RecyclerHolder vh = new RecyclerHolder(itemView);
            return vh;
        }
        public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
        {

            RecyclerHolder vh = viewHolder as RecyclerHolder;
            vh.Caption.Text = listData[position];

            vh.SetItemClickListener(this);
           // viewHolder.ItemView.SetBackgroundColor(Color.Green);
            //int select = 3;
            //if (select == position)
            //{
            //   // itemView.SetBackgroundColor(Color.Green);

            //}


            // var item = items[position];
            // var holder = viewHolder as RecyclerHolder;
            // holder.Caption.Text = items[position];

        }

        public void Onclick(View itemView, int position, bool isLongClick)
        {
            if (isLongClick)
            {
                //itemView.SetBackgroundColor(Color.Green);

                Toast.MakeText(context, "Long Click : " + listData[position], ToastLength.Short).Show();
                //Database_Connection db = new Database_Connection();
                //List<string> mydataInfo = new List<string>();
                //mydataInfo=db.MyConnection();
                //Toast.MakeText(context, "afsa" + mydataInfo[1], ToastLength.Short).Show();


            }
            else
                row_index = position;
            //Common.currentitem=
            //Database_Connection db = new Database_Connection();
            //db.MyConnection();
            Toast.MakeText(context, " " + listData[position], ToastLength.Short).Show();
            // List<Parking_Garage> garagelist = new List<Parking_Garage>();
            //  garagelist.Add(GetStatus());
            //var request = new RestRequest("GetStatus", Method.GET) { RequestFormat=DataFormat.Json};
            //// request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            //var response = client.Execute<List<Parking_Garage>>(request);
            //Console.WriteLine("dsfdf"+response.Data);
          //  var queryResult = client.Execute(request);
           // IRestResponse<List<Parking_Garage>> response = client.Execute<List<Parking_Garage>>(request);
           // garagelist.AddRange(response.Data);
           // return response.Data;
           // Toast.MakeText(context, "" + response.Data, ToastLength.Short).Show();
           
        }

        public List<Parking_Garage> GetStatus()
        {
            RestRequest request = new RestRequest("GetStatus", Method.GET);
            IRestResponse<List<Parking_Garage>> response = client.Execute<List<Parking_Garage>>(request);
            garagelist.AddRange(response.Data);
            return response.Data;
           
        }

        public override int ItemCount
        {
            get
            {
                return listData.Count;
            }
        }
    }

}
