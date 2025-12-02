![Banner](.github/banner.png)
[![NuGet Version](https://img.shields.io/nuget/v/EntitiesDb.svg)](https://www.nuget.org/packages/EntitiesDb)
[![NuGet Downloads](https://img.shields.io/nuget/dt/EntitiesDb.svg)](https://www.nuget.org/packages/EntitiesDb)


### A High-Performance, Lightweight C# Entity Component System

A modern, cache-efficient **Entity Component System (ECS)** designed for games, simulations, and other data-oriented workloads.
EntitiesDb focuses on **raw performance**, **simple APIs**, and **zero external dependencies** — all within pure C#.

* **🚀 Fast** — Chunk-based, archetype-organized storage with SIMD-friendly handles
* **🧩 Simple** — Define any type as a component and query with expressive filters
* **📦 Self-Contained** — Multiple isolated databases/worlds
* **🧵 Parallel-Ready** — Built-in multithreaded query execution and reduction
* **0️⃣ GC-Friendly** — Minimal allocations, predictable memory layout

---

# Quick Start

```csharp
using EntitiesDb;

// Define components
public record struct Position(float X, float Y);
public record struct Velocity(float Dx, float Dy);
public record struct Health(int Points, int Max);

// Create database
using var db = new EntityDatabase();

// Create an entity
var player = db.Create(
    new Position(10, 10),
    new Velocity(5, 5),
    new Health(100, 100)
);

// Build a query
var query = db.QueryBuilder
    .WithAll<Position, Velocity>()
    .Build();

// Update all matching entities
query.ForEach((ref Position pos, in Velocity vel) =>
{
    pos.X += vel.Dx;
    pos.Y += vel.Dy;
});
```

---

# Installation

Install via NuGet:

### Package Manager
```
Install-Package EntitiesDb
```

### .NET CLI
```
dotnet add package EntitiesDb
````

### Package Reference
```xml
<ItemGroup>
  <PackageReference Include="EntitiesDb" Version="*" />
</ItemGroup>
```

---

# Documentation

Looking for the full API, examples, and advanced usage?

📚 **Docs:** [DOCS.md](./DOCS.md)  
🧩 Includes: components, queries, buffers, tags, multithreading, SIMD, and more.

---

# License

MIT License.
Feel free to use EntitiesDb in commercial or open-source projects.