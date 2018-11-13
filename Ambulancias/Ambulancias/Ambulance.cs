using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulancias
{
    class Ambulance
    {
        // emergencias atendidas
        private int index;
        private String nombre;
        private List<Emergency> emergencies;

        public Ambulance(int aIndex)
        {
            SetIndex(aIndex);
            nombre = "Ambulancia " + index;
        }

        public void SetIndex(int aIndex)
        {
            index = aIndex;
        }

        public String Nombre
        {
            get
            {
                return nombre;
            }
        }
        public int Index
        {
            get
            {
                return index;
            }
        }

        public List<Emergency> Emergencies
        {
            get
            {
                return emergencies;
            }
        }

        public void LoadEmergencies(int unTipo, DateTime dateTime,String aDir,int aCode)
        {
            new List<Emergency>()
            {
                new Emergency{Tipo = unTipo,DateTime = dateTime, Direction = aDir, ClientCode=aCode}
            };
        }
    }
}
