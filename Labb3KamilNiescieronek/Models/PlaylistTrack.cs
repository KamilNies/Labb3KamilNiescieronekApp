﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Labb3KamilNiescieronek.Models
{
    public partial class PlaylistTrack
    {
        public int PlaylistId { get; set; }
        public int TrackId { get; set; }

        public virtual Playlist Playlist { get; set; }
        public virtual Track Track { get; set; }
    }
}
