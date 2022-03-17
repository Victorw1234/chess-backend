using ChessBackend.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessBackend.Hubs
{
    public class ChessHub : Hub
    {
        public async Task<bool> JoinRoom(string name,string roomName)
        { 

            await Groups.AddToGroupAsync(Context.ConnectionId, roomName);
            await Clients.OthersInGroup(roomName).SendAsync("joined", name);
            return true;

        }

        public async Task<bool> JoinRoomNoMessage(string name, string roomName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, roomName);

            return true;
        }

        public async Task<bool> BroadcastName(string name,string roomName)
        {
            await Clients.OthersInGroup(roomName).SendAsync("nameBroadcasted", name);

            return true;
        }

        public async Task<bool> StartGame(string roomName)
        {
            await Clients.OthersInGroup(roomName).SendAsync("gameStarted", true);

            return true;
        }

        public async Task LeaveRoom(string roomName)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, roomName);

        }
        public async Task SendMove(ChessMove message,string roomName)
        {
            await Clients.OthersInGroup(roomName).SendAsync("MoveMade",message);
            
        }
       
    }
}
