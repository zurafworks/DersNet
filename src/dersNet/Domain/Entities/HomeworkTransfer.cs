using Domain.Enums;
using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class HomeworkTransfer : Entity<Guid>
{
    /// <summary>
    /// Verilen ödev
    /// </summary>
    public int HomeworkId { get; set; }//verilen ödev

    /// <summary>
    /// Ödevin muhatabı öğrenci
    /// </summary>
    public int StudentId { get; set; }//ödevi yapması gereken öğrenci

    /// <summary>
    /// Teslim durumu (enum) 
    /// </summary>
    public SubmissionStatus Status { get; set; }//teslim edildi - geç teslim edildi - teslim edilmedi
    [StringLength(500)]
    public string Description { get; set; }

    /// <summary>
    /// Ödev dosyası
    /// </summary>
    public string Attachment { get; set; }//veritabanında IFromFile tutulmaz, string tutulur.

    /// <summary>
    /// Veriliş tarihi
    /// </summary>
    public DateTime TransferDate { get; set; }
}
