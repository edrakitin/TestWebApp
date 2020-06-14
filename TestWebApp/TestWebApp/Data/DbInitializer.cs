﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using TestWebApp.DBLayer.Contexts;
using TestWebApp.DBLayer.Models;

namespace TestWebApp.Data
{
    public static class DbInitializer
    {
        public static void InitializeApplicationDbContext(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;
            }

            var users = new IdentityUser[]
            {
                new IdentityUser 
                {
                    Id = "23a98ba9-7417-44b8-b922-04c18872bb50",  UserName = "Test4@test.ru",     
                    NormalizedUserName = "TEST4@TEST.RU",  Email = "Test4@test.ru",   
                    NormalizedEmail = "TEST4@TEST.RU", EmailConfirmed = true,  
                    PasswordHash = "AQAAAAEAACcQAAAAEMGJanAKi7A8j97+HDegeVK2OexIwe7JYxIzT9pzb03GKjwngym6TaVc0gNYErWAzA==", SecurityStamp = "VQPHWEHUXWVDCGEZMXUY56JQULPAKQI3",  
                    ConcurrencyStamp = "1445e270-f202-4133-8cc4-dbf9d1c5220c", LockoutEnabled = true
                    
                },                
                new IdentityUser  
                {
                    Id = "2bc052f2-802b-4f7d-885d-29f340824e9f",  UserName = "Test2@test.ru",    
                    NormalizedUserName = "TEST2@TEST.RU",  Email = "Test2@test.ru",  
                    NormalizedEmail = "TEST2@TEST.RU", EmailConfirmed = true,  
                    PasswordHash = "AQAAAAEAACcQAAAAEG+BTVInKP4RDkVOGSH925XOJ6ewYfOPYypGVRefqcvihiU27n78ArpiNewPhjA6Dw==", SecurityStamp = "E3ZPMJFUU6WGCUKXA4A2OHH44AFNYYXP",   
                    ConcurrencyStamp = "65ecd28d-72c6-4c26-b038-14dc8ceaee0a", LockoutEnabled = true
                },                
                new IdentityUser  {
                    Id = "3cf89f8b-5064-4d76-bbdc-64f8a4e85e4a",  UserName = "Test1@test.ru",   
                    NormalizedUserName = "TEST1@TEST.RU",  Email = "Test1@test.ru",   
                    NormalizedEmail = "TEST1@TEST.RU", EmailConfirmed = true,  
                    PasswordHash = "AQAAAAEAACcQAAAAEMT9E2Ov5QjEa5m/9d+2vHurB1OPkOhiT5FezquJ7xO+KWMArlvMIpxJiQTSorFaTQ==", SecurityStamp = "IUVDCJCG7JQFVR35YDNB3UCCBZQGBTN5",   
                    ConcurrencyStamp = "b8771eda-808b-42e6-9ab4-a42d652a027c", LockoutEnabled = true
                },                
                new IdentityUser  {
                    Id = "4bd61928-77b2-4c8a-a410-6c7d109fbdd2", UserName = "Test3@test.ru",
                    NormalizedUserName = "TEST3@TEST.RU", Email = "Test3@test.ru",
                    NormalizedEmail = "TEST3@TEST.RU", EmailConfirmed = true,  
                    PasswordHash = "AQAAAAEAACcQAAAAEOB9p//bLi3Q2bRwDBfErKodT/VRU8QgSZNZqZVPJgKwtW+xSpGHnEkxhUzoB+BQ3A==", SecurityStamp = "3TKE6R446Z2JBAQBZZAD5RBLB6ABMK34",
                    ConcurrencyStamp = "c5cf5dd3-4c3a-47b1-bbfa-ae0271865f6a", LockoutEnabled = true
                }                
            };

            foreach (var u in users)
            {
                context.Users.Add(u);
            }

            context.SaveChanges();
        }

        public static void InitializeTestDbContext(TestDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Films.Any())
            {
                return;
            }
            
            var films = new Film[]
            {
                new Film
                {
                    Name = "TestFilm1", Description = "Description1",  
                    ReleaseYear = DateTime.Now.Year, Director = new Director(){ Name = "TestDirector1" }, 
                    Poster = new FileStore(), UserCreatorId = "23a98ba9-7417-44b8-b922-04c18872bb50"
                },
                new Film
                {
                    Name = "TestFilm2", Description = "Description2",
                    ReleaseYear = DateTime.Now.Year, Director = new Director(){ Name = "TestDirector2" },
                    Poster = new FileStore(), UserCreatorId = "2bc052f2-802b-4f7d-885d-29f340824e9f"
                },
                new Film  {
                    Name = "TestFilm3", Description = "Description3",
                    ReleaseYear = DateTime.Now.Year, Director = new Director(){ Name = "TestDirector3" },
                    Poster = new FileStore(), UserCreatorId = "3cf89f8b-5064-4d76-bbdc-64f8a4e85e4a"
                },
                new Film  {
                    Name = "TestFilm4", Description = "Description4",
                    ReleaseYear = DateTime.Now.Year, Director = new Director(){ Name = "TestDirector4" },
                    Poster = new FileStore(), UserCreatorId = "4bd61928-77b2-4c8a-a410-6c7d109fbdd2"
                },

                new Film
                {
                    Name = "TestFilm5", Description = "Description5",
                    ReleaseYear = DateTime.Now.Year, Director = new Director(){ Name = "TestDirector5" },
                    Poster = new FileStore(), UserCreatorId = "3cf89f8b-5064-4d76-bbdc-64f8a4e85e4a"
                },
                new Film
                {
                    Name = "TestFilm6", Description = "Description6",
                    ReleaseYear = DateTime.Now.Year, Director = new Director(){ Name = "TestDirector6" },
                    Poster = new FileStore(), UserCreatorId = "4bd61928-77b2-4c8a-a410-6c7d109fbdd2"
                },
                new Film  {
                    Name = "TestFilm7", Description = "Description7",
                    ReleaseYear = DateTime.Now.Year, Director = new Director(){ Name = "TestDirector7" },
                    Poster = new FileStore(), UserCreatorId = "2bc052f2-802b-4f7d-885d-29f340824e9f"
                },
                new Film  {
                    Name = "TestFilm8", Description = "Description8",
                    ReleaseYear = DateTime.Now.Year, Director = new Director(){ Name = "TestDirector8" },
                    Poster = new FileStore(), UserCreatorId = "23a98ba9-7417-44b8-b922-04c18872bb50"
                },

                new Film
                {
                    Name = "TestFilm9", Description = "Description9",
                    ReleaseYear = DateTime.Now.Year, Director = new Director(){ Name = "TestDirector9" },
                    Poster = new FileStore(), UserCreatorId = "4bd61928-77b2-4c8a-a410-6c7d109fbdd2"
                },                
                new Film  {
                    Name = "TestFilm10", Description = "Description10",
                    ReleaseYear = DateTime.Now.Year, Director = new Director(){ Name = "TestDirector10" },
                    Poster = new FileStore(), UserCreatorId = "3cf89f8b-5064-4d76-bbdc-64f8a4e85e4a"
                },
                new Film  {
                    Name = "TestFilm11", Description = "Description11",
                    ReleaseYear = DateTime.Now.Year, Director = new Director(){ Name = "TestDirector11" },
                    Poster = new FileStore(), UserCreatorId = "23a98ba9-7417-44b8-b922-04c18872bb50"
                },
                new Film
                {
                    Name = "TestFilm12", Description = "Description12",
                    ReleaseYear = DateTime.Now.Year, Director = new Director(){ Name = "TestDirector12" },
                    Poster = new FileStore(), UserCreatorId = "2bc052f2-802b-4f7d-885d-29f340824e9f"
                },
            };
            
            foreach (var f in films)
            {
                context.Films.Add(f);
            }

            context.SaveChanges();
        }
    }
}