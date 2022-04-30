﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Extensoes
{
    public static class ListExtensoes
    {

        public static void AdicionarVarios<T>(this List<T> lista, params T [] itens)
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }

        static void Teste()
        {
            List<int> idades = new List<int> ();

            idades.Add(14);
            idades.Add(50);
            idades.Add(20);

            ListExtensoes.AdicionarVarios (idades, 2, 3,4);

        }

    }
}
