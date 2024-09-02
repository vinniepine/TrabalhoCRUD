using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeCRUD.Models;
internal class Dispositivo
{
    internal int ID { get; set; }
    internal double? Aliquota { get; set; }
    internal string Descricao { get; set; }
    internal bool? Status { get; set; }
}
