using Nancy;
using WordCounter.Objects;

namespace WordCounter
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                return View["index.cshtml"];
            };

            Post["/count"] = _ => {
                string userString = Request.Form["user-input-string"];
                string userWord = Request.Form["user-input-word"];
                RepeatCounter newCount = new RepeatCounter(userString, userWord);
                return View["count.cshtml", newCount];
            };
        }
    }
}
