﻿// 
//  Copyright 2014 Gustavo J Knuppe (https://github.com/knuppe)
// 
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
// 
//       http://www.apache.org/licenses/LICENSE-2.0
// 
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// 
//   - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
//   - May you do good and not evil.                                         -
//   - May you find forgiveness for yourself and forgive others.             -
//   - May you share freely, never taking more than you give.                -
//   - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
//  

using System.Collections.Generic;

namespace SharpNL.Utility.FeatureGen {
    /// <summary>
    /// Represents a base class for custom feature generators.
    /// </summary>
    /// <seealso cref="GeneratorFactory"/>
    [TypeClass("opennlp.tools.util.featuregen.CustomFeatureGenerator")]
    public abstract class CustomFeatureGenerator : IAdaptiveFeatureGenerator {
        /// <summary>
        /// Adds the appropriate features for the token at the specified index with the
        /// specified array of previous outcomes to the specified list of features.
        /// </summary>
        /// <param name="features">The list of features to be added to.</param>
        /// <param name="tokens">The tokens of the sentence or other text unit being processed.</param>
        /// <param name="index">The index of the token which is currently being processed.</param>
        /// <param name="previousOutcomes">The outcomes for the tokens prior to the specified index.</param>
        public abstract void CreateFeatures(List<string> features, string[] tokens, int index, string[] previousOutcomes);

        /// <summary>
        /// Initialized the Custom Feature Generator with defined properties and loaded resources.
        /// </summary>
        /// <param name="properties">The properties.</param>
        /// <param name="provider">The resource provider.</param>
        public abstract void Init(Dictionary<string, string> properties, FeatureGeneratorResourceProvider provider);

        /// <summary>
        /// Informs the feature generator that the specified tokens have been classified with the
        /// corresponding set of specified outcomes.
        /// </summary>
        /// <param name="tokens">The tokens of the sentence or other text unit which has been processed.</param>
        /// <param name="outcomes">The outcomes associated with the specified tokens.</param>
        public abstract void UpdateAdaptiveData(string[] tokens, string[] outcomes);

        /// <summary>
        /// Informs the feature generator that the context of the adaptive data (typically a document)
        /// is no longer valid.
        /// </summary>
        public abstract void ClearAdaptiveData();
    }
}