namespace IStorage.Domain.Enums
{
    /// <summary>
    /// Tipos de movimentos possíveis para insumos
    /// </summary>
    public enum MovementTypeEnum
    {
        /// <summary>
        /// Movimentos de entrada
        /// Ex.: Compras
        /// </summary>
        Entry = 1,
        /// <summary>
        /// Movimentos de saída
        /// Ex.: Consumo
        /// </summary>
        Outgoing = 2,
        /// <summary>
        /// Movimentos de transferencias
        /// Ex.: Reservas2
        /// </summary>
        Transference = 3,
    }
}