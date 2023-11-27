﻿using ConsoleApp1.Helpers;
using ConsoleApp1.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    internal class BlogService : IBaseService<Blog>
    {
        public int Create(Blog data)
        {
            string query = $"INSERT INTO Blogs VALUES (N'{data.Title}', N'{data.Description}', {data.UserId}";
            return SqlHelper.Exec(query);
        }

        public int Delete(int id)
        {
            string query = $"DELETE Artists WHERE Id = {id}";
            return SqlHelper.Exec(query);
        }

        public List<Blog> GetAll()
        {
            DataTable dt = SqlHelper.GetDatas("SELECT * FROM Blogs");
            List<Blog> list = new List<Blog>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Blog
                {
                    Id = (int)row["Id"],
                    Title = (string)row["Title"],
                    Description = (string)row["Description"],
                    UserId = (int)row["UserId"],
                });
            }
            return list;
        }

        public Blog GetById(int id)
        {
            DataTable dt = SqlHelper.GetDatas($"SELECT * FROM Blogs WHERE Id={id}");

            foreach (DataRow row in dt.Rows)
            {
                Blog blog = new Blog
                {
                    Id = (int)row["Id"],
                    Title = (string)row["Title"],
                    Description = (string)row["Description"],
                    UserId = (int)row["UserId"],
                };
            return blog;
            }
            return null;
        }

        //public List<Blog> GetWhere(string query)
        //{
            
        //}

        //public int Update(int id, Blog data)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
