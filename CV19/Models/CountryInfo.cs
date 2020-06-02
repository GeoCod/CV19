using System.Collections.Generic;

namespace CV19.Models
{
    /// <summary>Информация о стране</summary>
    internal class CountryInfo : PlaceInfo
    {
        /// <summary>Перечисление провинций входящих в страну</summary>
        public IEnumerable<ProvinceInfo> ProvinceCounts { get; set; }
    }
}
