using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessBackend.Models
{
    public class ChessMove
    {
        // Initial position of the piece
        public int x { get; set; }
        public int y { get; set; }
        
        // New position of the piece

        public int x1 { get; set; }
        public int y1 { get; set; }

    }
}
