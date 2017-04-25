using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Proyecto.Logic
{
    class OrderL
    {
        public OrderL()
        { }
        public string updateOrderState(string state, int orderNum)
        { 
            string answer = "";
            OrderD oOrderD = new OrderD();
            oOrderD.updatedState(state, orderNum);
            if (oOrderD.Error)
            {
                answer = "Error insertando datos" + oOrderD.ErrorMsg;
            }
            else
            {
                answer = "Estado modificado exitosamente";
            }
            return answer;
        }

        public string deleteOrder(int orderNum)
        {
            string answer = "";
            OrderD oOrderD = new OrderD();
            if (oOrderD.deleteOrder(orderNum))
            {
                answer = "Orden eliminada exitosamente";
            }
            else
            {
                answer = "Error al elimimar orden: " + oOrderD.ErrorMsg;
            }
            return answer;
        }
    }
}
