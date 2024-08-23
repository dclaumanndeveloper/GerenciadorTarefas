using System.ComponentModel.DataAnnotations;

namespace GerenciadorTarefas.Models;

public class Tarefa
{
    [Key]
    public int ID{get;set;}

    public string Titulo{get;set;}
    public string Descricao{get;set;}
    public string Status{get;set;}


}
