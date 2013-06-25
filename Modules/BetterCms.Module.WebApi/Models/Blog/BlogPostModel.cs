﻿using System.Runtime.Serialization;

using BetterCms.Module.WebApi.Models.Pages;

namespace BetterCms.Module.WebApi.Models.Blog
{
    [DataContract]
    public class BlogPostModel : PageModel
    {
        /// <summary>
        /// Gets or sets the blog post author id.
        /// </summary>
        /// <value>
        /// The blog post author id.
        /// </value>
        [DataMember(Order = 510, Name = "authorId")]
        public System.Guid? AuthorId { get; set; }

        /// <summary>
        /// Gets or sets the blog post activation date.
        /// </summary>
        /// <value>
        /// The blog post activation date.
        /// </value>
        [DataMember(Order = 520, Name = "activationDate")]
        public System.DateTime ActivationDate { get; set; }

        /// <summary>
        /// Gets or sets the blog post expiration date.
        /// </summary>
        /// <value>
        /// The blog post expiration date.
        /// </value>
        [DataMember(Order = 530, Name = "expirationDate")]
        public System.DateTime? ExpirationDate { get; set; }
    }
}