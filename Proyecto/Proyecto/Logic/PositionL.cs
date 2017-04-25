using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using Model;

namespace Proyecto.Logic
{
    class PositionL
    {
        public PositionL()
        {
        }
        public string addPosition(int positionCod, string description, string positionType)
        {
            string answer = "";
            PositionD oPositionD = new PositionD();
            PositionE oPositionE = new PositionE(positionCod, description, positionType);
            oPositionD.insertPositions(oPositionE);
            if (oPositionD.Error)
            {
                answer = "Error insertando los datos: " + oPositionD.ErrorMsg;
            }
            else
            {
                answer = "Posición insertada exitosamente";
            }
            return answer;
        }

        public string editPosition(int positionCod, string description, string positionType, int parameterCod)
        {
            string answer = "";
            PositionD oPositionD = new PositionD();
            PositionE oPositionE = new PositionE(positionCod, description, positionType);
            if (oPositionD.updatePosition(oPositionE, parameterCod))
            {
                answer = "Posición editada exitosamente";
            }
            else
            {           
                answer = "Error editando los datos: " + oPositionD.ErrorMsg;
            }
            return answer;
        }

        public string deletePosition(int id)
        {
            string answer = "";
            PositionD oPositionD = new PositionD();
            if (oPositionD.deletePosition(id))
            {
                answer = "Posición eliminada exitosamente";
            }
            else
            {
                answer = "Error eliminando los datos: " + oPositionD.ErrorMsg;
            }
            return answer;
        }
    }
}
