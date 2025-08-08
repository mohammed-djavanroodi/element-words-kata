# Element Words Kata

An implementation of [Elemental Words](https://www.codewars.com/kata/56fa9cd6da8ca623f9001233/train/csharp). 

# Building the solution

Requirements: 

- .Net Core 8.0+
- Visual Studio 2022 (optional)
- Visual Studio Code (optional)

Clone the repository. 

## Visual Studio

Open `Element Words.sln` with Visual Studio and build the solution by pressing `F6`.

## Command Line

From the repository base open a terminal and run the following command: 

```
dotnet build '.\Element Words.sln'
```

# Running the tests

## Visual Studio

Open `Element Words.sln` with Visual Studio, build the solution and open the Test Explorer to discover and run the tests

## Command Line

From the repsitory base open a terminal and run the following command: 

```
dotnet build '.\Element Words.sln'
dotnet test
```

# Running the command line app

## Visual Studio

Open `Element Words.sln` with Visual Studio, build the solution and debug the `Runner` project.

## Command Line

From the repository base open a terminal and run the following commands: 

```
dotnet build '.\Element Words.sln'
dotnet run --project .\src\Runner\Runner.csproj
```

