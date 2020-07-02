using Microsoft.AspNetCore.Mvc;
using Microsoft.ML.Probabilistic.Models;
using SCManager.ViewModels.BayesianAnalysis;
using System.Threading.Tasks;

namespace SCManager.Controllers
{
    public class BayesianAnalysisController : Controller
    {
        public async Task<IActionResult> Index()
        {
            // TODO Finish this piece

            //string value = null;
            //await Task.Run(() =>
            //{
            //    Variable<bool> firstCoin = Variable.Bernoulli(0.5);
            //    Variable<bool> secondCoin = Variable.Bernoulli(0.5);

            //    Variable<bool> bothHeads = firstCoin & secondCoin;
            //    InferenceEngine engine = new InferenceEngine();

            //    value = engine.Infer(bothHeads).ToString();
            //});
            //var model = new IndexViewModel
            //{
            //    SomeValue = value
            //};
            return View(null);
        }
    }
}