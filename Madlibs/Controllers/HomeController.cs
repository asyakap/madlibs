using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Homepage() { return View(); }
    
    
    [Route("/scary-story")]
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

    [Route("/charming-story")]
    public ActionResult CharmForm() { return View(); }

    [Route("/story1")]
    public ActionResult Story1(string noun1, string noun2, string noun3, string noun4, string noun5, string noun6, string noun7, string adj1, string adj2, string adj3, string adj4, string verb1, string verb2, string verb3, string exclamation1)
    {
      Story1Variable myStory1Variable = new Story1Variable();
      myStory1Variable.Noun1 = noun1;
      myStory1Variable.Noun2 = noun2;
      myStory1Variable.Noun3 = noun3;
      myStory1Variable.Noun4 = noun4;
      myStory1Variable.Noun5 = noun5;
      myStory1Variable.Noun6 = noun6;
      myStory1Variable.Noun7 = noun7;
      myStory1Variable.Adj1 = adj1;
      myStory1Variable.Adj2 = adj2;
      myStory1Variable.Adj3 = adj3;
      myStory1Variable.Adj4 = adj4;
      myStory1Variable.Verb1 = verb1;
      myStory1Variable.Verb2 = verb2;
      myStory1Variable.Verb3 = verb3;
      myStory1Variable.Exclamation1 = exclamation1;
      return View(myStory1Variable);
    }
  }
}