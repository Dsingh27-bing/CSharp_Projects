namespace Generics2;

class Program
{
    static void Main(string[] args)
    {
        var repository = new GenericRepository<Entity>();
        
        repository.Add(new Entity { Id = 1 });
        repository.Add(new Entity { Id = 2 });
        repository.Add(new Entity { Id = 3 });

        
        Console.WriteLine("All Entities:");
        foreach (var entity in repository.GetAll())
        {
            Console.WriteLine($"Entity Id: {entity.Id}");
        }

        
        Console.WriteLine("\nGet Entity by Id:");
        var entityById = repository.GetById(2);
        if (entityById != null)
        {
            Console.WriteLine($"Entity Found: Id = {entityById.Id}");
        }
        else
        {
            Console.WriteLine("Entity not found.");
        }

        
        Console.WriteLine("\nRemoving an entity...");
        repository.Remove(entityById);

       
        repository.Save();

        
        Console.WriteLine("\nAll Entities after removal:");
        foreach (var entity in repository.GetAll())
        {
            Console.WriteLine($"Entity Id: {entity.Id}");
        }

        
        repository.Save();
    }
}