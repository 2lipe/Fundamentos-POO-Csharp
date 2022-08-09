using POO.NotificationContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Context
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
