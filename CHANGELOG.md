# Changelog

###Version 0.0.2.X

##### Singleton pattern

Add an easy way to implement a singleton. A class can inherit from `SingletonBase<T>` to follow the singleton pattern. 

###Version 0.0.1.X

##### Enum helper

Add enum extension methods to easily get description attribute value from an enum.

##### Description attribute

Description attribute is not available in the PCL. Description attribute adds a string that describes an element.

##### Prototype pattern

Add an interface and an abstract class which expose two methods:

* `Clone()` : returns a shallow copy of itself.
* `DeepCopy()` : returns a deep copy of itself.
 
 ` PrototypeBase<T>`  implements these two methods, so class that will follow the prototype pattern can inherit it. Class that already inherit from another class can implement the `IPrototype<T>` interface instead.

#Backlog

## Patterns
* MVP pattern

## Helpers/Extensions

* Serialization helper
* I/O helper
* Encoding helper
* Regex helper
* Copy helper

## Other features

* Logging system
* Monitoring system
* Localization
* Disposition

