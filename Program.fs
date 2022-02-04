open System
open Microsoft.AspNetCore.Components.WebAssembly.Hosting
open Microsoft.Extensions.DependencyInjection
open Fun.Blazor.Sample

let builder =
  WebAssemblyHostBuilder.CreateDefault(Environment.GetCommandLineArgs())

builder
  .AddFunBlazor("#main", App.View())
  .Services.AddFunBlazorWasm()
|> ignore

builder.Build().RunAsync()
|> Async.AwaitTask
|> Async.Start
