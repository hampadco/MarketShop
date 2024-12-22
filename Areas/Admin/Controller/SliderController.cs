using Microsoft.AspNetCore.Mvc;


namespace Admin;

[Area("Admin")]
public class SliderController:Controller
{


    public IActionResult index()
    {
        // TODO: Your code here
        return View();
    }

  [HttpPost]
    public IActionResult index(List<IFormFile> file)
    {
        // TODO: Your code here
        return View();
    }

    
    
    
    
}