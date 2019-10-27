using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace DaveTrain.Data
{
    public class PassengerService
    {
        private IFirebaseClient client;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "II3bycCtijU0NplKxY7HoJ1e8YLtIY92PRYHdBRu",
            BasePath = "https://dazzling-torch-8270.firebaseio.com/"
        };


        public PassengerService()
        {
            client = new FireSharp.FirebaseClient(config);
        }
        public List<PassengerModel> GetAllPassengers()
        {
           

            var passengersFromDatabase = client.Get("DavesTrain/passengers/").ResultAs<List<PassengerModel>>();
            return passengersFromDatabase.ToList(); 
        }

        public string PassengerHasVotedFor(int id)
        {
           
           
            return client.Get("DavesTrain/passengers/" + id.ToString() + "/votedfor").ResultAs<string>(); 
        }

        public void SetPassengerVote(int passengerId,string destination)
        {


            var passengersFromDatabase = client.Set("DavesTrain/passengers/" + passengerId.ToString() + "/votedfor", destination);
          
        }

    }
}
