﻿using System;

namespace BELibrary.Entity
{
    public class Attachment
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Type { get; set; }

        public string Url { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string ModifiedBy { get; set; }
    }
}