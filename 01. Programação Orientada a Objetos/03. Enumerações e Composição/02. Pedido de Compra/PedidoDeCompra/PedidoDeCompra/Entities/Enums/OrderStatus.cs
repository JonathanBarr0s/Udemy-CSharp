﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidoDeCompra.Entities.Enums {
    internal enum OrderStatus {
        PendingPayment,
        Processing,
        Shipped,
        Delivered
    }
}
