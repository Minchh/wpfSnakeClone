﻿using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace SnakeWPF
{
    public static class Images
    {
        public static readonly ImageSource Empty = LoadImage("Empty.png");
        public static readonly ImageSource Body = LoadImage("Body.png");
        public static readonly ImageSource Head = LoadImage("Head.png");
        public static readonly ImageSource Food = LoadImage("Food.png");
        public static readonly ImageSource DeadBody = LoadImage("DeadBody.png");
        public static readonly ImageSource DeadHead = LoadImage("DeadHead.png");

        private static ImageSource LoadImage(string fileName)
            => new BitmapImage(new Uri($"Assets/{fileName}", UriKind.Relative));
    }
}
