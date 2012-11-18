﻿using System;

namespace Switcheroo.Configuration
{
    using System.Configuration;

    /// <summary>
    /// A configuration element for the <see cref="FeatureToggleCollection"/>.
    /// </summary>
    public class ToggleConfig : ConfigurationElement
    {
        /// <summary>
        /// Gets or sets the name of the feature toggle.
        /// </summary>
        /// <value>
        /// The name of th efeature toggle.
        /// </value>
        [ConfigurationProperty("name", IsRequired = true, IsKey = true)]
        public string Name
        {
            get { return (string)this["name"]; }
            set { this["name"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this toggle is enabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if enabled; otherwise, <c>false</c>.
        /// </value>
        [ConfigurationProperty("enabled", IsRequired = true, IsKey = false)]
        public bool Enabled
        {
            get { return (bool)this["enabled"]; }
            set { this["enabled"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is immutable.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is immutable; otherwise, <c>false</c>.
        /// </value>
        [ConfigurationProperty("mutable", IsRequired = false, DefaultValue = true, IsKey = false)]
        public bool IsMutable
        {
            get { return (bool)this["mutable"]; }
            set { this["mutable"] = value; }
        }

        /// <summary>
        /// Gets or sets the date that this feature should be turned on.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is immutable; otherwise, <c>false</c>.
        /// </value>
        [ConfigurationProperty("from", IsRequired = false, DefaultValue = null, IsKey = false)]
        public DateTime? FromDate
        {
            get { return (DateTime?)this["from"]; }
            set { this["from"] = value; }
        }

        /// <summary>
        /// Gets or sets the date that this feature should be turned off.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is immutable; otherwise, <c>false</c>.
        /// </value>
        [ConfigurationProperty("until", IsRequired = false, DefaultValue = null, IsKey = false)]
        public DateTime? ToDate
        {
            get { return (DateTime?)this["until"]; }
            set { this["until"] = value; }
        }
    }
}