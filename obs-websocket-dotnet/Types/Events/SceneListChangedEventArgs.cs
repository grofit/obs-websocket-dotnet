using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace OBSWebsocketDotNet.Types.Events
{
    /// <summary>
    /// Event args for <see cref="OBSWebsocket.SceneListChanged"/>
    /// </summary>
    public class SceneListChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Updated array of scenes
        /// </summary>
        public IReadOnlyCollection<JObject> Scenes { get; }
        
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="scenes">Collection of scene data as JObjects</param>
        public SceneListChangedEventArgs(IReadOnlyCollection<JObject> scenes)
        {
            Scenes = scenes;
        }
    }
}