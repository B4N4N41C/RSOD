using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
namespace RSOD.Models;
public class Game
{
    public int Id { get; set; }
    [Display(Name = "Название игры")]
    public string Name { get; set; }
    [Display(Name = "Описание")]
    public string Summary { get; set; }
    [Display(Name = "Фото")]
    public string Photo { get; set; }
    [Display(Name = "Оценка на Метакритик от критиков")]
    public int MetacriticPro { get; set; }
    [Display(Name = "Оценка на Метакритик от пользователей")]
    public int MetacriticUser { get; set; }
    [Display(Name = "Оценка на СтопГейм")]
    public string StopGame { get; set; }
    [Display(Name = "Дата создания")]
    public DateTime CreatedData { get; set; } = DateTime.Now;
}