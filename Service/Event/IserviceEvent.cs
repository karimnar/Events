﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Service
{
    public interface IserviceEvent
    {
        void edit_event(Event _event);
        void delete_event(Event _event);
        void create_event(Event _event);
    }
}
