using System;
using ICities;
using UnityEngine;
using System.Collections;
using System.IO;

namespace CSLMusicPack_mrnotsoevil_Collection2
{
    public class CSLMusicPack : IUserMod
    {
        public string Name
        {
            get
            {
                return "Music pack: Tokienoki hit songs (Official)";
            }
        }

        public string Description
        {
            get
            {
                return "Add more music by Tokienoki(jikantoki). He is Japanese vocaloid artist. Needs CSLMusicMod.";
            }
        }
    }
}

