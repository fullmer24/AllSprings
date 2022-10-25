using System.Data;
using AllSprings.Models;
using Dapper;

namespace AllSprings.Repositories
{
    public class HotSpringsRepository
    {
        private readonly IDbConnection _db;
        public HotSpringsRepository(IDbConnection db)
        {
            _db = db;
        }

        internal HotSprings Create(HotSprings newHotSprings)
        {
            string sql = @"
            INSERT INTO hotsprings
            (name, gps, location, link, rating, description, directions, access, mainImg, otherImg, temp, isPrivate, isPaid, visited, creatorId)
            VALUES
            (@name, @gps, @location, @link, @rating, @description, @directions, @access, @mainImg, @otherImg, @temp, @isPrivate, @isPaid, @visited, @creatorId)
            SELECT LAST_INSERT_ID();
            ";
            int Id = _db.ExecuteScalar<int>(sql, newHotSprings);
            newHotSprings.Id = Id;
            return newHotSprings;
        }
    }
}