namespace Project_Plutus.Controllers

open Microsoft.AspNetCore.Mvc

[<ApiController>]
[<Route("[controller]")>]
type UtilsController() =
    inherit ControllerBase()

    [<HttpGet("guid")>]
    member this.GetGuid() =
        let guid = System.Guid.NewGuid()
        this.Ok(guid)
