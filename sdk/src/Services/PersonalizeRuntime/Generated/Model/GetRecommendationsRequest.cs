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
 * Do not modify this file. This file is generated from the personalize-runtime-2018-05-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PersonalizeRuntime.Model
{
    /// <summary>
    /// Container for the parameters to the GetRecommendations operation.
    /// Returns a list of recommended items. The required input depends on the recipe type
    /// used to create the solution backing the campaign, as follows:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// RELATED_ITEMS - <code>itemId</code> required, <code>userId</code> not used
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// USER_PERSONALIZATION - <code>itemId</code> optional, <code>userId</code> required
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// Campaigns that are backed by a solution created using a recipe of type PERSONALIZED_RANKING
    /// use the API.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetRecommendationsRequest : AmazonPersonalizeRuntimeRequest
    {
        private string _campaignArn;
        private string _itemId;
        private int? _numResults;
        private string _userId;

        /// <summary>
        /// Gets and sets the property CampaignArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the campaign to use for getting recommendations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string CampaignArn
        {
            get { return this._campaignArn; }
            set { this._campaignArn = value; }
        }

        // Check to see if CampaignArn property is set
        internal bool IsSetCampaignArn()
        {
            return this._campaignArn != null;
        }

        /// <summary>
        /// Gets and sets the property ItemId. 
        /// <para>
        /// The item ID to provide recommendations for.
        /// </para>
        ///  
        /// <para>
        /// Required for <code>RELATED_ITEMS</code> recipe type.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ItemId
        {
            get { return this._itemId; }
            set { this._itemId = value; }
        }

        // Check to see if ItemId property is set
        internal bool IsSetItemId()
        {
            return this._itemId != null;
        }

        /// <summary>
        /// Gets and sets the property NumResults. 
        /// <para>
        /// The number of results to return. The default is 25. The maximum is 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int NumResults
        {
            get { return this._numResults.GetValueOrDefault(); }
            set { this._numResults = value; }
        }

        // Check to see if NumResults property is set
        internal bool IsSetNumResults()
        {
            return this._numResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The user ID to provide recommendations for.
        /// </para>
        ///  
        /// <para>
        /// Required for <code>USER_PERSONALIZATION</code> recipe type.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}