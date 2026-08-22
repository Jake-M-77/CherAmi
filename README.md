# CherAmi

CherAmi is a command-line messaging application written in C# and .NET.

The project is inspired by the messaging and communication systems seen in *Nikita*, and is being developed as a practical exploration of networking, message processing, command-driven applications, and client/server architecture.

> **Status:** 🚧 In Development
> CherAmi is an ongoing project and its architecture and functionality are expected to evolve.

## Overview

CherAmi currently provides the foundations of a command-line messaging system.

The application is built around a client/server architecture using TCP networking. A CherAmi instance can currently be started as either a server or a client, allowing the two sides to establish a TCP connection and interact through the command-line shell.

The project is being developed incrementally, with the current focus on establishing the underlying communication pipeline before building out higher-level messaging functionality.

## Current Features

* Command-line interface
* Interactive shell
* Command parsing and routing
* Command abstraction
* TCP server
* TCP client
* Client/server connection management
* Message processing components
* Message queue
* Message delivery components
* Basic server/client operating modes

## Technology

* **C#**
* **.NET 8**
* **TCP/IP networking**
* **.NET console application**

The project targets `net8.0` and uses nullable reference types and implicit usings.

## Architecture

CherAmi is organised into several areas, each responsible for a specific part of the application:

```text
src/
└── CherAmi/
    ├── Commands/
    │   ├── ExitCommand.cs
    │   ├── ICommand.cs
    │   └── MessageCommand.cs
    │
    ├── Models/
    │
    ├── Networking/
    │   ├── TcpClientConnection.cs
    │   └── TcpServer.cs
    │
    ├── Processor/
    │   ├── MessageDeliverer.cs
    │   ├── MessageProcessor.cs
    │   └── MessageQueue.cs
    │
    ├── Shell/
    │   ├── CommandParser.cs
    │   ├── CommandRouter.cs
    │   └── ShellEngine.cs
    │
    ├── App.cs
    └── Program.cs
```

The repository currently separates the command system, shell, networking, and message-processing responsibilities into their own areas.

### Application Flow

The intended architecture is centred around a pipeline similar to:

```text
User Input
    ↓
Shell
    ↓
Command Parser
    ↓
Command Router
    ↓
Command
    ↓
Message Processing
    ↓
Networking
    ↓
TCP Connection
```

The exact responsibilities of these components will continue to develop as the project progresses.

## Running CherAmi

### Prerequisites

You will need:

* [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
* Git

### Clone the Repository

```bash
git clone https://github.com/Jake-M-77/CherAmi.git
cd CherAmi
```

### Build the Project

```bash
dotnet build
```

### Run the Application

```bash
dotnet run --project src/CherAmi
```

When the application starts, it currently provides a choice between server and client mode:

```text
Select mode:
1. Server
2. Client (hit enter to continue as client)
>>>
```

The current implementation starts the TCP server on `127.0.0.1:5000` when server mode is selected. Client mode connects to the same endpoint.

### Running a Local Client/Server

To experiment with the current networking implementation:

1. Start one instance of CherAmi.
2. Select **Server** mode.
3. Start a second instance.
4. Select **Client** mode.
5. The client will attempt to connect to the server on `127.0.0.1:5000`.

The current networking implementation is intended for local development and experimentation while the messaging architecture is being developed.

## Project Structure

### `Commands`

Contains the application's command abstractions and concrete commands.

The current project includes:

* `ICommand` — command abstraction
* `ExitCommand` — exits the shell
* `MessageCommand` — message-related command functionality

### `Models`

Contains models used by the application and its messaging infrastructure.

### `Networking`

Contains the TCP networking layer.

* `TcpServer` — manages the server-side TCP connection
* `TcpClientConnection` — manages the client-side TCP connection

### `Processor`

Contains the components responsible for processing and delivering messages.

* `MessageProcessor`
* `MessageQueue`
* `MessageDeliverer`

### `Shell`

Contains the command-line shell infrastructure.

* `ShellEngine` — manages the interactive shell
* `CommandParser` — parses user input
* `CommandRouter` — determines how commands are handled

## Development Status

CherAmi is being developed incrementally.

The current implementation establishes the foundations for:

* A command-driven CLI
* TCP client/server communication
* Message processing
* Message queuing
* Message delivery

Higher-level messaging functionality and the final communication architecture are still being developed.

Because the project is actively evolving, implementation details and interfaces may change as new phases of development are completed.

## Goals

The long-term goal of CherAmi is to develop a functional command-line messaging system while exploring the engineering challenges involved in building one.

Areas of development include:

* Client/server communication
* Message exchange
* Message serialisation
* Protocol design
* Message processing
* Message delivery
* Command handling
* Connection management
* Error handling
* Extensible application architecture

## Learning Objectives

CherAmi is also a practical learning project focused on developing experience with:

* C# and .NET
* Object-oriented design
* SOLID principles
* Separation of concerns
* Networking with TCP
* Streams and asynchronous programming
* Client/server architecture
* Message-oriented systems
* Command-based application design
* Designing application protocols

## Contributing

CherAmi is currently a personal development project.

The architecture and implementation are still evolving, so contributions, suggestions, and discussions may be considered as the project develops.

## License

No license has currently been specified for this repository.

---

**CherAmi** — A command-line messaging system built from the ground up in C#.
