using lizykitchen.Models;
using System.Linq;
using System.Web.Mvc;

namespace lizykitchen.Controllers
{
    public class RecipeController : Controller
    {
        lizykitchenDB _db = new lizykitchenDB();

        public ActionResult Autocomplete(string term)
        {
            var model = _db.Recipes
                            .Where(r => r.Title.StartsWith(term))
                            .Take(10)
                            .Select(r => new
                            {
                                label = r.Title
                            });

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        // GET: Recipe
        public ActionResult Index(string searchTerm = null)
        {
            //Old code to fetch data from a collection
            //var model = _db.Recipes.ToList();

            //Comprenhesion query syntax
            //var model = from r in _db.Recipes
            //            orderby r.Title
            //            select r;

            //Extension methods syntax
            var model = _db.Recipes
                .OrderBy(r => r.Title)
                .Where(r => searchTerm == null || r.Title.Contains(searchTerm));

            if (Request.IsAjaxRequest())
            {
                return PartialView("_Recipies", model);
            }

            return View(model);
        }

        //
        //GET: /Recipe/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        //POST: /Recipe/Create
        [HttpPost]
        public ActionResult Create(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                _db.Recipes.Add(recipe);
                _db.SaveChanges();

                return RedirectToAction("Details", new { id = recipe.Id });
            }

            return View(recipe);
        }

        //
        //GET: /Recipe/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _db.Recipes.Find(id);

            return View(model);
        }

        //
        //POST: /Recipe/Edit/5
        [HttpPost]
        public ActionResult Edit(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(recipe).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                return RedirectToAction("Details", new { id = recipe.Id });
            }

            return View(recipe);
        }

        //
        //GET: /Recipe/Delete/5
        public ActionResult Delete(int id)
        {
            Recipe recipe = _db.Recipes.Find(id);

            if (recipe == null)
            {
                return HttpNotFound();
            }

            return View(recipe);
        }

        //POST: /Recipe/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Recipe recipe = _db.Recipes.Find(id);
            _db.Recipes.Remove(recipe);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int Id)
        {
            //OLD code
            //var recipeList = new RecipeList();
            //var model = recipeList.GetById(Id);

            var model = _db.Recipes.Find(Id);

            if (model == null)
            {
                return HttpNotFound();
            }

            return View(model);
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}