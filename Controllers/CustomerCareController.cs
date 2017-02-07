using Microsoft.AspNetCore.Mvc;
[Route("claim")]
public class  CustomerCareController:Controller{
    [RouteAttribute("fileclaim")]
    public IActionResult NewClaim()
    {
        return Ok("This is the new claim CustomerCareController");
    }
    [RouteAttribute("claimstatus")]
    public IActionResult ClaimHistory()
    {
        return Ok("This is the claim history CustomerCareController");
    }
}