## amit "elront" a Scaffolder:

- views mappában a [scaffolded] mappának a neve:
=> egyesszámról -> többesszámra (legyen ua., mint a controller prefixe)

- nincs [Data] folder, a context file a gyökérben van
=> add new folder [Data], majd bele kell mozgatni a context filet [névterek igazításával!]

- az ApplicationDbContextnek.cs-ben a DbSet neve legyen tsz. [REFACTORINGos rename kell!]

- "mindent" ApplicationDbContext-nek nevez el...
=> 
  - appsettings.json
    - JSON tulajdonság: 
    ApplicationDbContext -> DefaultConnection
    - a connection string-ben: ApplicationDbContext -> [MyDatabase]

  - program.cs
    - .GetConnectionString()-ben igazítsuk a változást:
a "ApplicationDbContext" string legyen -> "DefaultConnection"

---
### működéshez:
1) Tools -> Nuget -> open NPM Console
2) PM> add-migration [MyMigration] (Initial, Init, InitialCreate...)
3) update-database

### kényelmes teszteléshez:

add hozzá a navigációhot a ~/[scaffolded controller prefix]/index -et