using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace CV19.ViewModels.Base
{
    internal abstract class ViewModel : INotifyPropertyChanged
    {
        //INotifyPropertyChanged - интерфейс уведомляющий об изменении свойств, и в случае изменения обновит визуальную часть
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        //[CallerMemberName] автоматом подставит имя метода из которого вызывается
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        /// <summary>Обновляет значение свойства</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="field">ссылка на поле в котором свойство хранит данные</param>
        /// <param name="value">новое значение, которое хотим установить</param>
        /// <param name="PropertyName">Имя метода из которого вызывается</param>
        /// <remarks>флаг bool - показывает, если свойство изменилось, 
        /// то мы можем выполнить еще какую-то работу </remarks>
        /// <returns></returns>
        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyName = null)
        {
            //задача метода - разрешить кольцевое обновление свойств
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(PropertyName);
            return true;
        }
    }
}
