using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MostSnake.Models
{
    public class MostSnakeResponse
    {
        public string Action { get; set; }
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }

        public MostSnakeResponse(string action, Player playerOne, Player playerTwo)
        {
            Action = action;
            PlayerOne = playerOne;
            PlayerTwo = playerTwo;
        }
    }
}