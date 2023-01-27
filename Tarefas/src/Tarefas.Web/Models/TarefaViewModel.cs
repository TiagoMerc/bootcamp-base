using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Tarefas.Web.Models;

public class TarefaViewModel
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "O título da tarefa deve ser preenchida.")]
    [MinLength(3, ErrorMessage = "O título deve ter no mínimo 3 caracteres.")]
    [DisplayName("Título")]    
    public string? Titulo { get; set; }        
    
    [Required(ErrorMessage = "A descrição da tarefa deve ser preenchida.")]
    [MinLength(5, ErrorMessage = "A descrição deve ter no mínimo 5 caracteres.")]
    [DisplayName("Descrição")]    
    public string? Descricao { get; set; }  

    [Required(ErrorMessage = "O status da tarefa deve ser preenchida.")]
    [DisplayName("Concluída")]
    public bool Concluida { get; set; }
}