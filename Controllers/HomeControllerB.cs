using Microsoft.AspNetCore.Mvc;
public class  HomeControllerB:Controller{
    public IActionResult Index()
    {
        return Ok("This is the index of the HomeControllerB");
    }
    public IActionResult Quote()
    {
        return Ok("This is the HomeControllerB quote");
    }
}