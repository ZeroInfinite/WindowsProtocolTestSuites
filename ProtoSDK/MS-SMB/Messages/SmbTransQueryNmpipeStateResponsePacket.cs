// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Smb
{
    /// <summary>
    /// Packets for SmbTransQueryNmpipeState Response
    /// </summary>
    [CLSCompliant(false)]
    public class SmbTransQueryNmpipeStateResponsePacket : Cifs.SmbTransQueryNmpipeStateSuccessResponsePacket
    {
        #region Convert from base class

        /// <summary>
        /// initialize packet from base packet. 
        /// </summary>
        /// <param name = "packet">the base packet to initialize this packet. </param>
        public SmbTransQueryNmpipeStateResponsePacket(Cifs.SmbTransQueryNmpipeStateSuccessResponsePacket packet)
            : base(packet)
        {
        }


        #endregion

        #region Constructor

        /// <summary>
        /// Constructor. 
        /// </summary>
        public SmbTransQueryNmpipeStateResponsePacket()
            : base()
        {
        }


        /// <summary>
        /// Constructor: Create a request directly from a buffer. 
        /// </summary>
        public SmbTransQueryNmpipeStateResponsePacket(byte[] data)
            : base(data)
        {
        }


        /// <summary>
        /// Deep copy constructor. 
        /// </summary>
        public SmbTransQueryNmpipeStateResponsePacket(SmbTransQueryNmpipeStateResponsePacket packet)
            : base(packet)
        {
        }


        #endregion
    }
}