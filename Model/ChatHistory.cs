﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class ChatHistory
    {
        public int Sender { get; set; }

        public int Receiver { get; set; }

        public string Message { get; set; }

        public DateTime Time { get; set; }
    }
}
