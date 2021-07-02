# MusicApi
The main goal of this project is to display the code which could be delivered by me. In this particular example I've created a simple API with three separate layers: Representation, Domain and Data. They are all could be evolve separatelly and allow to be enhanced in various ways. 

Representation 
consists of two projects: MusicApi.Representation and MusicApi. MusicApi.Representation is having interfaces, view models and mapping profile to map objects from domain to view model objects. MusicApi purpose solely to interprete the incomming requests, handover it to domain services and interprete the response into a view model. MusicApi also is a startup project, so it will contain setup preferences: IoC initialization, appsettings etc. 

Domain
consists of two projects: MusicApi.Domain and MusicApi.DomainTests. Domain is having all the details about the business logic which needs to reflect business requirements. All of these requirements are needs to be covered by unit tests, which could be found in DomainTests. The DomainTests projects is having a dedicated builder for each service target from the domain. This allow to make unit test small and convenient. Also DomainTests is having mapping configuration tests for each layer. 

Data
consists of three projects: MusicApi.Data, MusicApi.DataEF and MusicApi.DataMocks. Data is having all the necessary interfaces and data model. This dedicated project will represents the data for the domain and its main goal is to hide techincal details from different sources. For example Data could be interpreted by LastFM, iTunes or any other data source. DataEF represents an entity framework source. This projects contains variuos details which I would like to incapsulate: many-to-many connections and their necessities in ef model, migration details, data acquisition etc. The differences between Data and DataEF are covered by the mapping configuration in this project. DataMock purpose is to simulate any data source. 

# Things to improve
- representation models could have Request and Response suffix to separate them from one each other
- cover domain interfaces with unit tests. at this moment all the tests seems to be trivial and not pose any interests for me. 
- use MusicApi.DataMocks in unit tests. it will helps to display various usecases
- add unit tests which will covers mapping strategies and possible issues
- change the columns, entities names, constraints etc in more pleasent way in ef.
- add completely different data source such as LastFM and map responses to Data. it will require instantiation of environment variables for the secrets or vault
- add integration tests which will display which source is up and is everything ready to work with it: EV, vault, configs, endpoints, etc
- add elastic search as log target. elastic search is far more superior, especially with text search, than plain text .log file
- add some CMS for the settings and/or content/titles, for example Episerver. This will display how flexible this solution design is
- add healthchecks for the api it self

# Start
1. Use install.bat in the root.
2. Open https://localhost:5001/swagger/index.html

task description: https://i.imgur.com/LIDSsni.jpg
