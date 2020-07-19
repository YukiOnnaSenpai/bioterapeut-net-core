using BioterapeutDAL.Models.Classes;
using System.Collections.Generic;

namespace API.Dao.Converter
{
    public class UserConverter
    {
		public UserConverter()
		{ 
		}
		private readonly LocationConverter converter;

		public UserDao EntityToDao(ApplicationUser entity)
		{
            UserDao dao = new UserDao
            {
                Id = entity.Id,
                AccountType = entity.AccountType,
                Email = entity.Email,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                RefLocationId = converter.EntityToDao(entity.RefLocationId),
                Phone = entity.Phone
            };
            return dao;
		}

		public ApplicationUser DaoToEntity(UserDao dao)
		{
            ApplicationUser entity = new ApplicationUser
            {
                Id = dao.Id,
                AccountType = dao.AccountType,
                Email = dao.Email,
                FirstName = dao.FirstName,
                LastName = dao.LastName,
                RefLocationId = converter.DaoToEntity(dao.RefLocationId),
                Phone = dao.Phone
            };
            return entity;
		}

		public List<ApplicationUser> DaoListToEntityList(List<UserDao> daos)
		{
			List<ApplicationUser> entities = new List<ApplicationUser>();
			foreach (UserDao dao in daos)
			{
				entities.Add(DaoToEntity(dao));
			}
			return entities;
		}

		public List<UserDao> EntityListToDaoList(List<ApplicationUser> entities)
		{
			List<UserDao> daos = new List<UserDao>();
			foreach (ApplicationUser entity in entities)
			{
				daos.Add(EntityToDao(entity));
			}
			return daos;
		}
	}
}
