﻿using System.ComponentModel;

namespace SonicNextModManager
{
    public class Metadata : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// The title of this content.
        /// </summary>
        [Category("Metadata")]
        public string? Title { get; set; }

        /// <summary>
        /// The author of this content.
        /// </summary>
        [Category("Metadata")]
        public string? Author { get; set; }

        /// <summary>
        /// The platform this content is targeting.
        /// </summary>
        [Category("Metadata")]
        public Platform Platform { get; set; }

        /// <summary>
        /// The date this content was created on.
        /// </summary>
        [Category("Metadata")]
        public string? Date { get; set; }

        /// <summary>
        /// Initialiser for <see cref="Description"/>.
        /// </summary>
        private string? _Description;

        /// <summary>
        /// The description of this content.
        /// </summary>
        [Category("Metadata")]
        public string? Description
        {
            get => _Description?.Replace("\\n", Environment.NewLine);

            set => _Description = value;
        }

        /// <summary>
        /// The path to the thumbnail used by this content.
        /// </summary>
        public string? Thumbnail { get; set; }

        /// <summary>
        /// Determines if this content is enabled.
        /// </summary>
        [JsonIgnore]
        [Browsable(false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Determines if this content's information is being displayed.
        /// </summary>
        [JsonIgnore]
        [Browsable(false)]
        public bool InfoDisplay { get; set; }

        /// <summary>
        /// The state of this content's installation process.
        /// </summary>
        [JsonIgnore]
        [Browsable(false)]
        public InstallState State { get; set; }

        /// <summary>
        /// The path to this content.
        /// </summary>
        [JsonIgnore]
        [Browsable(false)]
        public string? Path { get; set; }
    }
}
