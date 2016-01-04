using System;
using static System.Console;

namespace slogan
{
    class Program
    {
        static String[] slogans = {
            "Mit {0} hast die Welt verstanden.",
            "Wer {0} hat, hat's leichter.",
            "{0} ist ein Hit", "Sonntag ist {0} Tag.",
            "Die Welt mit {0} sehen.",
            "Lecker. Locker. {0}.",
            "{0} - Aufregend anders.",
            "{0} - You see this name, you think dirty.",
            "Hoffentlich ist es {0}.",
            "{0} ist Mamis Liebling",
            "{0} for Living.",
            "Wo {0} noch von Herzen kommt.",
            "{0} auf Mission",
            "{0} - Hinterher weiß man mehr.",
            "The Future of {0}.",
            "{0} kann jeder gut gebrauchen.",
            "Wo ist {0} ???",
            "The Spirit of {0}.",
            "{0} - Das Gute daran ist das Gute darin.",
            "{0} 4U!",
            "Be free - do it's like {0}!",
            "{0} ist Ausdruck von Individualismus.",
            "{0} inside you.",
            "{0} makes you better.",
            "Don't miss the track. Go with {0}.",
            "{0} - Einfach genial.",
            "Freu dich auf {0}.",
            "{0} is my sport.",
            "Be part of {0}.",
            "{0} makes you happy."
        };

        static void Main(string[] args)
        {
            String s = "";
            if (args.Length > 0)
            {
                s = args[0];
                for (int i = 1; i < args.Length; i++)
                {
                    s += " " + args[i];
                }
            }
            int rand = (new Random()).Next(slogans.Length);
            WriteLine(String.Format(slogans[rand], s));
        }
    }
}
