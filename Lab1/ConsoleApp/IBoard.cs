using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public interface IBoard
    {
        public GameBoard getBoard();
        public void loadBoard(string marks);
        public bool putMark(Player player, char cellChar);
        public void printBoard();
        public void undoAction(char cellChar);
        public void clearBoard();
        
    }
}
