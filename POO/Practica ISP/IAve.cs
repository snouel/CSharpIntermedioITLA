using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_ISP
{
    interface IAveVoladora
    {
        void Volar();
    }

    interface IAveCantora
    {
        void Cantar();
    }

    interface IAvePonedora
    {
        void PonerHuevos();
    }

    interface IAveNadadora
    {
        void Nadar();
    }

    interface IAveCazadora
    {
        void Cazar();
    }
}
