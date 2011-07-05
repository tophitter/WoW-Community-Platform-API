﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCPAPI
{
    [DataContract]
    public class Professions
    {
        [DataMember(Name = "primary")]
        public List<Profession> Primary;
        [DataMember(Name = "secondary")]
        public List<Profession> Secondary;
    }

    [DataContract]
    public class Profession
    {
        [DataMember(Name = "id")]
        public int Id;
        [DataMember(Name = "name")]
        public string Name;
        [DataMember(Name = "icon")]
        public string Icon;
        [DataMember(Name = "rank")]
        public int Rank;
        [DataMember(Name = "max")]
        public int Max;
        [DataMember(Name = "recipes")]
        public List<int> Recipes;
    }
}
