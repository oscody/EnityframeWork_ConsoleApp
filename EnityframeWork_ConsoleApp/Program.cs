Console.WriteLine("Hello, World!");

var db = new BloggingContext();

Console.WriteLine("Inserting a new blog");
db.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
db.SaveChanges();