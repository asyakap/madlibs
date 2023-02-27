using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Story()
    {
      StoryVariable myStoryVariable = new StoryVariable();
      return View(myStoryVariable);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/story")]
    public ActionResult Story(string name1, string name2, string animal, string exclamation, string verb, string noun)
    {
      StoryVariable myStoryVariable = new StoryVariable();
      myStoryVariable.Name1 = name1;
      myStoryVariable.Name2 = name2;
      myStoryVariable.Animal = animal;
      myStoryVariable.Exclamation = exclamation;
      myStoryVariable.Verb = verb;
      myStoryVariable.Noun = noun;
      return View(myStoryVariable);
    }
  }
}