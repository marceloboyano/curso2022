using ApiDapper.Data;
using ApiDapper.Models;

namespace ApiDapper.Rules
{
    public class OrderRule
    {
        public List<Order> GetAllOrders()
        {
            var data = new NorthwindData();
            return data.GetAllOrders();

        }
        public RespuestaDelete DeleteOrderById(int orderId)
        {
            try
            {
                var data = new NorthwindData();
                var cant = data.DeleteOrderById(orderId);
                return new RespuestaDelete()
                {
                    Cantidad = cant,
                };
            }
            catch(Exception ex)
            {
                return new RespuestaDelete()
                {
                    Cantidad = 0,
                    Result = false,
                    Mensaje = ex.Message,
                };
            }
         
        }
    }
}
