using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xenko.Core.Mathematics;
using Xenko.Input;
using Xenko.Engine;
using Xenko.Audio;

namespace MusicExample
{
    public class BasicMusic : SyncScript
    {
        private SoundInstance musicInstance;
        public Sound testSong;

        public override void Start()
        {
            base.Start();
            musicInstance = testSong.CreateInstance();
        }

        public override void Update()
        {
            musicInstance.Play();
        }
    }
}
