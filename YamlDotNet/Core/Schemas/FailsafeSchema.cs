// This file is part of YamlDotNet - A .NET library for YAML.
// Copyright (c) 2013, 2014 Antoine Aubry
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using YamlDotNet.Core.Events;

namespace YamlDotNet.Core.Schemas
{
	/// <summary>
	/// Implements the YAML failsafe schema.
	/// <see cref="http://www.yaml.org/spec/1.2/spec.html#id2802346"/>
	/// </summary>
	/// <remarks>
	/// The failsafe schema is guaranteed to work with any YAML document.
	/// It is therefore the recommended schema for generic YAML tools.
	/// A YAML processor should therefore support this schema,
	/// at least as an option. 
	/// </remarks>
	public class FailsafeSchema : Schema
	{
		protected override string GetTag (Scalar scalar)
		{
			return "tag:yaml.org,2002:str";
		}
		
		protected override string GetTag (SequenceStart sequenceStart)
		{
			return "tag:yaml.org,2002:seq";
		}
		
		protected override string GetTag (MappingStart mappingStart)
		{
			return "tag:yaml.org,2002:map";
		}
	}
}
