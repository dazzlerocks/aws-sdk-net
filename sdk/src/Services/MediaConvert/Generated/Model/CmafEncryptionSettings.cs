/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings for CMAF encryption
    /// </summary>
    public partial class CmafEncryptionSettings
    {
        private string _constantInitializationVector;
        private CmafEncryptionType _encryptionMethod;
        private CmafInitializationVectorInManifest _initializationVectorInManifest;
        private SpekeKeyProviderCmaf _spekeKeyProvider;
        private StaticKeyProvider _staticKeyProvider;
        private CmafKeyProviderType _type;

        /// <summary>
        /// Gets and sets the property ConstantInitializationVector. This is a 128-bit, 16-byte
        /// hex value represented by a 32-character text string. If this parameter is not set
        /// then the Initialization Vector will follow the segment number by default.
        /// </summary>
        [AWSProperty(Min=32, Max=32)]
        public string ConstantInitializationVector
        {
            get { return this._constantInitializationVector; }
            set { this._constantInitializationVector = value; }
        }

        // Check to see if ConstantInitializationVector property is set
        internal bool IsSetConstantInitializationVector()
        {
            return this._constantInitializationVector != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionMethod. For DRM with CMAF, the encryption type
        /// is always sample AES.
        /// </summary>
        public CmafEncryptionType EncryptionMethod
        {
            get { return this._encryptionMethod; }
            set { this._encryptionMethod = value; }
        }

        // Check to see if EncryptionMethod property is set
        internal bool IsSetEncryptionMethod()
        {
            return this._encryptionMethod != null;
        }

        /// <summary>
        /// Gets and sets the property InitializationVectorInManifest. When you use DRM with CMAF
        /// outputs, choose whether the service writes the 128-bit encryption initialization vector
        /// in the HLS and DASH manifests.
        /// </summary>
        public CmafInitializationVectorInManifest InitializationVectorInManifest
        {
            get { return this._initializationVectorInManifest; }
            set { this._initializationVectorInManifest = value; }
        }

        // Check to see if InitializationVectorInManifest property is set
        internal bool IsSetInitializationVectorInManifest()
        {
            return this._initializationVectorInManifest != null;
        }

        /// <summary>
        /// Gets and sets the property SpekeKeyProvider. Use these settings when doing DRM encryption
        /// with a SPEKE-compliant key provider, if your output group type is CMAF. If your output
        /// group type is HLS, MS Smooth, or DASH, use the SpekeKeyProvider settings instead.
        /// </summary>
        public SpekeKeyProviderCmaf SpekeKeyProvider
        {
            get { return this._spekeKeyProvider; }
            set { this._spekeKeyProvider = value; }
        }

        // Check to see if SpekeKeyProvider property is set
        internal bool IsSetSpekeKeyProvider()
        {
            return this._spekeKeyProvider != null;
        }

        /// <summary>
        /// Gets and sets the property StaticKeyProvider. Use these settings to set up encryption
        /// with a static key provider.
        /// </summary>
        public StaticKeyProvider StaticKeyProvider
        {
            get { return this._staticKeyProvider; }
            set { this._staticKeyProvider = value; }
        }

        // Check to see if StaticKeyProvider property is set
        internal bool IsSetStaticKeyProvider()
        {
            return this._staticKeyProvider != null;
        }

        /// <summary>
        /// Gets and sets the property Type. Specify whether your DRM encryption key is static
        /// or from a key provider that follows the SPEKE standard. For more information about
        /// SPEKE, see https://docs.aws.amazon.com/speke/latest/documentation/what-is-speke.html.
        /// </summary>
        public CmafKeyProviderType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}