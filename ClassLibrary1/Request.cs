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

        public bool isValid
        {
            get
            {
                if (Key == string.Empty) return false;
                if (Airplane.Model == string.Empty) return false;
                if (Airplane.Manufacturer == string.Empty) return false;
                return true;
            }
        }
    }
}
