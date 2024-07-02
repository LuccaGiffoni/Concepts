using Concepts.Accessors;

Abstracts.Run();

List<IMovable> moveables = [new Car(), new Airplane()];
var interfaces = new Interfaces(moveables);
interfaces.Run();