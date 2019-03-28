using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Activity7.Models
{
    public class GamePieceModel
    {
        public GamePieceModel(int ID, int Value)
        {
            this.ID = ID;
            this.Value = Value;
        }
        public int ID { get; set; }
        public int Value { get; set; }
    }
}