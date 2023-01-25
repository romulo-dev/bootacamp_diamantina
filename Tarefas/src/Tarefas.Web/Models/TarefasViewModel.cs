using System.ComponentModel;

namespace Tarefas.Web.Models;


public class TarefaViewModel{
    public int Id{get; set;}

    [DisplayName("titulo")]
    public string Titulo{ get; set;}
    [DisplayName("Descricao")]
    public string Descricao{ get; set;}
}