using System;
using System.Linq;
using ShaBoo.Domain.Repositories;
using ShaBoo.Domain.Services;
using ShaBoo.Entities;

namespace ShaBoo.Services
{
    public class BoardService : IBoardService
    {

        private IDALContext context;
        public BoardService(IDALContext contextParam)
        {
            context = contextParam;
        }

        public IQueryable<Board> ListAllBoard()
        {
            return context.BoardRepository.GetAll();
        }

        public void CreateAnNewBoard(string title, DateTime postedOn, string content)
        {
            var boardToInsert = new Board
                            {
                                Title = title,
                                PostedOn = postedOn,
                                Content = content
                            };
            context.BoardRepository.Insert(boardToInsert);
            context.SaveChanges();
        }

        public Board GetBoardViaID(int id)
        {
            return context.BoardRepository.GetByID(id);
        }
    }
}
