namespace WebApplication1.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging
open WebApplication1
open FSharp.Data
open System.Text.Json

[<ApiController>]
[<Route("[controller]")>]
type testController (logger: ILogger<testController>) = 
    inherit ControllerBase()

    let returnList = 
        [|
            "test"
            "test2"
        |]

    let human = { FullName = "Jesper Baltzersen" ; Age = 21}

    [<HttpGet>]
    member _.Get() =
        let data = JsonSerializer.Serialize human
        data

            