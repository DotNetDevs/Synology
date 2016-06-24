using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Synology.FileStation.Favorite.Results
{
    public class FavoriteResult
    {
        public string Path { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }

        public FavoriteAdditionalResult Additional { get; set; }
    }

}

