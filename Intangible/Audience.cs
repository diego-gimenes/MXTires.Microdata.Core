using Newtonsoft.Json;

namespace MXTires.Microdata.Core.Intangible
{
    /// <summary>
    /// Class Audience.
    /// </summary>
    public class Audience : Thing
    {
        /// <summary>
        /// The target group associated with a given audience (e.g. veterans, car owners, musicians, etc.) domain: Audience Range: Text
        /// </summary>
        /// <value>The type of the audience.</value>
        [JsonProperty("audienceType")]
        public string AudienceType { get; set; }

        /// <summary>
        /// The geographic area associated with the audience.
        /// </summary>
        /// <value>The administrative area.</value>
        [JsonProperty("administrativeArea")]
        public AdministrativeArea AdministrativeArea { get; set; }

    }
}