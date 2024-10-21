using AutoMapper;

var mapperConfiguration = new MapperConfiguration(cfg =>
{
    cfg.CreateMap<SourceRoot, DestinationRoot>();
    cfg.CreateMap<ISourceProperty, IDestinationProperty>();
    // Uncomment this mapping to successfully map SourceRoot to DestinationRoot
    // cfg.CreateMap<SourceProperty, DestinationProperty>();
});

mapperConfiguration.AssertConfigurationIsValid();
Console.WriteLine("The MapperConfiguration is valid");

mapperConfiguration.CreateMapper().Map<DestinationRoot>(new SourceRoot { Property = new SourceProperty()});
Console.WriteLine("Successfully mapped source");

public interface ISourceProperty { }
public record SourceProperty : ISourceProperty;
public class SourceRoot
{
    public SourceProperty Property { get; set; }
}

public interface IDestinationProperty { }
public record DestinationProperty : IDestinationProperty;
public class DestinationRoot
{
    public DestinationProperty Property { get; set; }
}