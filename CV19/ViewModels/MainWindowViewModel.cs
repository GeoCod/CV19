using System;
using System.Collections.Generic;
using System.Text;
using CV19.ViewModels.Base;

namespace CV19.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _Title = "Анализ статистики CV19";

        #region Заголовок окна
        /// <summary>Заголовок окна</summary>
        public string Title
        {
            get => _Title;
            #region Примеры свойства set
            // Вариант 1. Полный
            //set
            //{
            //    //Если бы не определили в базовой модели, то писали так в каждом свойстве
            //    //if (Equals(_Title, value)) return;
            //    //_Title = value;
            //    //OnPropertyChanged();

            //    Set(ref _Title, value);
            //}

            // Вариант 2. Сокращенный
            //set
            //{
            //    Set(ref _Title, value);
            //} 
            #endregion
            // Вариант 3. Самый аккуратный
            set => Set(ref _Title, value);
        } 
        #endregion
    }
}
