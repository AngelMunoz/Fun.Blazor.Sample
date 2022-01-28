open System
open Microsoft.AspNetCore.Components.WebAssembly.Hosting
open Microsoft.Extensions.DependencyInjection
open Fun.Blazor.Sample

let builder =
  WebAssemblyHostBuilder.CreateDefault(Environment.GetCommandLineArgs())

builder
  .AddFunBlazorNode("#main", App.View())
  .Services.AddFunBlazor()
|> ignore

builder.Build().RunAsync()
|> Async.AwaitTask
|> Async.Start
