using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
namespace RSOD.Models;
public class Game
{
    public int Id { get; set; }
    [Display(Name = "�������� ����")]
    public string Name { get; set; }
    [Display(Name = "��������")]
    public string Summary { get; set; }
    [Display(Name = "����")]
    public string Photo { get; set; }
    [Display(Name = "������ �� ���������� �� ��������")]
    public int MetacriticPro { get; set; }
    [Display(Name = "������ �� ���������� �� �������������")]
    public int MetacriticUser { get; set; }
    [Display(Name = "������ �� ��������")]
    public string StopGame { get; set; }
    [Display(Name = "���� ��������")]
    public DateTime CreatedData { get; set; } = DateTime.Now;
}