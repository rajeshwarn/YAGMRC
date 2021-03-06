﻿using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YAGMRC.Core.DatabaseModel
{
    [Table("Turn")]
    public class TurnTable
    {
        [PrimaryKey, AutoIncrement]
        public Guid ID { get; set; }

        public int TurnOrder { get; set; }

        public Guid GameID { get; set; }

        public Guid PlayerID { get; set; }
    }
}
