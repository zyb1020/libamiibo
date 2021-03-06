﻿using LibAmiibo.Encryption;
using LibAmiibo.Properties;

namespace LibAmiibo
{
    static class Files
    {
        public static AmiiboKeys AmiiboKeys => AmiiboKeys.LoadKeys(Settings.Default.AmiiboKeys);

        public static CDNKeys CDNKeys => CDNKeys.LoadKeys(Settings.Default.CDNKeys);
    }
}
