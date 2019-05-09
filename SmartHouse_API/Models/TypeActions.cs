﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouse_API.Models
{
    public class TypeActions
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Type { get; set; }

        public ICollection<string> AvailableActions { get; set; }
    }
}