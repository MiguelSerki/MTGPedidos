using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGRosarioPedidos
{
    public class Carta
    {
        public float precio;
        public int cantidad;
        public int totalGrupal;
        public string expansion;
        public string nombre;
        public string link;

        public void updateTotal()
        {
            this.totalGrupal = (int)precio * cantidad;
        }
    }
}
