# Class 03 - Abstract classes and interfaces (revisited)

This folder contains the samples of usage for abstract classes and interfaces. It is demonstrated through several projects, with the same functionality - a user that can have profile on multiple social networks and can post messages to those networks.

The projects demonstrate the strengths and weaknesses of both abstract classes and interfaces, and how they can be used together.

Interfaces are suitable for defining a contract, while abstract classes are suitable for defining a common implementation. 

## `AbstractClass` project

In `AbstractClass` project, the social network is defined as an abstract class - `SocialNetwork`, with a common implementation for posting messages, that is shared across all inherited social networks (Facebook, Twitter), but can be overridden. 

## `Interface` project

In `Interface` project, the social network is defined as an interface - `ISocialNetwork`, with no implementation. While we have some duplicated implementation (the `Post` method in each concrete social network), interfaces are more suitable for Dependency Injection (a very important pattern in today's software design) and faking the implementation in unit (automated) tests.

## `AbstractClassAndInterface` project

In `AbstractClassAndInterface` project, the social network is defined as an interface - `ISocialNetwork`, but also has an abstract class as a base for concrete social network implementations - `SocialNetwork`, that fulfills the interface contract. This brings the best of both worlds.

## Abstraction usage

In all projects, the `User` class has a list of social network objects. This is a good example of how to use abstraction in your code - the `User` class does not know about the concrete social network implementation, but only about the contract (abstract class or interface). It can post messages to any social network, without knowing how the message is posted.