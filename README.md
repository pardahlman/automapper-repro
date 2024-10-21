# Repro app for AutoMapper issue

This repository showcases [an issue with the latest version of AutoMapper](https://github.com/AutoMapper/AutoMapper/issues/4504) (13.0.1). `AssertConfigurationIsValid` does not detect that mapping for concrete type of mapped object's property is missing if an interface that property type is implementing has registered mapping.

To verify run repro app

Console output

```
The MapperConfiguration is valid
Unhandled exception. AutoMapper.AutoMapperMappingException: Error mapping types.

Mapping types:
SourceRoot -> DestinationRoot
SourceRoot -> DestinationRoot

Type Map configuration:
SourceRoot -> DestinationRoot
SourceRoot -> DestinationRoot

Destination Member:
Property

 ---> AutoMapper.AutoMapperMappingException: Cannot create interface IDestinationProperty

Mapping types:
ISourceProperty -> IDestinationProperty
ISourceProperty -> IDestinationProperty

Type Map configuration:
ISourceProperty -> IDestinationProperty
ISourceProperty -> IDestinationProperty
   at lambda_method1(Closure, Object, DestinationRoot, ResolutionContext)
   --- End of inner exception stack trace ---
   at lambda_method1(Closure, Object, DestinationRoot, ResolutionContext)
```

If line 8 is not commented out:

```
The MapperConfiguration is valid
Successfully mapped source
```
