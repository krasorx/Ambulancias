using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulancias
{
    class Emergency
    {
        private int tipo;
        private DateTime dateTime;
        private String direction;
        private int clientCode;

        public Emergency()
        {
        }
        public Emergency(int unTipo,DateTime aDate,String aDir,int aCode)
        {
            SetTipo(unTipo);
            SetDate(aDate);
            SetDirection(aDir);
            SetCode(aCode);
        }
        public int Tipo { get; set; }
        public int ClientCode { get; set; }
        public DateTime DateTime { get; set; }
        public String Direction { get; set; }
        public int GetTipo()
        {
            return tipo;
        }
        public void SetTipo(int unTipo)
        {
            tipo = unTipo;
        }
        public DateTime GetDate()
        {
            return dateTime;
        }
        public void SetDate(DateTime aDate)
        {
            dateTime = aDate;
        }
       public String GetDirection()
        {
            return direction;
        }
        public void SetDirection(String aDir)
        {
            direction = aDir;
        }
        public int GetCode()
        {
            return clientCode;
        }
        public void SetCode(int aCode)
        {
            clientCode = aCode;
        }
    }
}
