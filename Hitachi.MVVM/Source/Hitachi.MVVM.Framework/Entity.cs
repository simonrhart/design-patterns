using System;

namespace Hitachi.MVVM.Framework
{
    public class Entity : IEntity, IAuditable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Entity&lt;TKey&gt;"/> class.
        /// </summary>
        public Entity()
        {
            CreatedOn = DateTime.Now;
            ChangedOn = DateTime.Now;
        }

        #region IAuditable Members

        public virtual DateTime ChangedOn { get; set; }

        public virtual string ChangedBy { get; set; }

        public virtual DateTime CreatedOn { get; set; }

        public virtual string CreatedBy { get; set; }

        #endregion

        #region IEntity<TKey> Members


        public virtual int Id { get; set; }

        public virtual bool IsTransient
        {
            get 
            {
                return Id == 0;
            }
        }
        #endregion
    }

}
