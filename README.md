# Dependency Inversion

High-Level modules should not depend upon low-level modules. Both should depend upon abstractions. Abstractions should not depend upon details. Details should depend upon abstractions.



# Dependency Injection

"Dependency Injection is Software Design Pattern that allows removoal of hard coded dependancies and makes it possible to change them, whether at Run-time or Compile-time." - Wikipedia.

"Dependency Injection is set of Software Design Principles and Patterns that enables us to develope loosely couple code" - Mark Seemann.

Advantages of Dependency Injection :
- Extensibility
- Testability
- Late Binding
- Parallel Development
- Maintainability 

Patterns used to implement Dependency Injection :
- Custructor Injection
- Property Injection
- Method Injection
- Ambient context
- Service Locator

DI containers :
Dependency Injection Containers are also called as IoC or Inversion of Control containers.

Available DI containers are:
- Unity : From Microsoft Patterns and Practices
- Spring.Net : .Net port of Java Spring Framework
- Castle Windsor : From Castle Project
- Ninject, Autofac, StructureMap, 

