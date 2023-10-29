namespace ClassLibraryBackend
{
    /// <summary>
    /// Ответ
    /// </summary>
    public class Response
    {
        /// <summary>
        /// Сообщение об ошибке
        /// </summary>
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// Статус выполнения
        /// </summary>
        public bool isSuccess { get; set; }
        /// <summary>
        /// Ключ
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// Объект
        /// </summary>
        public Airplane? Airplane { get; set; }
    }
}
