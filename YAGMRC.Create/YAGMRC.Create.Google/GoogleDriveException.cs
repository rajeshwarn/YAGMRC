﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAGMRC.Create.Google
{
    public class GoogleDriveException: Exception
    {
        public GoogleDriveException(string message):base(message)
        {

        }
    }
}
