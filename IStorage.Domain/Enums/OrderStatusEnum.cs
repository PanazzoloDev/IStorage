namespace IStorage.Domain.Enums
{
    public enum OrderStatusEnum
    {   
        /// <summary>
        /// Pedido aberto
        /// </summary>
        Opened = 1,

        /// <summary>
        /// Pedido fechado
        /// </summary>
        Closed = 2,

        /// <summary>
        /// Pedido em preparo
        /// </summary>
        Manufaturing = 3,

        /// <summary>
        /// Pedido em entrega
        /// </summary>
        Delivering = 4
    }
}