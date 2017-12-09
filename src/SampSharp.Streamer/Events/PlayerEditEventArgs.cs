﻿// SampSharp.Streamer
// Copyright 2017 Tim Potze
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using SampSharp.GameMode;
using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.Events;
using SampSharp.GameMode.World;

namespace SampSharp.Streamer.Events
{
    public class PlayerEditEventArgs : PositionEventArgs
    {
        public PlayerEditEventArgs(BasePlayer player, EditObjectResponse response,
            Vector3 position,
            Vector3 rotation)
            : base(position)
        {
            Player = player;
            Response = response;
            Rotation = rotation;
        }

        public BasePlayer Player { get; }

        public EditObjectResponse Response { get; set; }

        public Vector3 Rotation { get; }
    }
}