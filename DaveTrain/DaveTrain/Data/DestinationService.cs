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
        public event EventHandler DataUpdated;
        private IFirebaseClient client;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "II3bycCtijU0NplKxY7HoJ1e8YLtIY92PRYHdBRu",
            BasePath = "https://dazzling-torch-8270.firebaseio.com/"
        };

        public async Task dothis()
        {
            EventStreamResponse response = await client.OnAsync("DavesTrain/passengers", (sender, args, context) => {
                if(DataUpdated != null) DataUpdated.Invoke(this,EventArgs.Empty);
            });
        }


        public DestinationService()
        {
            client = new FireSharp.FirebaseClient(config);
            Task h = dothis();
          
        }
        public string GetWinner()
        {
            string winner = string.Empty;
            string temp = string.Empty;
           // int vote = 0;
            int winnercounter = 0;
            var destenationsFromDatabase = client.Get("DavesTrain/destinations/").ResultAs<List<DestinationModel>>();
            var v = destenationsFromDatabase.Select(x=>x.vote).Max();
            foreach (var item in destenationsFromDatabase)
            {
                if(item.vote >= v)
                {
                    
                    //vote = item.vote;
                    winnercounter++;
                    temp = item.name;

                }
                
            }

            if (winnercounter == 1) winner = temp;
            else winner = "No Winner";
            //var gf1 = destenationsFromDatabase.OrderByDescending(obj => obj.vote).ToList().Where(x=>x.vote;

                //var gf = maxItem.
                //if (maxItem.vote == 0) winner = "Pending...";
                //else winner = maxItem.name;

            return winner;
        }

       public string GetDestinationNameById(int destId)
        {
            var destenationsFromDatabase  = client.Get("DavesTrain/destinations/").ResultAs<List<DestinationModel>>();
            var nd = destenationsFromDatabase.Where(x => x.Id == destId).FirstOrDefault();

            return nd.name;
        }

        public void ResetAllVotes()
        {
            var destenationsFromDatabase = client.Get("DavesTrain/destinations/").ResultAs<List<DestinationModel>>();
            for(int i=0;i< destenationsFromDatabase.Count;i++)
            {
                client.Set("DavesTrain/destinations/" + i + "/vote", 0);
            }

            var passengersFromDatabase = client.Get("DavesTrain/passengers/").ResultAs<List<DestinationModel>>();
            for (int i = 0; i < passengersFromDatabase.Count; i++)
            {
                client.Set("DavesTrain/passengers/" + i + "/votedfor", string.Empty);
            }
        }



    }
}









