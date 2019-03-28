using Practice.Common;
using Practice.HR.Events;
using System;

namespace Practice.HR
{
    /// <summary>
    ///     Абстрактная база для описания конкретных реализаций типа "Человек".
    ///     Используется для дальнейшего наследования.
    /// </summary>
    internal abstract class AbstractPerson
    {
        /*
         * TODO #3: Реализуйте интерфейс IPerson для класса AbstractPerson
         */

        private IName _name;

        public IName Name
        {
            get { return _name; }

            set
            {
                var args = new ValueChangeEventArgs<IName>(_name);
                _name = value;
                NameChange?.Invoke(this, args);
            }
        }

        public event EventHandler<ValueChangeEventArgs<IName>> NameChange;

    }
}

