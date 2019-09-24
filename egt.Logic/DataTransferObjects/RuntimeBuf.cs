﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egt.Logic.DataTransferObjects
{
    public class RuntimeBufInfo
    {
        public int Id { get; set; }
        public PlayerInfo Player { get; set; }
        public BuffInfo Buff { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
