using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using CV19.Infrastructure.Commands;
using CV19.ViewModels.Base;

namespace CV19.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Title : string - Заголовок окна
        private string _Title = "Анализ статистики CV19";

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

        #region Status : string - Статус программы
        ///<summary>Статус программы</summary>
        private string _Status = "Готов!";

        /// <summary>Статус программы</summary>
        public string Status
        {
            get => _Status;
            set => Set(ref _Status, value);
        }
        #endregion

        #region Команды

        #region CloseApplicationCommnd

        /// <summary>Команда закрывающая приложение</summary>
        public ICommand CloseApplicationCommnd { get; }

        private bool CanCloseApplicationCommndExecute(object p) => true;

        /// <summary>Запуск в момент когда команда выпоняется</summary>
        /// <param name="p"></param>
        private void OnCloseApplicationCommndExecuted(object p)
        {
            Application.Current.Shutdown();
        } 

        #endregion
        

        #endregion

        public MainWindowViewModel()
        {
            #region Команды

            CloseApplicationCommnd = new LambdaCommand(OnCloseApplicationCommndExecuted, CanCloseApplicationCommndExecute);

            #endregion
        }

    }
}
