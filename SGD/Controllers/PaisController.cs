using Microsoft.AspNetCore.Mvc;
using SGD.Data.Interfaces;
using SGD.Data.Model;
using System.Linq;
using System.Threading.Tasks;

namespace SGD.Controllers
{
    public class PaisController : Controller
    {
        private readonly IPaisRepository _paisRepository;

        public PaisController(IPaisRepository paisRepository)
        {
            _paisRepository = paisRepository;
        }

        #region Listar Todos
        public async Task<IActionResult> Index(string sortOrdery)
        {
            ViewBag.sortOrder = sortOrdery;

            var dados = await _paisRepository.ListarTodosAsync();
            var resultDados = dados.OrderBy(p => p.Nome);


            #region Ordenar Por
            if (sortOrdery == "Asc")
            {
                var listarSortOrdery = resultDados.OrderBy(c => c.Nome);
                return View(listarSortOrdery);
            }
            else if (sortOrdery == "Desc")
            {
                var listarSortOrdery = resultDados.OrderByDescending(c => c.Nome);
                return View(listarSortOrdery);
            }
            else
            {
                var listarSortOrdery = resultDados.OrderBy(c => c.Nome);
                return View(listarSortOrdery);
            }
            #endregion
        }
        #endregion


        #region Detalhe 
        //Get: Pais/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var dados = await _paisRepository.PesquisarPorIdAsync(id);
            if (dados == null) return View("NotFound");
            return View(dados);
        }
        #endregion

        #region Actualizar
        //Get: Pais/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var dados = await _paisRepository.PesquisarPorIdAsync(id);
            if (dados == null) return View("NotFound");
            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Nome")] Pais pais)
        {
            if (!ModelState.IsValid)
            {
                return View(pais);
            }
            await _paisRepository.AtualizarAsync(pais);
            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Cadastrar
        //Get: Pais/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Nome")] Pais pais)
        {
            if (!ModelState.IsValid)
            {
                return View(pais);
            }
            await _paisRepository.CadastrarAsync(pais);
            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region
        /*

        #region Apagar
        //Get: Pais/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var dado = await _pais.PesquisarPorIdAsync(id);
            if (dado == null) return View("NotFound");
            return View(dado);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDelete = await _pais.PesquisarPorIdAsync(id);
            if (actorDelete == null) return View("NotFound");

            //await _pais.ExcluirAsync(id);
            return RedirectToAction(nameof(Index));
        }
        #endregion
         
         */

        #endregion
    }
}
