using BioterapeutDAL.Models.Classes;
using DAO.Converters;
using System.Collections.Generic;

namespace API.Dao.Converter
{
    public class LocationConverter : IConverter<Location, LocationDao>
    {
        public LocationConverter()
        { 
        }
        public Location DaoToEntity(LocationDao dao)
        {
            Location entity = new Location
            {
                Id = dao.Id,
                Address = dao.Address,
                City = dao.City,
                Country = dao.Country,
                Language = dao.Language
            };
            return entity;
        }

        public LocationDao EntityToDao(Location entity)
        {
            LocationDao dao = new LocationDao
            {
                Id = entity.Id,
                Address = entity.Address,
                City = entity.City,
                Country = entity.Country,
                Language = entity.Language
            };
            return dao;
        }

        public List<Location> DaoListToEntityList(List<LocationDao> daos)
        {
            List<Location> entities = new List<Location>();
            foreach (LocationDao dao in daos)
            {
                entities.Add(DaoToEntity(dao));
            }
            return entities;
        }

        public List<LocationDao> EntityListToDaoList(List<Location> entities)
        {
            List<LocationDao> daos = new List<LocationDao>();
            foreach (Location entity in entities)
            {
                daos.Add(EntityToDao(entity));
            }
            return daos;
        }
    }
}
