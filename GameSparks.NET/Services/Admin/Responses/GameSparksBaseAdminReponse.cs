﻿using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Admin.Responses
{
    public class GameSparksBaseAdminReponse : GameSparksBaseResponse
    {
        [JsonProperty("scriptData")]
        public dynamic ScriptData { get; set; }
    }
}
