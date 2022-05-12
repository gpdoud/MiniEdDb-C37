// See https://aka.ms/new-console-template for more information
using MiniEdDb.Models;

Console.WriteLine("Hello, World!");

var db = new AppDbContext();

db.Majors.ToList().ForEach(x => Console.WriteLine(x));