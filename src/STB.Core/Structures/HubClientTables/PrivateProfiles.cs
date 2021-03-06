/*---------------------------------------------------------------------------------------------
 * Copyright (c) STB Chain. All rights reserved.
 * Licensed under the Source EULA. See License in the project root for license information.
 * Source code : https://github.com/stbchain
 * Website : http://www.soft2b.com/
 *---------------------------------------------------------------------------------------------
 ---------------------------------------------------------------------------------------------*/

using System;

namespace STB.Core.Structures.HubClientTables
{
    public class PrivateProfiles
    {
        public int? PrivateProfileId { get; set; }
        public string Unit { get; set; }
        public string PayloadHash { get; set; }
        public string AttestorAddress { get; set; }
        public string Address { get; set; }
        public string SrcProfile { get; set; }
        public DateTime? CreationDate { get; set; } = DateTime.Now;
    }
}