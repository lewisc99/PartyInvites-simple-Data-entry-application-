
using System.Collections.Generic;


//This repository will retrieve the Form that user filled"



namespace PartyInvites.Models
{
    public  static class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>();
        public static IEnumerable<GuestResponse> Responses
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponses(GuestResponse response)
        {
            responses.Add(response);
        }
    }
}
