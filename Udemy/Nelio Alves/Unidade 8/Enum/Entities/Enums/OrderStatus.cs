using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum.Entities.Enums
{
    enum OrderStatus
    {
        //uma vez que não é atribuído um valor, o C# atribui um valor inteiro incremental 
        //para cada elemento, começando com o número 0
        PendingPayment,
        Processing,
        Shipped,
        Delivered
    }

}
