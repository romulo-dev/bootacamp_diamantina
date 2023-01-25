using Microsoft.AspNetCore.Mvc;
using Tarefas.Web.Models;

namespace Tarefas.Web.Controllers;
    public class TarefasController : Controller{
    public List<TarefaViewModel> listaDeTarefas {get; set;}
    public TarefasController (){
         listaDeTarefas = new List<TarefaViewModel>(){
            new TarefaViewModel(){Id = 1, Titulo = "Escovar os dentes", Descricao="usar sensodine"},
            new TarefaViewModel(){Id = 2, Titulo = "Escovar os dentes", Descricao="usar sensodine"},
        };
    }   
    public IActionResult Create(){
        return View();
    }
    public IActionResult Index(){
        // var listaDeTarefas = new List<TarefaViewModel>(){
        //     new TarefaViewModel(){Id = 1, Titulo = "Escovar os dentes", Descricao="usar sensodine"},
        //     new TarefaViewModel(){Id = 2, Titulo = "Escovar os dentes", Descricao="usar sensodine"},
        // };
        return View(listaDeTarefas);
    }

    public IActionResult Details(int id){
        var tarefa = listaDeTarefas.Find(tarefa => tarefa.Id == id);
        return View(tarefa);
    }

}


