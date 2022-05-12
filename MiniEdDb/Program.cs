// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;

using MiniEdDb.Models;

Console.WriteLine("Hello, World!");

var db = new AppDbContext();

db.Majors.ToList().ForEach(x => Console.WriteLine(x));

//db.Students.Include(x => x.Major).ToList().ForEach(x => Console.WriteLine(x));

db.Classes.Include(x => x.Instructor).ToList().ForEach(x => Console.WriteLine(x));