﻿using API.Controllers;
using API.Dao;
using API.Dao.Converter;
using BioterapeutDAL.Models.Classes;
using BioterapeutDAL.Repositories.Interfaces;
using BioterapeutDAL.Repository.Implementations.Classes;
using DAO.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Implementations
{
    public class UserService : IService<UserDao>
    {
        private readonly IConverter<ApplicationUser, UserDao> _converter;
        private readonly IRepository<ApplicationUser, int> _repository;

        public UserService(IRepository<ApplicationUser, int> repository, IConverter<ApplicationUser, UserDao> converter)
        {
            _repository = repository;
            _converter = converter;
        }
        public void Add(UserDao dao)
        {
            ApplicationUser entity = _converter.DaoToEntity(dao);
            _repository.Add(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<UserDao> GetAll()
        {
            return _converter.EntityListToDaoList(_repository.GetAll());
        }

        public UserDao GetById(int id)
        {
            return _converter.EntityToDao(_repository.GetById(id));
        }

        public void Update(UserDao dao)
        {
            _repository.Update(_converter.DaoToEntity(dao));
        }
    }
}
