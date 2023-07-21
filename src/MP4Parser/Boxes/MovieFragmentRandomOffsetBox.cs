﻿//Copyright 2015 Prakash Duggaraju
//
//Licensed under the Apache License, Version 2.0 (the "License");
//you may not use this file except in compliance with the License.
//You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
//Unless required by applicable law or agreed to in writing, software
//distributed under the License is distributed on an "AS IS" BASIS,
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//See the License for the specific language governing permissions and
//limitations under the License.

namespace Media.ISO.Boxes
{
    [BoxType(BoxType.MovieFragmentRandomOffsetBox)]
    public class MovieFragmentRandomOffsetBox : FullBox
    {
        public MovieFragmentRandomOffsetBox()
            : base(BoxType.MovieFragmentRandomOffsetBox)
        {
        }

        /// <summary>
        /// The size of the parent Random access box.
        /// </summary>
        public uint BoxSize { get; set; }

        protected override int BoxContentSize => 4;

        protected override void ParseContent(BoxReader reader)
        {
            BoxSize = reader.ReadUInt32();
        }

        protected override void WriteBoxContent(BoxWriter writer)
        {
            writer.WriteUInt32(BoxSize);
        }
    }
}
