using Concepts.Accessors;

Abstracts.Run();

List<IMoveable> moveables = [new Car(), new Airplane()];
var interfaces = new Interfaces(moveables);
interfaces.Run();