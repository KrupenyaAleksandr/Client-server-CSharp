namespace ClassLibraryBackend
{
    /// <summary>
    /// Запрос
    /// </summary>
    public class Request
    {
        /// <summary>
        /// Тип запроса
        /// </summary>
        public RequestType Type { get; set; }
        /// <summary>
        /// Ключ
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// Объект
        /// </summary>
        public Airplane Airplane { get; set; }
    }
}
