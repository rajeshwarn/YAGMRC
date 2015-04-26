﻿using SQLite.Net.Attributes;
using System;

namespace YAGMRC.Core.Model.SQL.GameDB
{
    [Table("Players")]
    public class PlayersTable
    {
        [PrimaryKey, AutoIncrement]
        public Guid ID { get; set; }

        public string Name { get; set; }

        public string EMail { get; set; }
    }
}