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

using System;
using System.IO;

namespace SharpNL.Utility {
    /// <summary>
    /// Class MockInputStreamFactory.
    /// </summary>
    public class MockInputStreamFactory : IInputStreamFactory {

        private readonly Stream inputStream;

        /// <summary>
        /// Initializes a new instance of the <see cref="MockInputStreamFactory"/> class.
        /// </summary>
        /// <param name="inputStream">The input stream.</param>
        /// <exception cref="System.ArgumentNullException">inputStream</exception>
        public MockInputStreamFactory(Stream inputStream) {
            if (inputStream == null)
                throw new ArgumentNullException("inputStream");

            this.inputStream = inputStream;
        }

        /// <summary>
        /// Creates the input stream.
        /// </summary>
        /// <returns>Stream.</returns>
        public virtual Stream CreateInputStream() {
            return inputStream;
        }
    }
}