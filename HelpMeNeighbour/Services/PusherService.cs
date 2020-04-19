using System;
using HelpMeNeighbour.Models;
using PusherServer;

namespace HelpMeNeighbour.Services
{
    public interface IPusherService
    {
        void SendMessage(string channel, string eventName, MessageResponseModel message);
    }
    public class PusherService : IPusherService
    {
        private Pusher _pusher;
      
        PusherService() {
            var options = new PusherOptions 
            {
              Cluster = "eu",
              Encrypted = true
            };

            _pusher = new Pusher(
              Environment.GetEnvironmentVariable("PUSHER_APP_ID"),
              Environment.GetEnvironmentVariable("PUSHER_APP_KEY"),
              Environment.GetEnvironmentVariable("PUSHER_APP_SECRET"),
              options
            );
        }

        public async void SendMessage(string channel, string eventName, MessageResponseModel message) {
            await _pusher.TriggerAsync(
              channel,
              eventName,
              message
            );
        }
    }
}
