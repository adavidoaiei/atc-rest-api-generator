﻿using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 1.0.216.0.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Generated.Contracts.Items
{
    /// <summary>
    /// Item.
    /// </summary>
    [GeneratedCode("ApiGenerator", "1.0.216.0")]
    public class Item
    {
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}";
        }
    }
}