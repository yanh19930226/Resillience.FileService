﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Resillience.FileService.Service.Models.Result
{
    public class IdData
    {
        public IdData()
        {
        }

        public IdData(int id)
        {
            this.Id = id;
        }

        public int Id { get; set; }
    }
}
