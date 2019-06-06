An union architecture monolithic application using asp.net core and angular, I have tried to make layers loose coupling. 

layers :

Monolithic.Core : 
This project represents the UI layer​ of the union architecture, this is the most external layer, contain UI presentation and API's.
This layer has an implementation of the Dependency Inversion Principle so that application builds a loosely coupled application. 
It communicates to internal layer via interface.

Monolithic.BAL :
This project represents the Service layer of the onion architecture.
The layer holds interfaces which are used to communicate between the UI layer and repository layer.  ​
It holds business logic for an entity.​

Monolithic.DAL : 
This project represents the Repository Layer​ of the union architecture.
Create an Abstraction layer between the Domain entities layer and Business Logic layer of an application.
It is a data access pattern that prompts a more loosely coupled approach to data access​
UOW pattern has been implimented so you dont need to use generic repository pattern. 

Monolithic.Adapter : 
A custom layer made by me to consume by DAL or BAL hwever i did not find any reason to use it in BAL so i referenced it to DAL only.
This layer is responsible to retrive data from external resource such as ADO.net sp, httpclient etc. 
This project use EF so the EF is the same adaptor which use in repository. 


Monolithic.Model : 
This project represents the Domain Entities layer of the onion architecture.  
It holds POCO classes along with configuration classes. 
These classes are used to create database tables. 
It’s a core and central part of the application.




