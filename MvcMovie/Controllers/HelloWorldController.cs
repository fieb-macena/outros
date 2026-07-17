using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public string Index()
    {
        return "This is my default action...";
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    public string Welcome(string name, int numTimes = 1, bool teste = false)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}, Teste: {(teste ? "true" : "false")}");
    }
}