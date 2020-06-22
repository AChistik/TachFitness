using System;


namespace TachFitness.BL.Model
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User
    {
        #region Свойства
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Пол
        /// </summary>
        public Gender Gender { get; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime BirthDate { get; }
        /// <summary>
        /// Вес
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Рост
        /// </summary>
        public double Height { get; set; }
        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"> Имя </param>
        /// <param name="gender"> Пол </param>
        /// <param name="birthdate"> Дата рождения </param>
        /// <param name="weight"> Вес </param>
        /// <param name="height"> Пол </param>
        public User(string name, 
                    Gender gender, 
                    DateTime birthdate, 
                    double weight, 
                    double height)
        {
            #region Проверка условий
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть null", nameof(name));
            }
            
            if(gender == null)
            {
                throw new ArgumentNullException("Пол не может быть null", nameof(gender));
            }

            if(birthdate< DateTime.Parse("01.01.1900") || birthdate>=DateTime.Now)
            {
                throw new ArgumentException("Невозможная дата рождения", nameof(birthdate));
            }

            if(weight<=0)
            {
                throw new ArgumentException("Вес не может быть < либо равен 0", nameof(weight));
            }
            if(height<=0)
            {
                throw new ArgumentException("Рост не может быть меньше либо равен 0", nameof(weight));
            }
            #endregion
            Name = name;
            Gender = gender;
            BirthDate = birthdate;
            Weight = weight;
            this.Height = Height;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
