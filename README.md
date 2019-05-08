# efcore-ownedentity-delete
A sample .NET Core console app that demonstrates deleting Entities with Owned Types.


## Motivation

To answer this question on SO: [Unable to delete entity which has owned entity in EntityFramework Core](https://stackoverflow.com/questions/56042153/unable-to-delete-entity-which-has-owned-entity-in-entityframework-core)


## Requirements

- SQL Local DB (MSSQLLocalDB)
- .NET Core SDK 2.2.106

## Running the app

- Make sure to create the database: `dotnet ef database update`
- Insert some data in the table `Orders` 


## Inside the app

In `Program.cs` you can find 3 versions of the "deletion" code. 

1. The simpler version, using `DbContext` change tracking in our favor
2. The original, OP code which throws an exception
3. The fixed code, which deletes the entity in a "disconnected scenario" as OP wanted.