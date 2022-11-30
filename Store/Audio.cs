using System;

namespace Store
{
    public class Audio : Disk
    {
        private string artist;
        private string recordingStudio;
        private int songsNumber;

        public Audio(string artist, string recordingStudio, int songsNumber, string Name, string Genre) : base(Name,
            Genre)
        {
            this.artist = artist;
            this.recordingStudio = recordingStudio;
            this.songsNumber = songsNumber;
            this.Name = Name;
            this.Genre = Genre;
        }

        public override int DiskSize 
        { 
            get => songsNumber * 8;
            set { songsNumber = value; }
        }

        public override void Burn(params string[] values)
        {
            artist = values[0];
            recordingStudio = values[1];
            Name = values[2];
            Genre = values[3];
            burnCount++;
        }

        public override string ToString()
        {
            return ("Название: " + Name +
                    "\nЖанр: " + Genre +
                    "\nИсполнитель" + artist +
                    "\nСтудия звукозаписи: " + recordingStudio +
                    "\nКоличество песен: " + songsNumber +
                    "\nКоличество прожигов: " + burnCount);
        }
    }
}