using System;
using System.Linq;
using ShaBoo.Entities;

namespace ShaBoo.Domain.Services
{
    public interface IBoardService
    {
        IQueryable<Board> ListAllBoard();

        void CreateAnNewBoard(string title, DateTime postedOn, string content);

    }
}
