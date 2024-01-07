﻿using ShikimoriSharp.Classes;
using ShikimoriSharp.Information;

namespace AnimeDesktop.Servises.DSRuler
{
    class ShikiImageRuler : IShikiRuler<List<Anime>>
    {
        public void Rule(List<Anime> animes)
        {
            foreach (Anime anime in animes)
            {
                const string SHIKIURL = "https://shikimori.one";

                anime.Image.Preview = SHIKIURL + anime.Image.Preview;
            }
        }
    }
}