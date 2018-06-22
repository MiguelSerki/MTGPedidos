using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGRosarioPedidos
{
    public class ListaCartas
    {
        public List<Carta> listaCartas = new List<Carta>();
        public int total = 0;

        public void updateTotal()
        {
            foreach (var carta in listaCartas)
            {
                this.total += carta.totalGrupal;
            }
        }

        public List<Carta> getList()
        {
            return this.listaCartas;
        }

        public int getTotal()
        {
            return this.total;
        }
        
    }
}
