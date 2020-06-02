using System.Collections.Generic;
using System.Windows;

namespace CV19.Models
{
    /// <summary>Базовый класс для стран и провинций</summary>
    internal class PlaceInfo
    {
        /// <summary>Название страны</summary>
        public string Name { get; set; }

        /// <summary>Координаты страны</summary>
        public Point Location { get; set; }

        /// <summary>Количество подтвержденных заражений</summary>
        public IEnumerable<ConfirmedCount> Counts { get; set; }
    }
}
