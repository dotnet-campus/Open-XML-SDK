// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using BenchmarkDotNet.Attributes;
using DocumentFormat.OpenXml.Framework.Metadata;

namespace DocumentFormat.OpenXml.Benchmarks
{
    public class ElementMetadataTests
    {
        [GlobalSetup]
        public void Setup()
        {
            _element = new AlternateContent();
        }

        private OpenXmlElement _element;

        [BenchmarkCategory("ElementMetadataTests")]
        [Benchmark]
        public void Create()
        {
            _ = ElementMetadata.Create(_element);
        }

        [BenchmarkCategory("ElementMetadataTests")]
        [Benchmark]
        public void Create2()
        {
            _ = ElementMetadata.Create2(_element);
        }
    }
}
