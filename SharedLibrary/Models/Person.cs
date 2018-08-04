using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharedLibrary.Models
{
    public class Person : INotifyPropertyChanged
    {
        string _name;
        DateTime _birthdate;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// プロパティ変更を通知するメソッド
        /// </summary>
        /// <param name="propertyName">プロパティ名。省略された場合はCallerMemberName属性によって呼び出し元のメンバ名が自動で代入されます</param>
        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Person() { }

        public Person(string name, DateTime birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

        /// <summary>
        /// 名前
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (value == _name) return;
                _name = value;
                RaisePropertyChanged();
            }
        }
        
        /// <summary>
        /// 年齢
        /// </summary>
        public int Age
        {
            get
            {
                TimeSpan delta = DateTime.Now - Birthdate;
                double age = delta.TotalDays / 365;
                return (int)age;
            }
        }
        
        /// <summary>
        /// 生年月日
        /// </summary>
        public DateTime Birthdate
        {
            get => _birthdate;
            set
            {
                if (value == _birthdate) return;
                _birthdate = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(Age));
            }
        }
    }
}
