using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace DaveTrain.Data
{
    public class DestinationService
    {
        private IFirebaseClient client;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "II3bycCtijU0NplKxY7HoJ1e8YLtIY92PRYHdBRu",
            BasePath = "https://dazzling-torch-8270.firebaseio.com/"
        };


        public DestinationService()
        {
            client = new FireSharp.FirebaseClient(config);
        }
        public string GetWinner()
        {
            string winner = string.Empty;
           
            var destenationsFromDatabase = client.Get("DavesTrain/destinations/").ResultAs<List<DestinationModel>>();


            DestinationModel maxItem = destenationsFromDatabase.OrderByDescending(obj => obj.vote).First();
            
            if (maxItem.vote == 0) winner = "Pending...";
            else winner = maxItem.name;
            
            return winner;
        }



    }
}









