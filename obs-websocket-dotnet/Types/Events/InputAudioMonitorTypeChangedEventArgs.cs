﻿namespace OBSWebsocketDotNet.Types.Events
{
    /// <summary>
    /// Event args for <see cref="OBSWebsocket.InputAudioMonitorTypeChanged"/>
    /// Available types are:
    /// - `OBS_MONITORING_TYPE_NONE`
    /// - `OBS_MONITORING_TYPE_MONITOR_ONLY`
    /// - `OBS_MONITORING_TYPE_MONITOR_AND_OUTPUT`
    /// </summary>
    public class InputAudioMonitorTypeChangedEventArgs
    {
        /// <summary>
        /// Name of the input
        /// </summary>
        public string InputName { get; }
        
        /// <summary>
        /// New monitor type of the input
        /// </summary>
        public string MonitorType { get; }

        public InputAudioMonitorTypeChangedEventArgs(string inputName, string monitorType)
        {
            InputName = inputName;
            MonitorType = monitorType;
        }
    }
}