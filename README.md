

Installazione pacchetto:

1. dotnet add package Microsoft.EntityFrameworkCore.SqlServer

2. dotnet tool install --global dotnet-ef  (questo dopo averlo installato la prima volta c''è sempre)

3. dotnet add package Microsoft.EntityFrameworkCore.Design

4. dotnet add package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation -v=6


MIgration:

1. dotnet ef migrations add "nomeclasseiniziale"

2. dotnet ef database update

Errore migration:
// torniamo al punto vuoto dellla migration in caso di errori
1. dotnet ef database update 0
2. dotnet ef migrations remove



//inserito in programs.cs
    builder.Services.AddRazorPages()
    .AddRazorRuntimeCompilation();

    Per utilizzare l'include nei json installare:

    1. dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson --version 6.0.0


    E mettere nel file Program.cs:
    builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});