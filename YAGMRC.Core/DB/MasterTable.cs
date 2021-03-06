﻿using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAGMRC.Core.Model;

namespace YAGMRC.Core.DB
{
    [Table("Master")]
    internal class MasterTable
    {
        [PrimaryKey]
        public Guid GameGuid { get; set; }

        public Guid Me { get; set; }

        public GameType GameType { get; set; }

        public StorageType StorageType { get; set; }

    }
}
