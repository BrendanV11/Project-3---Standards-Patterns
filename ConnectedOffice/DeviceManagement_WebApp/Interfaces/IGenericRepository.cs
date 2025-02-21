﻿using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using DeviceManagement_WebApp.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DeviceManagement_WebApp.Data;

namespace DeviceManagement_WebApp.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(Guid id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        void SaveChangesAsync();
        public void Update(T Entit);
        public ConnectedOfficeContext GetContext();
    }

}