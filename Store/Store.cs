using System;

namespace Store
{
    public class Store
    {
        private string storeName;
        private string address;
        private List<Audio> audios = new List<Audio>();
        private List<DVD> dvds = new List<DVD>();

        public Store(string storeName, string address)
        {
            this.storeName = storeName;
            this.address = address;
        }

        public static List<DVD> operator +(Store store, DVD disk)
        {
            store.dvds.Add(disk);
            return store.dvds;
        }
        public static List<DVD> operator -(Store store, DVD disk)
        {
            store.dvds.Remove(disk);
            return store.dvds;
        }
        
        public static List<Audio> operator +(Store store, Audio audio)
        {
            store.audios.Add(audio);
            return store.audios;
        }
        
        public static List<Audio> operator -(Store store, Audio audio)
        {
            store.audios.Remove(audio);
            return store.audios;
        }

        public override string ToString()
        {
            string result_audio = "";
            foreach (Audio au in audios)
            {
                result_audio += au + "\n";
                result_audio += "\n";
            }

            string result_dvd = "";
            foreach (DVD dvd in dvds)
            {
                result_dvd += dvd + "\n";
                result_dvd += "\n";

            }

            return ("Название магазина: " + storeName +
                    "\nАдрес: " + address + "\n" +
                    "\nАудиодиски:\n" + result_audio +
                    "\nФильмы:\n" + result_dvd);
        }
    }
}