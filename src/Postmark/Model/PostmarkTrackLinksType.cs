namespace PostmarkDotNet
{
    /// <summary>
    /// Represents the possible values for the 'TrackLinks' property.
    /// More details:
    /// - http://developer.postmarkapp.com/developer-link-tracking.html#types-of-link-tracking
    /// </summary>
    public enum PostmarkTrackLinksType
    {
        /// <summary>
        /// None — No links will be replaced or tracked. This is the default setting for all messages and new and existing servers.
        /// </summary>
        None,

        /// <summary>
        /// HTML and text — Links will be replaced in both HTML and Text bodies. Identical links in either body part will be considered the "same" link, and only count as one unique click, regardless of which body part the recipient clicks from.
        /// </summary>
        HtmlAndText,

        /// <summary>
        /// HTML only — Links will be replaced in only the HTMLBody. This is useful in some cases where you do not want to include encoded tracking links in the plain text of an email.
        /// </summary>
        HtmlOnly,

        /// <summary>
        /// Text only — Links will be replaced in only the TextBody.
        /// </summary>
        TextOnly
    }
}
