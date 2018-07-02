using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Dao : IArchivos<Votacion>
    {

        public Votacion Leer(string nombre)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(string nombre, Votacion objeto)
        {
            try
            {
                return DAOGeneral.InsertaObjeto(string.Format("INSERT INTO {0} (nombreLey, afirmativos, negativos, abstenciones, nombreAlumno) VALUES('{1}',{2},{3},{4},'Gomez Nicolas')", nombre, objeto.NombreLey, objeto.Afirmativos, objeto.Negativos, objeto.Abstenciones));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
